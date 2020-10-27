using System;
using System.IO;

namespace MuslimWidget
{
   public  class Ayetler
    {

        private string[] ayetler = new string[] { };

        public Ayetler()
        {           
            if (!File.Exists(PathManager.data_ayetler_path))
                ayetler = new string[] { "Hata: Veriler yüklenemedi." };
            else
                ayetler = File.ReadAllLines(PathManager.data_ayetler_path);
        }
        public string GetRandomAyet()
        {
            return ayetler[new Random().Next(0, ayetler.Length)];
        }

    }
}
