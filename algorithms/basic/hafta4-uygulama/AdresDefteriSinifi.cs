using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.HaftaUygulamasi
{
    class AdresDefteriSinifi
    {
        // değişkenler tanımlama
        string Ad, Soyad, TelefonNo;

        // yapıcı metot 
        public AdresDefteriSinifi(string ad, string soyad, string telefonNo)
        {
            Ad = ad; // gelen ad değerini atar
            Soyad = soyad; // gelen soyad değerini atar
            TelefonNo = telefonNo; // gelen telefonNo değerini atar
        }

        // kişi bilgisini göstermek için metot
        public void KisiBilgisi()
        {
            Console.WriteLine("Kişini tam adı: " + Ad + " " + Soyad); // Ad ve Soyadı birleştirip çıktı verir
            Console.WriteLine("Kişinin telefon numarası: " + TelefonNo); // Telefon numarısını çıktı verir
        }
    }
}
