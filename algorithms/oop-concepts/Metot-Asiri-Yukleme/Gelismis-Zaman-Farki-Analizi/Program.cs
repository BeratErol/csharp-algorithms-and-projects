using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Örnek tarihler
            DateTime tarih1 = new DateTime(2023, 5, 15);
            DateTime tarih2 = new DateTime(2025, 12, 25);

            // İlk metodu çağırıyoruz: Gün cinsinden fark
            Console.WriteLine("Gün farkı: " + ZamanFarki(tarih1, tarih2));

            // İkinci metodu çağırıyoruz: Saat cinsinden fark
            Console.WriteLine("Saat farkı: " + ZamanFarki(tarih1, tarih2, "saat"));

            // Üçüncü metodu çağırıyoruz: Yıl, ay ve gün cinsinden fark
            TarihFarki fark = ZamanFarki(tarih1, tarih2, detayli: true);
            Console.WriteLine($"Yıl: {fark.Yil}, Ay: {fark.Ay}, Gün: {fark.Gun}");

            // Farklı tarihlerle test
            DateTime tarih3 = new DateTime(2020, 1, 1);
            DateTime tarih4 = new DateTime(2023, 11, 24);

            // Gün farkı
            Console.WriteLine("Gün farkı: " + ZamanFarki(tarih3, tarih4));

            // Saat farkı
            Console.WriteLine("Saat farkı: " + ZamanFarki(tarih3, tarih4, "saat"));

            // Yıl, ay ve gün farkı
            TarihFarki fark2 = ZamanFarki(tarih3, tarih4, detayli: true);
            Console.WriteLine($"Yıl: {fark2.Yil}, Ay: {fark2.Ay}, Gün: {fark2.Gun}");

            Console.Read();
        }

        // Gün cinsinden farkı hesaplayan metod
        static int ZamanFarki(DateTime baslangic, DateTime bitis)
        {
            return (bitis - baslangic).Days;
        }

        // Saat cinsinden farkı hesaplayan metod
        static double ZamanFarki(DateTime baslangic, DateTime bitis, string format)
        {
            if (format == "saat")
            {
                return (bitis - baslangic).TotalHours;
            }
            return 0;
        }

        // Yıl, ay ve gün farkını hesaplayan metod
        static TarihFarki ZamanFarki(DateTime baslangic, DateTime bitis, bool detayli)
        {
            if (detayli)
            {
                int yil = bitis.Year - baslangic.Year;
                int ay = bitis.Month - baslangic.Month;
                int gun = bitis.Day - baslangic.Day;

                if (ay < 0)
                {
                    yil--;
                    ay += 12;
                }

                if (gun < 0)
                {
                    ay--;
                    gun += DateTime.DaysInMonth(baslangic.Year, baslangic.Month);
                }

                // Yapı oluşturulup değerleri atanıyor
                return new TarihFarki { Yil = yil, Ay = ay, Gun = gun };
            }

            return new TarihFarki { Yil = 0, Ay = 0, Gun = 0 };
        }

        // Tarih farkını tutmak için yapı
        struct TarihFarki
        {
            public int Yil;
            public int Ay;
            public int Gun;
        }
    }
}
