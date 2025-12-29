using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Polinom
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("İlk polinomu giriniz (örneğin, 2x^2 + 3x - 5) veya çıkmak için 'exit' yazın:");
                string polinom1 = Console.ReadLine();
                if (polinom1.ToLower() == "exit") break;

                Console.WriteLine("İkinci polinomu giriniz (örneğin, x^2 - 4):");
                string polinom2 = Console.ReadLine();

                // Polinomları analiz ettirme ve katsayılarını alma
                double[] katsayilar1 = PolinomKatsayilari(polinom1);
                double[] katsayilar2 = PolinomKatsayilari(polinom2);

                // Toplama işlemini yapma
                double[] toplam = new double[katsayilar1.Length];
                for (int i = 0; i < toplam.Length; i++)
                    toplam[i] = katsayilar1[i] + katsayilar2[i];

                // Çıkarma işlemini yapma
                double[] fark = new double[katsayilar1.Length];
                for (int i = 0; i < fark.Length; i++)
                    fark[i] = katsayilar1[i] - katsayilar2[i];

                Console.WriteLine($"Toplam: {PolinomYaz(toplam)}"); // Toplamı yazdırma
                Console.WriteLine($"Fark: {PolinomYaz(fark)}"); // Farkı yazdırma
            }
        }

        static double[] PolinomKatsayilari(string polinom)
        {
            // 10 terimlik bir dizi oluştur; bu, polinomun en yüksek derecesi için yeterlidir
            double[] katsayilar = new double[10];

            // Polinomdaki boşlukları silip '+' ve '-' ile terimlere ayırma
            string[] terimler = polinom.Replace(" ", "").Split('+', '-');

            // Her terimi kontrol etme
            for (int i = 0; i < terimler.Length; i++)
            {
                // Boş terimleri atlama
                if (terimler[i] == "") continue;

                // Derece ve katsayı değişkenlerini tanımlama
                int derece = 0;
                double katsayi = 1;

                // Terimde 'x' olup olmadığını kontrol etme
                if (terimler[i].Contains("x"))
                {
                    // 'x' karakterinin indeksini alma
                    int xIndex = terimler[i].IndexOf("x");

                    // Eğer terimde 'x' öncesinde bir katsayı varsa onu alma
                    if (xIndex > 0) katsayi = double.Parse(terimler[i].Substring(0, xIndex));

                    // Eğer terimde '^' varsa, derecesini alma
                    if (terimler[i].Contains("^"))
                        derece = int.Parse(terimler[i].Substring(terimler[i].IndexOf("^") + 1));
                    else
                        derece = 1; // Eğer '^' yoksa, dereceyi 1 kabul ederiz
                }
                else
                {
                    // Eğer terim 'x' içermiyorsa sabit terim
                    katsayi = double.Parse(terimler[i]);
                }

                // Eğer terim '-' ile başlıyorsa katsayıyı negatif yapma
                if (i > 0 && polinom[polinom.IndexOf(terimler[i]) - 1] == '-') katsayi *= -1;

                // Katsayıyı ilgili dereceye ekleme
                katsayilar[derece] += katsayi;
            }

            // Katsayı dizisini döndürme
            return katsayilar;
        }

        static string PolinomYaz(double[] katsayilar)
        {
            string sonuc = "";

            // Katsayıları en yüksek dereceden en düşüğe doğru kontrol etme
            for (int i = katsayilar.Length - 1; i >= 0; i--)
            {
                // Eğer katsayı 0 değilse işleme devam etme
                if (katsayilar[i] != 0)
                {
                    // Önceki terim varsa ve katsayı pozitifse '+' ekleme
                    if (sonuc != "" && katsayilar[i] > 0) sonuc += "+";

                    // Katsayıyı ve ilgili x terimini ekleme
                    sonuc += katsayilar[i] + (i > 0 ? (i == 1 ? "x" : $"x^{i}") : "");
                }
            }

            // Eğer sonuç boşsa '0' döndür, aksi takdirde sonucu döndür
            return sonuc == "" ? "0" : sonuc;
        }
    }
}
