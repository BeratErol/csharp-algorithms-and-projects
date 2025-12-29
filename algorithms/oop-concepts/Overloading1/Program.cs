using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading1
{
    class Program
    {
        static void Main(string[] args)
        {
            // İlk metodu çağırıyoruz: 67 ve 10 sayılarının toplamını hesaplama
            Console.WriteLine("İki tam sayının toplamı: " + Topla(67, 10));

            // İkinci metodu çağırıyoruz: 67, 10 ve 13 sayılarının toplamını hesaplama
            Console.WriteLine("Üç tam sayının toplamı: " + Topla(67, 10, 23));

            // Üçüncü metodu çağırıyoruz: Dizi içindeki sayıların toplamını hesaplama
            Console.WriteLine("Dizinin toplamı: " + Topla(new int[] { 67, 10, 23, 50 }));

            Console.Read();
        }

        // İki tam sayı toplayan metod
        static int Topla(int sayi1, int sayi2)
        {
            // İki sayıyı toplar ve sonucu döndürür
            return sayi1 + sayi2;
        }

        // Üç tam sayı toplayan metod
        static int Topla(int sayi1, int sayi2, int sayi3)
        {
            // Üç sayıyı toplar ve sonucu döndürür
            return sayi1 + sayi2 + sayi3;
        }

        // Bir dizi tam sayıyı toplayan metod
        static int Topla(int[] sayilar)
        {
            // Toplamı sıfırdan başlatıyoruz
            int toplam = 0;

            // Dizi içindeki her sayı için
            foreach (int sayi in sayilar)
            {
                // Sayıyı toplama ekleme
                toplam += sayi;
            }

            // Dizideki sayıların toplamını döndürme
            return toplam;
        }
        
    }
}
