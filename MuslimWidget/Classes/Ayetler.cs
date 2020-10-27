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
            {
                ayetler = new string[]
                {
                    "İki topluluğun karşı karşıya geldikleri gün, sizden geri dönenleri, kazandıkları bazı şeyler dolayısıyla şeytan onların ayağını kaydırmak istemişti. Ama andolsun ki, Allah onları affetti. Şüphesiz Allah, bağışlayandır, yumuşak olandır. (Al-i İmran Suresi, 155. Ayet).",
                    "Kullarından tevbeyi kabul eden, kötülükleri affeden ve işlediklerinizi bilen O'dur. (Şura Suresi, 25. Ayet)",
                    "Ve Allah`tan bağışlanma dile. Gerçekten Allah, bağışlayandır, esirgeyendir. (Nisa Suresi, 106. ayet)",
                    "Rabbinin yoluna hikmetle ve güzel öğütle çağır ve onlarla en güzel bir biçimde mücadele et. Şüphesiz senin Rabbin yolundan sapanı bilendir ve hidayete ereni de bilendir. (NAHL suresi 125. ayet)",
                    "Bir hayrı açıklar veya gizlerseniz, yahut bir kötülüğü affederseniz (bilin ki), Allah da çok affedicidir, her şeye hakkıyla gücü yetendir. (NİSA suresi 149. ayet)"
                };
                File.WriteAllLines(PathManager.data_ayetler_path,ayetler);
            }
            else
            { 
                ayetler = File.ReadAllLines(PathManager.data_ayetler_path);
            }
        }
        public string GetRandomAyet()
        {
            return ayetler[new Random().Next(0, ayetler.Length)];
        }

    }
}
