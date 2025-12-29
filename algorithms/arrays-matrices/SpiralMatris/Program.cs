using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiralMatris
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanicidan matris boyutu icin giris
            Console.Write("Matrisin boyutunu giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());

            // Alinan giris boyutunda matris olusturma
            int[,] matris = new int[n, n];

            // Matrisin sinirlarini kontrol edebilmek icin degerler
            int sayi = 1;
            int sol = 0; int ust = 0; int sag = n - 1; int asagi = n - 1;

            // n*n boyuttunda spiral matris olusturma
            while (sayi <= n*n) {
                
                // Matrisin soldan saga satirini doldurma
                for (int i = sol; i <= sag; i++)
                    matris[ust, i] = sayi++;
                ust++;

                // Matrisin ustten asagi sutunun doldurma
                for (int i = ust; i <= asagi; i++)
                    matris[i, sag] = sayi++;
                sag--;

                // Matrisin sagdan sola satirini doldurma
                for (int i = sag; i >= sol; i--)
                    matris[asagi, i] = sayi++;
                asagi--;

                // Matrisin asagidan yukari sutununu doldurma
                for (int i = asagi; i >= ust; i--)
                    matris[i, sol] = sayi++;
                sol++;
            }

            // Olusturulan matrisi yazdirma
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++) {
                   int deger = matris[i, j];
                    
                    // Daha düzenli bir matris icin (n=5 ornegi icin) ilk haneli sayilarin basina bosluk ekleme
                    if(deger<n)
                       Console.Write(" " + deger + " ");
                    else
                    Console.Write(deger + " ");
            }
                Console.WriteLine();
            }
            
            Console.ReadLine();
        }
    }
}
