using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IslemOnceligi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir matematiksel ifade girin (örneğin: 3 + 4 * 2 / (1 - 5) ^ 2 ^ 3) DİKKAT GİRİLEN İFADELERİN HER BİRİNDE BOŞLUK BIRAKILMALIDIR!:");
            string ifade = Console.ReadLine();

            try
            {
                // İfadenin sonucu hesaplanıyor ve ekrana yazdırılıyor
                double sonuc = HesaplaVeGoster(ifade);
                Console.WriteLine($"Sonuç: {sonuc}");
            }
            catch (Exception ex)
            {
                // Hata durumunda hata mesajı yazdırılıyor
                Console.WriteLine($"Hata: {ex.Message}");
            }
            Console.Read();
        }

        // İfadeyi hesaplayıp sonucu döndürür
        static double HesaplaVeGoster(string ifade)
        {
            var postfix = InfixToPostfix(ifade); // İfade postfix'e dönüştürülüyor
            return PostfixiDeğerlendir(postfix); // Postfix değerlendirilip sonuç döndürülüyor
        }

        // İnfiks ifadeyi postfix ifadeye dönüştürür
        static Queue<string> InfixToPostfix(string ifade)
        {
            var çıktı = new Queue<string>(); // Çıktı kuyruğu
            var operatörYığını = new Stack<string>(); // Operatör yığını
            string[] tokenler = ifade.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var token in tokenler)
            {
                if (double.TryParse(token, out _)) // Eğer token bir sayı ise
                {
                    çıktı.Enqueue(token);
                }
                else if (token == "(") // Eğer token "(" ise
                {
                    operatörYığını.Push(token);
                }
                else if (token == ")") // Eğer token ")" ise
                {
                    while (operatörYığını.Count > 0 && operatörYığını.Peek() != "(")
                    {
                        çıktı.Enqueue(operatörYığını.Pop());
                    }
                    if (operatörYığını.Count == 0) throw new InvalidOperationException("Eşleşmeyen parantez hatası.");
                    operatörYığını.Pop(); // "(" işaretini çıkar
                }
                else // Operatör token'i ise
                {
                    while (operatörYığını.Count > 0 && Öncelik(operatörYığını.Peek()) >= Öncelik(token))
                    {
                        çıktı.Enqueue(operatörYığını.Pop());
                    }
                    operatörYığını.Push(token);
                }
            }

            while (operatörYığını.Count > 0)
            {
                çıktı.Enqueue(operatörYığını.Pop());
            }

            return çıktı; // Postfix olarak dönüştürülen ifadeyi döndür
        }

        // Postfix ifadeyi değerlendirir ve sonucu döndürür
        static double PostfixiDeğerlendir(Queue<string> postfix)
        {
            var yığın = new Stack<double>();

            while (postfix.Count > 0)
            {
                var token = postfix.Dequeue();
                if (double.TryParse(token, out double sayı)) // Eğer token bir sayı ise
                {
                    yığın.Push(sayı);
                }
                else // Operatör token'i ise
                {
                    if (yığın.Count < 2)
                    {
                        throw new InvalidOperationException("Yeterli operand yok. Lütfen ifadenizi kontrol edin.");
                    }
                    double ikinciSayı = yığın.Pop();
                    double birinciSayı = yığın.Pop();
                    double sonuç = 0;

                    // İşlem operatörüne göre hesaplama yapılır
                    switch (token)
                    {
                        case "+":
                            sonuç = birinciSayı + ikinciSayı;
                            break;
                        case "-":
                            sonuç = birinciSayı - ikinciSayı;
                            break;
                        case "*":
                            sonuç = birinciSayı * ikinciSayı;
                            break;
                        case "/":
                            if (ikinciSayı == 0) throw new DivideByZeroException("Bölme hatası: Sıfıra bölme.");
                            sonuç = birinciSayı / ikinciSayı;
                            break;
                        case "^":
                            sonuç = Math.Pow(birinciSayı, ikinciSayı);
                            break;
                    }

                    // Hesaplanan sonuç yığına eklenir
                    yığın.Push(sonuç);
                    Console.WriteLine($"İşlem: {birinciSayı} {token} {ikinciSayı} = {sonuç}");
                }
            }

            if (yığın.Count != 1) throw new InvalidOperationException("Geçersiz ifade: Sonuç yok.");

            return yığın.Pop(); // Sonuç döndürülür
        }

        // Operatör önceliğini belirler
        static int Öncelik(string operatör)
        {
            switch (operatör)
            {
                case "^": return 3;
                case "*":
                case "/": return 2;
                case "+":
                case "-": return 1;
                default: return 0;
            }
        }
    }
}

