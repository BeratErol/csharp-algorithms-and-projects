using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.HaftaUygulamasi
{
    class AracKiralamaSinifi
    {
        // değişkenler tanımlama
        public string Plaka;
        public decimal GunlukUcret;
        public bool MusaitMi;

        // yapıcı metot
        public AracKiralamaSinifi(string plaka, decimal gunlukUcret)
        {
            Plaka = plaka; // gelen plaka değerini atar
            GunlukUcret = gunlukUcret; // gelen gunlukUcret değerini atar
            MusaitMi = true; // MusaitMi'nin başlangıç değerini true yapar
        }

        // araç kiralama için metot
        public void AraciKirala()
        {
            MusaitMi = false; // MusaitMi'nin değerini false'a çevirir
        }
    
        // araç teslim etme için metot
        public void AraciTeslimEt()
        {
            MusaitMi = true; // MusaitMi'nin değerini true'ya çevirir
        }
    }
}
