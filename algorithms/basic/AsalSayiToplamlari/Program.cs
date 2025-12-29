using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsalSayiToplamlari
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Kullanicadan sayi alma
            Console.Write("Bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int toplam = 0;
            
            // 2'den girilen sayiya kadar kontrol
            for (int i = 2; i <= sayi; i++)
            {
                bool asal = true; 
                
                // Sayilarin tek tek asallik kontrolleri
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0) 
                    {
                        asal = false;
                        break; // Herhangi bir sayiya bölünüyorsa dönügüyü bitirme
                    }
                }

                if (asal)  
                {
                    toplam += i; // Asallari tek tek toplama
                }
            }

            // Girilen sayiya kadar olan tüm asallarin toplamini yazdirma
            Console.WriteLine( sayi + " kadar olan asal sayıların toplamı: " + toplam);

            Console.Read();
        }
    }
}
