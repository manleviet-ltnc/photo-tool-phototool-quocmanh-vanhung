using System;
using System.IO;
using System.Windows.Forms;
using Manning.MyPhotoAlbum;
using Manning.MyPhotoControls;

namespace MyAlbumExplorer
{
    public partial class ExplorerForm : Form
    {
        public ExplorerForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            // Assign title bar
            Version v = new Version(Application.ProductVersion);
            this.Text = String.Format("MyAlbumExplorer {0:#}.{1:#}",
                                       v.Major, v.Minor);

            atvAlbumTree.Nodes.Clear();
            atvAlbumTree.AddAlbumDirectory("Default Albums",
                AlbumManager.DefaultPath);


            base.OnLoad(e);
        }
    }
}
