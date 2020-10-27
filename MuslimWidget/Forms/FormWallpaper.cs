using System;
using System.Drawing;
using System.Windows.Forms;

namespace MuslimWidget
{
    public partial class FormWallpaper : Form
    {
        public FormWallpaper()
        {
            InitializeComponent();
        }

        private void Wallpaper_Load(object sender, EventArgs e)
        {
            if (!NetworkControl.NetworkConnection())
            {
                MessageBox.Show("Lütfen internet bağlantınızı kontrol edin.", "No connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            lbl_info.Text = "Yükleniyor... Lütfen bekleyin.";
            wb_wallpaper.DocumentCompleted += Wb_wallpaper_DocumentCompleted;
            wb_wallpaper.Navigate("https://islamiduvarkagitlari.blogspot.com/2020/10/duvar-kagtlar.html");
        }

        #region Get pictures
        private ImageDownloader id = new ImageDownloader(); 
        private string[] links;
        private void Wb_wallpaper_DocumentCompleted(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
        {
            if (!NetworkControl.NetworkConnection())
            {
                MessageBox.Show("Lütfen internet bağlantınızı kontrol edin.", "No connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var v = wb_wallpaper.Document.GetElementsByTagName("img");

           links = new string[v.Length];
            for (int i = 0; i < v.Length; i++)
                links[i] = v[i].GetAttribute("src");

           GetPictures() ;
         
        }

        private async  void GetPictures()
        {           
            for (int i = 0; i < links.Length; i++)
            {          
                Bitmap b =   await id.DownloadımageAsync(links[i]);            
                PictureBox p = new PictureBox();
                p.Size = new Size(300, 300);
                p.SizeMode = PictureBoxSizeMode.Zoom;
                p.Image = b;
                p.BackColor = Color.FromArgb(30,30,30);
                toolTip1.SetToolTip(p,"Görüntüle");
                p.Click += P_Click;
                flpMain.Controls.Add(p);
            }
            lbl_info.Text = "*Duvar kağıtlarını görüntülemek ve indirmek için üzerine tıklayın.";
        }

        private void P_Click(object sender, EventArgs e)
        {
            Bitmap bmp = (Bitmap)((PictureBox)sender).Image;
            new FormShowImage(bmp).Show();
        }
        #endregion

    }
}
