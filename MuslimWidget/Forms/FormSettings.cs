using System;
using System.Windows.Forms;

namespace MuslimWidget
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
            GetSettings();
        }


        #region Get settings
        private void GetSettings()
        {
            nud_alarm.Value = Properties.Settings.Default.alarm_time;
            nud_kerahat.Value = Properties.Settings.Default.kerahat_time;
            cbx_minimize.Checked = Properties.Settings.Default.close_minimize;
        }
        #endregion

        #region Save Settings
        private void nud_kerahat_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.kerahat_time = (byte)nud_kerahat.Value;
            Properties.Settings.Default.Save();
        }
        private void nud_alarm_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.alarm_time= (byte)nud_alarm.Value;
            Properties.Settings.Default.Save();
        }
        private void cbx_minimize_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.close_minimize = cbx_minimize.Checked;
            Properties.Settings.Default.Save();
        }

        #endregion

        #region question_marks
        private void question_kerahat_Click(object sender, EventArgs e)
        {
            ShowMessage("Kerahat vakti Türkiye için ortalama 45 dakikadır. Kerahat vaktinin 45 dakikanın altına düşürülmemesi (garanti olması için) tavsiye edilir. Kerahat vakti girdiğinde namaz kılınmaz. Kerahat vakti hakkında ayrıntılı bilgi için araştırma yapmanız tavsiye edilir.");
        }
        private void question_alarm_Click(object sender, EventArgs e)
        {
            ShowMessage("Ezan vaktinden önce uyarı verir. Örneğin 5 dk olarak ayarlandığında, ezana 5 dk kala uyarı verir.\nNot: Uyarı istemiyorsanız 0 olarak ayarlayın");
        }
        private void question_minimize_Click(object sender, EventArgs e)
        {
            ShowMessage("X tuşuna basıp uygulamayı kapattığınızda, uygulama tamamen kapanmaz, görev çubuğuna küçültülür  ve hazır bekletilir.\nNot:Bu özellik Ezandan önce uyarı verilmesi için gereklidir.");
        }
        private void ShowMessage(string message)
        {
            MessageBox.Show(message,"Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        #endregion

    }
}
