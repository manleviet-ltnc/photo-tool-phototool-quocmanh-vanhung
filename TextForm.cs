using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScrollablePictureBox_Text
{
    public partial class TextForm : Form
    {
        public TextForm()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                spbxImage.Image = Image.FromFile(dlg.FileName);
            }
        }

        private void cmbSizeMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSizeMode.Text.Length > 0)
            {
                spbxImage.SizeMode = (PictureBoxSizeMode)
                    Enum.Parse(typeof(PictureBoxSizeMode),
                               cmbSizeMode.Text);
            }
        }
    }
}
