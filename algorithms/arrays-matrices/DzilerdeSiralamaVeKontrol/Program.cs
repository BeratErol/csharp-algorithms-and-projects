using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DzilerdeSiralamaVeKontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan dizinin boyutunu alma
            Console.Write("Dizinin boyutunu giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Dizi olusturma
            int[] dizi = new int[n];

            // Dizinin elemanlarını sırasıyla kullanıcıdan alma
            for (int i = 0; i < n; i++)
            {
                Console.Write("Dizinin " + (i + 1) + ". elamanını giriniz: ");
                int deger = Convert.ToInt32(Console.ReadLine());
                dizi[i] = deger;
            }

            // Diziyi küçükten büyüğe sıralama
            Array.Sort(dizi);

            // Diziyi yazdırma
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(dizi[i]);
            }

            // Kullanıcıdan aranacak sayıyı alma
            Console.WriteLine("Aramak istediğiniz sayıyı girin:");
            int arama = int.Parse(Console.ReadLine());

            // İkili arama algoritmasını ile sayıyı kontrol etme
            bool sonuc = IkiliArama(dizi, arama);

            // Aramanın sonucunu ekrana yazdırma
            if (sonuc)
            {
                Console.WriteLine($"{arama} dizide bulundu.");
            }
            else
            {
                Console.WriteLine($"{arama} dizide bulunamadı.");
            }

            Console.Read();
        }

        static bool IkiliArama(int[] dizi, int arama)
        {
            // Arama yapacağımız sınırları tanımlama
            int sol = 0; // Dizinin ilk elemanını temsil eden indeks
            int sag = dizi.Length - 1; // Dizinin son elemanını temsil eden indeks

            // İkili arama döngüsü  
            while (sol <= sag)
            {
                int orta = sol + (sag - sol) / 2; // Orta elemanın indeksi

                // Eğer ortadaki eleman aradığımız sayıya eşitse, true döndürerek bulduğumuzu belirtiyoruz 
                if (dizi[orta] == arama)
                    return true;

                // Eğer aradığımız sayı ortadaki elemandan küçükse, sağ sınırı orta noktanın bir öncesine çekiyoruz
                if (dizi[orta] > arama)
                    sag = orta - 1;
                else // Aradığımız sayı ortadaki elemandan büyükse, sol sınırı orta noktanın bir sonrasına çekiyoruz
                    sol = orta + 1;
            }

            // Aradığımız sayı dizide bulunamadıysa false döndürerek bulamadığımızı belirtiyoruz
            return false;
        }
    }
}
