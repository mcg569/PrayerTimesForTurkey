using System.Drawing;
using System.Windows.Forms;

namespace MuslimWidget
{
    public partial class NextDayEzan : UserControl
    {
        public NextDayEzan(PrayerTime pt,string style)
        {
            InitializeComponent();
          
            foreach (Label lbl in this.Controls)
            {
                lbl.Font = new Font("Tahoma", 10, FontStyle.Bold);
                lbl.ForeColor = Color.Gold;
            }
            Texts(pt);
        }
        public NextDayEzan(PrayerTime pt)
        {
            InitializeComponent();
            Texts(pt);
        }

        private void Texts(PrayerTime pt)
        {
            lbl_date.Text = pt.date;
            lbl_imsak.Text = pt.imsak;
            lbl_gunes.Text = pt.gunes;
            lbl_ogle.Text = pt.ogle;
            lbl_ikindi.Text = pt.ikindi;
            lbl_aksam.Text = pt.aksam;
            lbl_yatsi.Text = pt.yatsi;
        }

    }
}
