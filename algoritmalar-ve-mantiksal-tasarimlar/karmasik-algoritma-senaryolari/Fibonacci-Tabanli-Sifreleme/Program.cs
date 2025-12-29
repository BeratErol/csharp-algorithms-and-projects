using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sifreleme
{
    class Program
    {
        // Fibonacci dizisini hesaplamak için bir metod
        static int Fibonacci(int n)
        {
            if (n <= 1)
                return n;
            int a = 0, b = 1, temp;
            for (int i = 2; i <= n; i++)
            {
                temp = a + b;
                a = b;
                b = temp;
            }
            return b;
        }

        // Asal sayı kontrolü
        static bool IsPrime(int sayi)
        {
            if (sayi <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(sayi); i++)
            {
                if (sayi % i == 0) return false;
            }
            return true;
        }

        // Şifreli mesajı çözmek için metod
        static string MesajıÇöz(string şifreliMesaj)
        {
            string orijinalMesaj = "";

            // Her bir karakter için işlem yap
            for (int i = 0; i < şifreliMesaj.Length; i++)
            {
                // Pozisyon (1'den başlar)
                int pozisyon = i + 1;

                // Şifreli karakterin ASCII değeri
                int şifreliAscii = (int)şifreliMesaj[i];

                // Orijinal ASCII değerini geri al
                int orijinalAscii;

                // Pozisyon asal ise 100'e göre
                orijinalAscii = şifreliAscii;

                // 1. ve 2. harf 100'e göre modu alındığı için bir kayıp olmaz direkt kendine eşittir
                if (i == 0 | i == 1)
                    orijinalAscii = şifreliAscii;

                // 3.harf 2 ile çarpılıp 100'e göre modu alındığı için 100 ü geçer ve ASCII kodunda 100 kayıp olur onu ekliyoruz
                else if (i == 2)
                    orijinalAscii += 100;
                
                // Fibonacci sayısını al
                int fib = Fibonacci(pozisyon);

                // Orijinal ASCII değerini elde et
                orijinalAscii /= fib;

                // Orijinal karakteri elde et
                orijinalMesaj += (char)orijinalAscii;
            }

            return orijinalMesaj;
        }

        static void Main(string[] args)
        {
            // Kullanıcıdan şifreli mesajı alma
            Console.Write("Lütfen şifrelenmiş kelimeyi girin(Şifreleme işlemi sadece büyük harfler Kullanılarak oluşmuştur, maks 3 harf olabilir ve 3.harf 'R' den sonraki harfler olabilir): ");
            string şifreliMesaj = Console.ReadLine(); // Kullanıcının girdiği şifreli kelime

            // Çözümleme işlemi
            string orijinalMesaj = MesajıÇöz(şifreliMesaj);

            // Sonucu ekrana yazdır
            Console.WriteLine("Orijinal Mesaj: " + orijinalMesaj);

            Console.Read();
        }
    }
}
