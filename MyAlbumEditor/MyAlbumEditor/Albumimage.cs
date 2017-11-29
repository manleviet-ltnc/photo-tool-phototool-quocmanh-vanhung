using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manning.MyPhotoAlbum;
using Manning.MyPhotoControls;

namespace MyAlbumEditor
{
    public partial class Albumimage : UserControl
    {
        private AlbumManager _manager = null;
        public AlbumManager Manager
        {
            get { return _manager; }
            set
            {
                _manager = value;
                if (Manager != null) Manager.Index = 0;
                UpdateImage();
            }
        }

        private WorkerProgressDialog _worker;
        public WorkerProgressDialog WorkDialog
        {
            get { return _worker; }
        }
                public Albumimage()
        {
 
            InitializeComponent();
        }

        private void UpdateImage()
        {
            if (Manager == null || Manager.Current == null)
                pbxPhotos.Image = null;
            else
                AssignImage();
            EnableButtons();
        }

        private void EnableButtons()
        {
            bool haveImage = (pbxPhotos.Image != null);
            btnNext.Enabled = (haveImage
                && Manager.Index < Manager.Album.Count - 1);
            btnPrevious.Enabled = (haveImage
            && Manager.Index > 0);
            btnColor.Enabled = haveImage;
        }

        private void AssignImage()
        {
            Bitmap bmp = Manager.Current.Image;
            if (UseColor)
                pbxPhotos.Image = bmp;
            else
                CreateBlackWhiteImage(bmp);
        }
        private void CreateBlackWhiteImage(Bitmap bmp)
        {

            BackgroundWorker bw = new BackgroundWorker();
            bw.DoWork += worker_DoWork;
            bw.ProgressChanged += worker_ProgressChanged;
            bw.RunWorkerCompleted += worker_RunWorkerCompleted;
            bw.WorkerSupportsCancellation = true;
            bw.WorkerReportsProgress = true;

            _worker = new WorkerProgressDialog();
            WorkDialog.Progress = 0;
            pbxPhotos.Image = null;
            bw.RunWorkerAsync(bmp);

            if (WorkDialog.ShowDialog() == DialogResult.Cancel)
                bw.CancelAsync();
        }
        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker bw = sender as BackgroundWorker;
            e.Result = null;

            Bitmap bmp = e.Argument as Bitmap;
            int width = bmp.Width;
            int height = bmp.Height;

            Bitmap bwImage = new Bitmap(width, height);
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (bw.CancellationPending)
                        return;

                    Color c = bmp.GetPixel(i, j);
                    double redFactor = 0.30 * (double)c.R;
                    double greenFactor = 0.59 * (double)c.G;
                    double blueFactor = 0.11 * (double)c.B;
                    int x = (int)(redFactor + greenFactor + blueFactor);

                    Color bwColor = Color.FromArgb(x, x, x);
                    bwImage.SetPixel(i, j, bwColor);
                }

                bw.ReportProgress(i / width * 100);
            }

            e.Result = bwImage;
        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (WorkDialog != null)
                WorkDialog.Progress = e.ProgressPercentage;
        }

        void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("Unable to convert image to black and white ("
                    + e.Error.Message + ")");
            }
            else
            {
                Bitmap bmp = e.Result as Bitmap;
                if (e.Cancelled || bmp == null)
                    pbxPhotos.Image = Manager.Current.Image;
                else
                    pbxPhotos.Image = bmp;
            }

            WorkDialog.Close();
            EnableButtons();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Manager.MoveNext();
            UpdateImage();
        }

        private bool _useColor = true;
        private bool UseColor
        {
            get { return _useColor; }
            set { _useColor = value; }
        }
        private void btnColor_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            UseColor = (btn.Text == "Colo&r");
            if (UseColor)
                btn.Text = "B && &W";
            else
                btn.Text = "Colo&r";

            UpdateImage();
        }
    }
}
