using System;
using System.IO;
using System.Windows.Forms;

namespace MuslimWidget
{
    public partial class FormKazaTakip : Form
    {
        public FormKazaTakip()
        {
            InitializeComponent();
        }

        private void KazaTakip_Load(object sender, EventArgs e)
        {
            GetData();
        }

        #region Get data
        private string[] data = new string[] { };
        private void GetData()
        {
            if (File.Exists(PathManager.data_kazalar_path))
            {
                data = File.ReadAllLines(PathManager.data_kazalar_path);
            }
            else
            {
                data = new string[]
                {
                "0;-",
                "0;-",
                "0;-",
                "0;-",
                "0;-",
                "0;-",
                "0;-"
                };
                File.WriteAllLines(PathManager.data_kazalar_path, data);
            }

            if (data == null) return;

            nud_sabah.Value = Convert.ToInt32(data[0].Split(';')[0]);
            lbl_time_sabah.Text = data[0].Split(';')[1];

            nud_ogle.Value = Convert.ToInt32(data[1].Split(';')[0]);
            lbl_time_ogle.Text = data[1].Split(';')[1];

            nud_ikindi.Value = Convert.ToInt32(data[2].Split(';')[0]);
            lbl_time_ikindi.Text = data[2].Split(';')[1];

            nud_aksam.Value = Convert.ToInt32(data[3].Split(';')[0]);
            lbl_time_aksam.Text = data[3].Split(';')[1];

            nud_yatsi.Value = Convert.ToInt32(data[4].Split(';')[0]);
            lbl_time_yatsi.Text = data[4].Split(';')[1];

            nud_vitr.Value = Convert.ToInt32(data[5].Split(';')[0]);
            lbl_time_vitr.Text = data[5].Split(';')[1];

            nud_oruc.Value = Convert.ToInt32(data[6].Split(';')[0]);
            lbl_time_oruc.Text = data[6].Split(';')[1];

        }
#endregion

        #region Set data
        private void SetData(int id)
        {            

            int value = 0;
            if (id == 0) value = (int)nud_sabah.Value;
            else if (id == 1) value = (int)nud_ogle.Value;
            else if (id == 2) value = (int)nud_ikindi.Value;
            else if (id == 3) value = (int)nud_aksam.Value;
            else if (id == 4) value = (int)nud_yatsi.Value;
            else if (id == 5) value = (int)nud_vitr.Value;
            else value = (int)nud_oruc.Value;

            data[id] = value.ToString() + ";" + DateTime.Now.ToString();
            File.WriteAllLines(PathManager.data_kazalar_path, data);

            GetData();
        }
        #endregion

        #region Value Change
        private void nud_sabah_ValueChanged(object sender, EventArgs e) => SetData(0);
        private void nud_ogle_ValueChanged(object sender, EventArgs e) => SetData(1);
        private void nud_ikindi_ValueChanged(object sender, EventArgs e) => SetData(2);
        private void nud_aksam_ValueChanged(object sender, EventArgs e) => SetData(3);
        private void nud_yatsi_ValueChanged(object sender, EventArgs e) => SetData(4);
        private void nud_vitr_ValueChanged(object sender, EventArgs e) => SetData(5);
        private void nud_oruc_ValueChanged(object sender, EventArgs e) => SetData(6);
        #endregion

        #region  Kaza Hesapla
        private int hesaplanan;
        private void btn_hesapla_Click(object sender, EventArgs e)
        {
            if (nud_yilsayisi.Value == 0) 
            {
                MessageBox.Show("Lütfen namaz kılmadığınız yıl sayısını giriniz.\nÖrnek: 3","Hata");
                return;
            }

            int gün = (int)nud_yilsayisi.Value >= 4 ? ((int)nud_yilsayisi.Value * 365) + (((int)nud_yilsayisi.Value/4) *  1 ) : ((int)nud_yilsayisi.Value * 365) +1;
            lbl_hesapsonucu.Text = string.Format("Hesaplanan kaza namazlarınız ({0} gün) : \nSabah: {1} | Öğle: {2} | İkindi: {3}\nAkşam: {4} | Yatsı: {5} | Vitr: {6}",
                gün,gün,gün,gün,gün,gün,gün);
            btn_aktar.Visible = true;
            hesaplanan = gün;
        }

        private void btn_aktar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Geçmiş veriler silinecek ve yeni hesaplanan bilgiler kaydedilecek. Kazaları aktarmayı onaylıyor musunuz?","DİKKAT",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK)
            {                
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = hesaplanan.ToString() + ";" + DateTime.Now.ToString();
                }
                File.WriteAllLines(PathManager.data_kazalar_path, data);
                GetData();
            }
        }
        #endregion
    }
}
