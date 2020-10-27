using System.Windows.Forms;

namespace MuslimWidget
{
    public static class PathManager
    {
        public static string folder = Application.StartupPath + "/Data/";
        public static string data_ezan_path = folder + "data_ezan.txt";
        public static string data_sehir_path = folder + "data_sehir.txt";
        public static string data_ayetler_path = folder + "data_ayet.txt";
        public static string data_hadisler_path = folder + "data_hadis.txt";
        public static string data_sure_path = folder + "data_sure_";
        public static string data_surelist_path = folder + "data_surelistesi.txt";
        public static string data_kazalar_path = folder + "data_kazalar.txt";
        public static string data_zikir_path = folder + "data_zikir.txt";
    }
}
