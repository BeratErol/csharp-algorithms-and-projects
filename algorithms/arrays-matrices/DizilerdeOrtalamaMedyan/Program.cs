using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizilerdeOrtalamaMedyan
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan pozitif tam sayılar almak için bir liste tanımlama
            List<int> sayilar = new List<int>();

            Console.WriteLine("Pozitif tam sayıları girin (0 girilirse sayı alımı bitecek, ortalama ve medyan gösterilecek):");

            while (true)
            {
                // Kullanıcıdan sayı girişi alma
                int sayi = int.Parse(Console.ReadLine());

                // Eğer girilen sayı 0 ise döngü biter
                if (sayi == 0) break;

                // Girilen sayı pozitif sayıysa listeye ekliyoruz
                if (sayi > 0)
                    sayilar.Add(sayi);
                else // Negatif sayı girilirse uyarı
                    Console.WriteLine("Lütfen sadece pozitif tam sayılar girin!");
            }

            // Girilen sayıların ortalamasını ve medyanını hesaplıyoruz
            if (sayilar.Count > 0)
            {
                // Ortalamayı hesaplama
                double ortalama = 0, toplam = 0;
                foreach (var sayi in sayilar)
                {
                    toplam += sayi;
                }
                ortalama = toplam / sayilar.Count;
                Console.WriteLine("Ortalama: " + ortalama);

                // Medyanı hesaplama
                double medyan = 0;
                
                // Sayıları sıralıyoruz
                sayilar.Sort();

                int n = sayilar.Count; // Sayıların uzunluğunu n'e eşitleme
                if (n % 2 == 1)
                {
                    // Eleman sayısı tek ise ortadaki eleman medyandır
                    medyan = sayilar[n / 2];
                }
                else
                {
                    // Eleman sayısı çift ise ortadaki iki elemanın ortalamasını alıyoruz
                    medyan = (sayilar[(n - 1) / 2] + sayilar[n / 2]) / 2.0;
                }
                Console.WriteLine("Medyan: " + medyan);
            }

            else
            {
                Console.WriteLine("Herhangi bir pozitif sayı girilmedi.");
            }

            Console.Read();
        }
    }
}
