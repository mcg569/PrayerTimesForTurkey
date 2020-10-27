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
            {
                hadisler = new string[]
                {
                   "Her doğan, İslâm fıtratı üzerine doğar. Sonra, anne-babası onu Hristiyan, Yahudi veya Mecusi yapar. - (Buhârî, cenâiz 92; Ebû Dâvut, sünne 17; Tirmizî, kader 5)",
                    "Müslüman, dilinden ve elinden Müslümanların emin olduğu kimsedir. Muhâcir de Allah’ın yasakladığı şeyleri terk edendir - Buhari, Bedu'l-vahy, 4.",
                    "İnsanlara merhamet etmeyene Allah merhamet etmez - Müslim, Fedâil, 66; Tirmizî, Birr, 16",
                    "Hayra vesile olan, hayrı yapan gibidir.- Tirmizî, İlim, 14."
                };
                File.WriteAllLines(PathManager.data_hadisler_path,hadisler);
            }
            else
            {
                hadisler = File.ReadAllLines(PathManager.data_hadisler_path);
            }
        }
        public string GetRandomHadis()
        {
            return hadisler[new Random().Next(0, hadisler.Length)];
        }

    }
}
