using System.Drawing;
using System.Windows.Forms;

namespace MuslimWidget
{
    public partial class FormShowImage : Form
    {
        public FormShowImage(Bitmap bmp)
        {
            InitializeComponent();
            pbx_main.Image = bmp;
            lbl_info.Text = "Boyut: " + bmp.Width + "x" + bmp.Height + " px";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PNG image | *.png";
                sfd.FileName= "wp_image";
                sfd.Title = "Kaydetmek için bir yer seçin";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    pbx_main.Image.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
        }
    }
}
