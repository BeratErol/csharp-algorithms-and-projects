using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.HaftaUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region BankaHesabiSinifi İçin Örnek

            BankaHesabiSinifi hesap = new BankaHesabiSinifi("123456", 1000);
            hesap.ParaYatir(1000);
            hesap.ParaCek(1500);
            Console.WriteLine();

            #endregion

            #region UrunSinifi İçin Örnek

            try
            {
                UrunSinifi urun = new UrunSinifi("Klavye", 1000);
                urun.Indirim = 55;
                Console.WriteLine(urun.IndirimliFiyat());
            }
            catch (ArgumentException e)
            {
                Console.WriteLine("Hata: " + e.Message);
            }
            Console.WriteLine();
            
            #endregion

            #region AracKiralamaSinifi İçin Örnek

            AracKiralamaSinifi arac = new AracKiralamaSinifi("44 AE 777", 5000);
            arac.AraciKirala();
            Console.WriteLine("Aracın Plakası: " + arac.Plaka);
            Console.WriteLine("Aracın Günlük Fiyatı: " + arac.GunlukUcret);
            Console.WriteLine("Aracın Durumu: " + arac.MusaitMi);
            Console.WriteLine();

            #endregion

            #region AdresDefteriSinifi İçin Örnek

            AdresDefteriSinifi adres = new AdresDefteriSinifi("Berat", "EROL", "0555 555 5555");
            adres.KisiBilgisi();
            Console.WriteLine();

            #endregion

            #region KütüphaneSinifi İçin Örnek

            KutuphaneSinifi kutuphane = new KutuphaneSinifi();
            kutuphane.KitaplariListele();
            kutuphane.KitapEkle("Çalıkuşu", "Reşat Nuri Güntekin", 1922);
            kutuphane.KitaplariListele();
            kutuphane.KitapEkle("Elveda Gülsarı", "Cengiz Aytmatov", 1963);
            kutuphane.KitaplariListele();

            #endregion

            Console.Read();
        }
    }
}
