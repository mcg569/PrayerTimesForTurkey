using System;
using System.IO;

namespace MuslimWidget
{
   public class Hadisler
    {

        private string[] hadisler = new string[] { };

        public Hadisler()
        {
            if (!File.Exists(PathManager.data_hadisler_path))
                hadisler = new string[] { "Hata: veriler yüklenemedi." };
            else
                hadisler = File.ReadAllLines(PathManager.data_hadisler_path);
        }
        public string GetRandomHadis()
        {
            return hadisler[new Random().Next(0, hadisler.Length)];
        }

    }
}
