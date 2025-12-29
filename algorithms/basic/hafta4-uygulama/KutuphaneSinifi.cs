using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.HaftaUygulamasi
{
    class KutuphaneSinifi
    {
        // her kitap hakkındaki bilgileri liste halinde saklar
        public List<Dictionary<string, object>> Kitaplar { get; private set; }

        // yapıcı metot
        public KutuphaneSinifi()
        {
            Kitaplar = new List<Dictionary<string, object>>(); // kitaplar listesini boş olarak başlatır
        }

        // kitap eklemek için metot
        public void KitapEkle(string ad, string yazar, int yil)
        {
            // Dictionary nesnesi oluşturur
            var kitap = new Dictionary<string, object>
        {
            { "Ad", ad }, // gelen ad değerini atar
            { "Yazar", yazar }, // gelen yazar değerini atar
            { "Yil", yil } // gelen yil değerini atar
        };

            this.Kitaplar.Add(kitap);  // Dictionary nesnesini Kitaplar listesine ekler
            Console.WriteLine($"'{ad}' adlı kitap kütüphaneye eklendi.");
        }

        public void KitaplariListele()
        {
            if (this.Kitaplar.Count == 0) // Kitaplar listesi boşsa
            {
                Console.WriteLine("Kütüphanede kitap bulunmuyor.");
                Console.WriteLine();
            }
            else // Kitaplar listesi boş değilse
            {
                Console.WriteLine("\nKütüphanedeki kitaplar:");
                foreach (var kitap in this.Kitaplar) // Kitaplar listesindeki her kitabı döner
                {
                    Console.WriteLine($"Ad: {kitap["Ad"]}, Yazar: {kitap["Yazar"]}, Yıl: {kitap["Yil"]}");
                }
                Console.WriteLine();
            }
        }
    }
}
