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
    public partial class albumCalendar : UserControl
    {
        private AlbumManager _manager;
        private AlbumManager Manager
        {
            get { return _manager; }
            set
            {
                _manager = value;
                UpdateCalendar();
            }

        }
        public albumCalendar()
        {
            InitializeComponent();
        }
        private void UpdateCalendar()
        {
            DateTime mindate = DateTime.MaxValue;
            DateTime maxdate = DateTime.MinValue;
            calDates.RemoveAllBoldedDates();


            if (Manager == null)
            {
                mindate = DateTime.Now;
                maxdate = DateTime.Now.AddMonths(2);
            }
            else
            {
                foreach (Photograph p in Manager.Album)
                {
                    DateTime date = p.DateTaken;
                    calDates.AddBoldedDate(date);
                    if (date < mindate) mindate = date;
                    if (date > maxdate) maxdate = date;
                }
            }
            calDates.MinDate = mindate;
            calDates.MaxDate = maxdate;
            calDates.TodayDate = mindate;
            calDates.SelectionStart = mindate;
            calDates.UpdateBoldedDates();
        }

        private void albumCalendar_MouseDown(object sender, MouseEventArgs e)
        {
            // Ignore click if no album selected
            if (Manager == null) return;

            MonthCalendar.HitTestInfo info = calDates.HitTest(e.X, e.Y);
            if (info.HitArea == MonthCalendar.HitArea.Date)
            {
                ContextMenuStrip cms = new ContextMenuStrip();
                cms.ShowImageMargin = false;

                // See if any photos at date
                for (int i = 0; i < Manager.Album.Count; i++)
                {
                    Photograph p = Manager.Album[i];
                    if (p.DateTaken.Date == info.Time.Date)
                    {
                        ToolStripItem menuItem = cms.Items.Add(p.FileName);
                        menuItem.Tag = i;
                        menuItem.Click += cmsItem_Click;
                    }
                }

                if (cms.Items.Count > 0)
                    cms.Show(calDates, e.Location);
            }
        }
        private void cmsItem_Click(object sender, EventArgs e)
        {
            ToolStripItem item = sender as ToolStripItem;
            if (item != null && item.Tag is int)
            {
                Manager.Index = (int)item.Tag;
                using (PhotoEditDialog dlg = new PhotoEditDialog(Manager))
                {
                    DateTime oldDate = Manager.Current.DateTaken;
                    if (dlg.ShowDialog() == DialogResult.OK
                        && oldDate != Manager.Current.DateTaken)
                    {
                        // DateTaken was modified
                        UpdateCalendar();
                    }
                }
            }
        }
    }
}
