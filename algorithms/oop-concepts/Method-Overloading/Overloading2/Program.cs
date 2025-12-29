using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sınıftan bir nesne oluşturuyoruz
            Program hesaplayici = new Program();

            // Karenin alanını hesapla: Kenar uzunluğu 10
            Console.WriteLine("Karenin alanı: " + hesaplayici.AlanHesapla(10));

            // Dikdörtgenin alanını hesapla: Kısa kenar 7, uzun kenar 9
            Console.WriteLine("Dikdörtgenin alanı: " + hesaplayici.AlanHesapla(7, 9));

            // Dairenin alanını hesapla: Yarıçap 5
            Console.WriteLine("Dairenin alanı: " + hesaplayici.AlanHesapla(5.0));
        }

        // Karenin alanını hesaplayan metod
        int AlanHesapla(int kenar)
        {
            // Kenar uzunluğunu kendisiyle çarpıyoruz
            return kenar * kenar;
        }

        // Dikdörtgenin alanını hesaplayan metod
        int AlanHesapla(int kisaKenar, int uzunKenar)
        {
            // Kısa kenar ile uzun kenarı çarpıyoruz
            return kisaKenar * uzunKenar;
        }

        // Dairenin alanını hesaplayan metod
        double AlanHesapla(double yariCap)
        {
            // π * r^2 formülünü kullanarak alanı hesaplıyoruz
            return Math.PI * yariCap * yariCap;
        }
    }
}
