using System;
using System.Drawing;
using System.Windows.Forms;

namespace MuslimWidget
{

    public partial class NotificationPanel : UserControl
    {

        private Ayetler ayet=new Ayetler();

        public NotificationPanel(string title,string content,Bitmap img)
        {
            InitializeComponent();
            lbl_title.Text = title;
            lbl_content.Text = content;
            pictureBox1.Image = img;
        }

     

    }
}
