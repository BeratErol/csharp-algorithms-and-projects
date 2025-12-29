using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UzayMadeni
{
    class Program
    {
        static void Main()
        {
            // Matris boyutunu kullanıcıdan alma
            Console.Write("Matris boyutunu girin (N x N): ");
            int n = int.Parse(Console.ReadLine()); // Kullanıcının girdiği boyutu n değerine atama
            int[,] enerjiMaliyeti = new int[n, n]; // Enerji maliyet matrisini tanımlama

            // Kullanıcıdan enerji maliyet matrisini alma
            Console.WriteLine("Enerji maliyet matrisini giriniz:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    enerjiMaliyeti[i, j] = int.Parse(Console.ReadLine()); // Enerji maliyetlerini okuma
                }
            }

            // Kullanıcının girdiği matrisi yazdırma
            Console.WriteLine("\nGirdiğiniz enerji maliyet matrisi:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(enerjiMaliyeti[i, j] + "\t"); // Matrisin elemanlarını yazdırma
                }
                Console.WriteLine(); // Her satırdan sonra yeni bir satıra geçme
            }

            // En az enerji maliyetini hesaplama
            int toplamEnerji = EnerjiHesapla(enerjiMaliyeti, n);

            // Sonucu yazdırma
            Console.WriteLine("\nEn az enerji harcayarak ulaşılması gereken toplam enerji: " + toplamEnerji);

            Console.Read();
        }

        static int EnerjiHesapla(int[,] matris, int n)
        {
            // Enerji maliyetlerini tutacak bir dizi oluşturma
            int[,] maaliyet = new int[n, n];

            // (0, 0) konumu için enerji maliyetini ilk olarak ayarlama
            maaliyet[0, 0] = matris[0, 0];

            // İlk satırın enerji maliyetlerini hesaplama
            for (int j = 1; j < n; j++)
            {
                maaliyet[0, j] = maaliyet[0, j - 1] + matris[0, j];
            }

            // İlk sütunun enerji maliyetlerini hesaplama
            for (int i = 1; i < n; i++)
            {
                maaliyet[i, 0] = maaliyet[i - 1, 0] + matris[i, 0];
            }

            // Diğer hücreler için en az enerji maliyetlerini hesaplama
            for (int i = 1; i < n; i++)
            {
                for (int j = 1; j < n; j++)
                {
                    maaliyet[i, j] = matris[i, j] + Math.Min(maaliyet[i - 1, j], Math.Min(maaliyet[i, j - 1], maaliyet[i - 1, j - 1]));
                }
            }

            // Hedef konumun enerji maliyetini döndürme
            return maaliyet[n - 1, n - 1];
        }
    }
}
