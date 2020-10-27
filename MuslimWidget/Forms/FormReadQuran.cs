using Gecko;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace MuslimWidget
{
    public partial class FormReadQuran : Form
    {
        public FormReadQuran()
        {
            InitializeComponent();
            Xpcom.Initialize("Firefox");

        }

        private void FormKuranOku_Load(object sender, EventArgs e)
        {
            cbx_tema.SelectedIndex = 0;
            Init();
            panel1.Location = new Point((this.Width-panel1.Width)/2,(this.Height-panel1.Height)/2);
        }


        #region Download Kuran
        int id = 0;
        List<string> linkListesi = new List<string>();
        private void DownloadData()
        {
            wb_Kuran1.Navigate("http://www.kuranikerim.com/m_diyanet_index.htm");
            wb_Kuran1.DocumentCompleted += Wb_Kuran_DocumentCompleted;
        }

        private void Wb_Kuran_DocumentCompleted(object sender, Gecko.Events.GeckoDocumentCompletedEventArgs e)
        {
            if (id > 0)
            {
                GeckoElementCollection b = wb_Kuran1.Document.GetElementsByTagName("b");
                string sure = "";
                for (int i = 0; i < b.Length; i++)
                {
                    sure += "\n" + b[i].TextContent;
                }

                File.WriteAllText(PathManager.data_sure_path + linkListesi[id - 1].Substring(36).Replace(".htm", "") + ".txt", sure);

            }
            else
            {
                GeckoElementCollection a = wb_Kuran1.Document.GetElementsByTagName("a");

                for (int i = 0; i < a.Length; i++)
                {
                    string link = a[i].GetAttribute("tppabs");
                    if (!link.Contains(".htm")) link += ".htm";
                    linkListesi.Add(link);
                }


                string[] surelistesi = linkListesi.ToArray();
                Array.Sort(surelistesi);
                for (int i = 0; i < surelistesi.Length; i++) surelistesi[i] = surelistesi[i].Substring(36).Replace(".htm", "");
                File.WriteAllLines(PathManager.data_surelist_path, surelistesi);

                progressBar1.Maximum = linkListesi.Count;
            }

            if (id >= linkListesi.Count) { MessageBox.Show("İndirme işlemi tamamlandı. Lütfen uygulamayı yeniden başlatın\n\nKaynak: www.kuranikerim.com\n[Diyanet İşleri Bakanlığı]", "Kur'an-ı Kerim"); this.Close(); return; }

            try
            {
         
                wb_Kuran1.Navigate(linkListesi[id]);
                id++;
                progressBar1.Value = id;
                label2.Text = linkListesi[id - 1].Substring(36).Replace(".htm", "").ToUpper() + " Suresi     " + id + "/" + progressBar1.Maximum;
            }
            catch { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!NetworkControl.NetworkConnection())
            {
                MessageBox.Show("Lütfen internet bağlantınızı kontrol edin.", "No connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            btn_Download.Text = "İndiriliyor...";
            btn_Download.Enabled = false;
            DownloadData();
        }
        #endregion

        #region Read & settings

        private void Init()
        { 
        if (!File.Exists(PathManager.data_surelist_path))
            {
                panel1.Visible = true;
            }
            else
            {
                if (File.ReadAllLines(PathManager.data_surelist_path).Length > 110) //114 sure
                {
                    panel1.Visible = false;
                    string[] surelistesi = File.ReadAllLines(PathManager.data_surelist_path);
                    for (int i = 0; i < surelistesi.Length; i++) surelistesi[i] = surelistesi[i].ToUpper();
                    cbx_sureler.DataSource = surelistesi;
                    cbx_sureler.SelectedItem = "ALAK";
                }
                else
                {
                    panel1.Visible = true;
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try {
                rtbMain.Text = File.ReadAllText(PathManager.data_sure_path + cbx_sureler.Text.ToLower() + ".txt");
                rtbMain.SelectAll();
                rtbMain.SelectionAlignment = HorizontalAlignment.Center;
                rtbMain.Select(0,0);
            } catch { }
        }
        private void nud_yaziboyutu_ValueChanged(object sender, EventArgs e)
        {
            rtbMain.Font = new System.Drawing.Font("Century Gothic", (int)nud_yaziboyutu.Value, System.Drawing.FontStyle.Regular);
        }
        #endregion

        #region Button
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
        #endregion

        #region Tema
        private void cbx_tema_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cbx_tema.SelectedIndex;
            if (i == 0)
            {
                BackColor = Color.FromArgb(30,30,30);
                rtbMain.BackColor = Color.FromArgb(30,30,30);
                rtbMain.ForeColor = Color.White;
            }
            else if (i == 1)
            {
                BackColor = Color.White; 
                rtbMain.BackColor = Color.White ;
                rtbMain.ForeColor = Color.Black;
            }
            else if (i == 2)
            {
                BackColor = Color.ForestGreen;
                rtbMain.BackColor = Color.ForestGreen;
                rtbMain.ForeColor = Color.White;
            }
            else if (i == 3)
            {
                BackColor = Color.LightSeaGreen;
                rtbMain.BackColor = Color.LightSeaGreen;
                rtbMain.ForeColor = Color.White;
            }

        }
        #endregion
    }
}
