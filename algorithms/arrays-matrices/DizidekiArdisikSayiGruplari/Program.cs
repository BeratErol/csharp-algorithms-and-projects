using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DizidekiArdisikSayiGruplari
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan dizi boyutunu alma
            Console.Write("Girilecek sayı adedi: ");
            int boyut = int.Parse(Console.ReadLine());

            // Girilen sayılar için dizi tanımlama
            int[] sayilar = new int[boyut];

            Console.WriteLine("Sayıları giriniz (0 girerek sonlandırabilirsiniz): ");

            // Girilen sayilari diziye aktarma
            for (int i = 0; i < boyut; i++)
            {
                int sayi = int.Parse(Console.ReadLine());

                // 0 girilirse işlem sonlanır
                if (sayi == 0)
                {
                    Array.Resize(ref sayilar, i); // Hazır metot kullanarak diziyi girilen gerçek boyutuna göre yeniden boyutlandırıyoruz
                    break;
                }

                // Girilen sayıyı diziye ekliyoruz
                sayilar[i] = sayi;
            }

            // Eğer hiç sayı girilmediyse uyarı verip çıkıyoruz
            if (sayilar.Length == 0)
            {
                Console.WriteLine("Herhangi bir sayı girilmedi.");
            }

            // Ardışık sayılar için diziyi sıralama
            Array.Sort(sayilar);

            // Gerekli değişkenleri tanımlama
            int baslangic = sayilar[0];
            int onceki = sayilar[0];
            bool ardışıkGrup = false;

            Console.WriteLine("sayılar içindeki ardışık gruplar: ");

            // Dizideki tüm sayıları kontrol ediyoruz
            for (int i = 1; i < sayilar.Length; i++)
            {
                // Eğer bir sonraki sayı, önceki sayının bir fazlasıysa ardışık demektir
                if (sayilar[i] == onceki + 1)
                {
                    onceki = sayilar[i]; // Ardışık durumu kontrol etmek için öncekiyi güncelliyoruz
                    ardışıkGrup = true;
                }
                else
                {
                    // Eğer ardışıklık bozulduysa, ardışık grup en az iki elemanlıysa yazdırıyoruz
                    if (baslangic != onceki && ardışıkGrup)
                        Console.WriteLine($"{baslangic}-{onceki}");

                    // Yeni ardışık grubun başlangıcı bu sayı oluyor
                    baslangic = sayilar[i];
                    onceki = sayilar[i];
                    ardışıkGrup = false;
                }
            }

            // Döngüden çıktığımızda son ardışık grubu da kontrol ediyoruz
            if (baslangic != onceki && ardışıkGrup)
                Console.WriteLine($"{baslangic}-{onceki}"); // Çok elemanlı son grup

            Console.Read();
        }
    }
}
