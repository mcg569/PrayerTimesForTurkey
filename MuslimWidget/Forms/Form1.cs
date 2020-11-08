using Gecko;
using MuslimWidget.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace MuslimWidget
{
    public enum KerahatVakti { Null, Sabah, Ogle, Ikindi, Aksam, Yatsi }
    public partial class Form1 : Form
    {
        public Form1()
        {
            if (!Directory.Exists(PathManager.folder)) Directory.CreateDirectory(PathManager.folder);

            ayet = new Ayetler();
            hadis = new Hadisler();

            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            InitializeComponent();
            Xpcom.Initialize("Firefox");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeData();
            AddNotification();
        }



        #region Notification
        private Ayetler ayet ;
        private Hadisler hadis;
        private void AddNotification()
        {
            string title = "", content = "";
            Bitmap img = null;

            int random = new Random().Next(0, 2);
            if (random == 0)//ayet
            {
                title = "Ayet";
                content = ayet.GetRandomAyet();
                img = Resources.ayet;
            }
            else//hadis
            {
                title = "Hadis";
                content = hadis.GetRandomHadis();
                img = Resources.hadis;
            }

            if (DateTime.Now.DayOfWeek.ToString().Contains("Friday"))
            {
                title += " ~ HAYIRLI CUMALAR ";
                img = Resources.muslim;
            }

            pnlBottom.Controls.Clear();
            NotificationPanel notificationPanel = new NotificationPanel(title, content, img);
            pnlBottom.Controls.Add(notificationPanel);
            notificationPanel.Location = new Point((pnlBottom.Width - notificationPanel.Width) / 2, (pnlBottom.Height - notificationPanel.Height) / 2);
            notificationPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
        }
        #endregion

        #region Ezan

        #region Init
        private void InitializeData()
        {
            wbAzan.DocumentCompleted += WbEzan_DocumentCompleted;

            if (!File.Exists(PathManager.data_sehir_path))
                File.WriteAllText(PathManager.data_sehir_path, "Ankara");

            city = File.ReadAllText(PathManager.data_sehir_path);
            cbx_Cities.SelectedItem = city;



            if (!File.Exists(PathManager.data_ezan_path))
                DownloadAzanTimes();
            else
                ShowAzanTime();
        }
        #endregion

        #region Select city
        private string city;
        private void SelectCity(string mCity)
        {
            File.WriteAllText(PathManager.data_sehir_path, mCity);
            lbl_default_city.Text = "Şehir: " + mCity + " »";
            if (city != mCity)
            {
                city = mCity;
                DownloadAzanTimes();
            }
            lbl_default_city.Location = new System.Drawing.Point(pnlAzanTop.Width - lbl_default_city.Size.Width - 10, 5);

        }
        private void cbx_Cities_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectCity(cbx_Cities.Text);
            cbx_Cities.Visible = false;
        }
        private void lbl_default_city_Click(object sender, EventArgs e)
        {
            cbx_Cities.Visible = true;
        }
        #endregion

        #region Download Data
        private void btnDownloadData_Click(object sender, EventArgs e)
        {
            DownloadAzanTimes();
        }
        private void DownloadAzanTimes()
        {

            if (!NetworkControl.NetworkConnection())
            {
                MessageBox.Show("Lütfen internet bağlantınızı kontrol edin.", "No connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            timer_remaining_time.Stop();
            lbl_date_today.Text = "Yükleniyor...";
            lbl_imsak_time.Text = "...";
            lbl_gunes_time.Text = "...";
            lbl_ogle_time.Text = "...";
            lbl_ikindi_time.Text = "...";
            lbl_aksam_time.Text = "...";
            lbl_yatsi_time.Text = "...";
            lbl_remaining_time.Text = "...";
            lbl_next_time.Text = "Yükleniyor...";
            flp_Times.Controls.Clear();

            city = city.ToLower();
            char[] cr = new char[] { 'ç', 'ğ', 'ı', 'ö', 'ş', 'ü' };
            char[] cr2 = new char[] { 'c', 'g', 'i', 'o', 's', 'u' };
            for (int i = 0; i < cr.Length; i++)
                city = city.Replace(cr[i], cr2[i]);

            wbAzan.Navigate("https://www.sabah.com.tr/" + city + "-namaz-vakitleri");
        }
        private void WbEzan_DocumentCompleted(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
        {
            UpdateAzanTimes();
        }

        private void UpdateAzanTimes()
        {
            List<string> _pt = new List<string>();
            var tag_tr = wbAzan.Document.GetElementsByTagName("tr");
            for (int f = 0; f < tag_tr.Length; f++)
            {
                try
                {
                    var dt = tag_tr[f].GetElementsByTagName("td");
                    if (dt == null || dt.Length <= 0) continue;

                    PrayerTime pt = new PrayerTime()
                    {
                        date = dt[0].TextContent,
                        imsak = dt[1].TextContent,
                        gunes = dt[2].TextContent,
                        ogle = dt[3].TextContent,
                        ikindi = dt[4].TextContent,
                        aksam = dt[5].TextContent,
                        yatsi = dt[6].TextContent
                    };
                    _pt.Add(pt.date + "|" + pt.imsak + "|" + pt.gunes + "|" + pt.ogle + "|" + pt.ikindi + "|" + pt.aksam + "|" + pt.yatsi);
                }
                catch { }
            }
            File.WriteAllLines(PathManager.data_ezan_path, _pt);
            ShowAzanTime();
        }
        #endregion

        #region  Show Times
        private DateTime nextTime;
        private KerahatVakti kerahatVakti;
        private void ShowAzanTime()
        {
            timer_remaining_time.Stop();
            flp_Times.Controls.Clear();
            NextDayEzan n = new NextDayEzan(new PrayerTime() { date = "  -TARİH-  ", imsak = "-İmsak-", gunes = "-Güneş-", ogle = "-Öğle-", ikindi = "-İkindi-", aksam = "-Akşam-", yatsi = "-Yatsı-" }, "flat");
            flp_Times.Controls.Add(n);


            string[] ezanTimes = File.ReadAllLines(PathManager.data_ezan_path);
            foreach (string dt in ezanTimes)
            {
                string[] splitDay = dt.Split('|');
                PrayerTime pt = new PrayerTime
                {
                    date = splitDay[0],
                    imsak = splitDay[1],
                    gunes = splitDay[2],
                    ogle = splitDay[3],
                    ikindi = splitDay[4],
                    aksam = splitDay[5],
                    yatsi = splitDay[6]
                };

              if (pt.date == DateTime.Now.ToShortDateString() || pt.date == "0" + DateTime.Now.ToShortDateString()) //today => 1.01.2020  || 01.01.2020
                {
                    lbl_date_today.Text = "Bugün " + DateTime.Now.ToLongDateString();
                    lbl_imsak_time.Text = pt.imsak;
                    lbl_gunes_time.Text = pt.gunes;
                    lbl_ogle_time.Text = pt.ogle;
                    lbl_ikindi_time.Text = pt.ikindi;
                    lbl_aksam_time.Text = pt.aksam;
                    lbl_yatsi_time.Text = pt.yatsi;

                    Color color = Color.FromArgb(29, 56, 45);
                    Color color_tp = Color.Transparent;

                    pnlImsak.BackColor = color_tp;
                    pnlGunes.BackColor = color_tp;
                    pnlOgle.BackColor = color_tp;
                    pnlIkindi.BackColor = color_tp;
                    pnlAksam.BackColor = color_tp;
                    pnlYatsi.BackColor = color_tp;

                    if (DateTime.Now > Convert.ToDateTime(pt.yatsi))
                    {
                        AddNotification();
                        pnlYatsi.BackColor = color;
                        kerahatVakti = KerahatVakti.Yatsi;
                        lbl_next_time.Text = "Hayırlı Geceler\n\nİmsak: ";
                        nextTime = Convert.ToDateTime(pt.imsak).AddDays(1);
                    }
                    else if (DateTime.Now > Convert.ToDateTime(pt.aksam))
                    {
                        AddNotification();
                        pnlAksam.BackColor = color;
                        kerahatVakti = KerahatVakti.Aksam;
                        lbl_next_time.Text = "Yatsı vaktine kalan süre:";
                        nextTime = Convert.ToDateTime(pt.yatsi);
                    }
                    else if (DateTime.Now > Convert.ToDateTime(pt.ikindi))
                    {
                        AddNotification();
                        pnlIkindi.BackColor = color;
                        kerahatVakti = KerahatVakti.Ikindi;
                        lbl_next_time.Text = "Akşam vaktine kalan süre:";
                        nextTime = Convert.ToDateTime(pt.aksam);
                    }
                    else if (DateTime.Now > Convert.ToDateTime(pt.ogle))
                    {
                        AddNotification();
                        pnlOgle.BackColor = color;
                        kerahatVakti = KerahatVakti.Ogle;
                        lbl_next_time.Text = "İkindi vaktine kalan süre:";
                        nextTime = Convert.ToDateTime(pt.ikindi);
                    }
                    else if (DateTime.Now > Convert.ToDateTime(pt.gunes))
                    {
                        AddNotification();
                        kerahatVakti = KerahatVakti.Sabah;
                        pnlGunes.BackColor = color;
                        lbl_next_time.Text = "Öğle vaktine kalan süre:";
                        nextTime = Convert.ToDateTime(pt.ogle);
                    }
                    else if (DateTime.Now > Convert.ToDateTime(pt.imsak))
                    {
                        AddNotification();
                        kerahatVakti = KerahatVakti.Null;
                        pnlImsak.BackColor = color;
                        lbl_next_time.Text = "Güneş vaktine kalan süre:";
                        nextTime = Convert.ToDateTime(pt.gunes);
                    }
                    timer_remaining_time.Start();
                }
                else if (Convert.ToDateTime(pt.date) > DateTime.Now)
                {
                    NextDayEzan nde = new NextDayEzan(pt);
                    flp_Times.Controls.Add(nde);
                }

            }

        }
        #endregion

        #region Alarm Notification
        private bool alarm = false;
        private void Alarm()
        {
            if (alarm) return;
           
            alarm = true;
            int alarm_time = (int)Properties.Settings.Default.alarm_time;
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(5000, "Ezana son "+ alarm_time+" dk", "Ezan'ın okunmasına " + alarm_time + " dakika kaldı",ToolTipIcon.Info);
            

        }
        #endregion

        #region Timer remaining time
        private void Kerahat(bool a)
        {
            lbl_remaining_time.ForeColor = a ? Color.Black : Color.White;
            lbl_next_time.ForeColor = a ? Color.Black : Color.White;
            if (a) lbl_next_time.Text = "KERAHAT VAKTİ";
        }
        private void timer_kalan_süre_Tick(object sender, EventArgs e)
        {

            var kalan = (nextTime - DateTime.Now);
            lbl_remaining_time.Text = string.Format("{0}:{1}:{2}", kalan.Hours < 10 ? "0" + kalan.Hours.ToString() : kalan.Hours.ToString(),
                 kalan.Minutes < 10 ? "0" + kalan.Minutes.ToString() : kalan.Minutes.ToString(),
               kalan.Seconds < 10 ? "0" + kalan.Seconds.ToString() : kalan.Seconds.ToString());

            int kerahat_time = (int)Properties.Settings.Default.kerahat_time;
            int alarm_time = (int)Properties.Settings.Default.alarm_time;

            if (alarm_time != 0)
                if ((int)kalan.TotalMinutes == alarm_time)
                {
                    Alarm();
                }
                else
                {
                    alarm = false;
                }

            if (kerahatVakti == KerahatVakti.Sabah)//gunes ile ogle arası
            {
                if (Convert.ToDateTime(lbl_gunes_time.Text).AddMinutes(kerahat_time).TimeOfDay >= DateTime.Now.TimeOfDay) //güneş doğduktan sonraki 45dk
                {
                    Kerahat(true);
                }
                else if (Convert.ToDateTime(lbl_ogle_time.Text).AddMinutes(-kerahat_time).TimeOfDay <= DateTime.Now.TimeOfDay) //öğleden önceki 45 dk
                {
                    Kerahat(true);
                }
                else
                {
                    Kerahat(false);
                }
            }
            else if (kerahatVakti == KerahatVakti.Ikindi)//ikindi akşam arası
            {
                if (Convert.ToDateTime(lbl_aksam_time.Text).AddMinutes(-kerahat_time).TimeOfDay <= DateTime.Now.TimeOfDay) //aksamdan önce 45dk
                {
                    Kerahat(true);
                }
                else
                {
                    Kerahat(false);
                }
            }
            else
            {
                Kerahat(false);
            }

            if (kalan.TotalSeconds <= 0) ShowAzanTime();
        }



        #endregion

        #endregion

        #region Buttons
        private void btnKuran_Click(object sender, EventArgs e)
        {
            FormReadQuran fko = new FormReadQuran();
            fko.Show();
        }

        private void btnKazaTakip_Click(object sender, EventArgs e)
        {
            FormKazaTakip kt = new FormKazaTakip();
            kt.Show();
        }

        private void btnZikirMatik_Click(object sender, EventArgs e)
        {
            FormZikirmatik zm = new FormZikirmatik();
            zm.Show();
        }

        private void btnDuvarKagidi_Click(object sender, EventArgs e)
        {
            FormWallpaper wp = new FormWallpaper();
            wp.Show();
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            FormSettings s = new FormSettings();
            s.Show();
        }
        #endregion

        #region Close & NotifyIcon
        private bool AllowClose;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool b = Properties.Settings.Default.close_minimize;
            if (b)
            {
                if (!AllowClose)
                {
                    e.Cancel = true;
                    HideMe();
                }
            }
        }

        private void HideMe()
        {
            notifyIcon1.Visible = true;
            if ((int)Properties.Settings.Default.alarm_time == 0) timer_remaining_time.Enabled = false;

            try
            {
                notifyIcon1.Text = string.Format("-{0}-\nİ:{1}\nG:{2}\nÖ:{3}\nİ:{4}\nA:{5}\nY:{6}",
                city, lbl_imsak_time.Text, lbl_gunes_time.Text, lbl_ogle_time.Text, lbl_ikindi_time.Text, lbl_aksam_time.Text, lbl_yatsi_time.Text);
            }
            catch
            {
                notifyIcon1.Text = "Ezan Vakitleri";
            }

            this.Hide();
        }
        private void ShowMe()
        {
            this.Show();
            notifyIcon1.Visible = false;
            timer_remaining_time.Enabled = true;
        }

        private void tsmi_showme_Click(object sender, EventArgs e)
        {
            ShowMe();
        }

        private void tsmi_close_Click(object sender, EventArgs e)
        {
            AllowClose = true;
            this.Close();
            Application.Exit();
        }

        #endregion
    }
}
