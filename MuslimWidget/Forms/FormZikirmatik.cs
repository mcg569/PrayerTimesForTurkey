
using System;
using System.IO;
using System.Windows.Forms;

namespace MuslimWidget
{
    public partial class FormZikirmatik : Form
    {
        private int value;
        public FormZikirmatik()
        {
            InitializeComponent();
        }
        private void Zikirmatik_Load(object sender, System.EventArgs e)
        {
            if (File.Exists(PathManager.data_zikir_path))
            {
                value = Convert.ToInt32(File.ReadAllText(PathManager.data_zikir_path));
                lbl_value.Text = value.ToString("00000");
            }
            else 
            {
                File.WriteAllText(PathManager.data_zikir_path,"0");
            }
        }

        private void Plus()
        {
            value++;
            lbl_value.Text = value.ToString("00000");
            File.WriteAllText(PathManager.data_zikir_path, value.ToString());
        }
        private void Reset()
        {
            if (MessageBox.Show("Zikirmatiği sıfırlamak istiyor musunuz?\n\n[" + value + "]", "Dikkat", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                File.WriteAllText(PathManager.data_zikir_path, "0");
                value = 0;
                lbl_value.Text = value.ToString("00000");
            }
        }

        private void btn_plus_Click(object sender, System.EventArgs e)
        {
            Plus();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
