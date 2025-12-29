using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrisCarpimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanicidan matris boyutu giris
            Console.Write("Matrislerin boyutunu giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Matrisleri tanimlama
            int[,] matris1 = new int[n, n];
            int[,] matris2 = new int[n, n];
            int[,] matrisCarpim = new int[n, n];

            // 1.Matrisi doldurma
            Console.WriteLine("1.Matrisin değerlerini giriniz: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"matris1[{i},{j}] = ");
                    matris1 [i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // 2.Matrisi doldurma
            Console.WriteLine("2.Matrisin değerlerini giriniz: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"matris1[{i},{j}] = ");
                    matris2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            // Iki matrisin carpim islemi
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k=0; k<n; k++)
                    {   
                        // Birinci matrisin satiri ile ikinci matrisin sütununu kullanarak carpimi olusturma
                        matrisCarpim[i,j] += matris1[i, k] * matris2[k, j];
                    }
                }
            }

            // Carpim matrisini yazdirma
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrisCarpim[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
