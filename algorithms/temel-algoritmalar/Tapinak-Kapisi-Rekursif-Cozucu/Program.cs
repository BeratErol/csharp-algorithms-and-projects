using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapinakKapisi
{
    class Program
    {
        static List<string> geçerliİfadeler = new List<string>(); // Geçerli ifadeleri saklayacak liste oluşturma
        static List<int> sayılar = new List<int>(); // Kullanıcıdan alınacak sayılar
        static List<string> operatörler = new List<string> { "+", "-", "*", "/" }; // Kullanılacak operatörler

        static void Main(string[] args)
        {
            // Kullanıcıdan sayıları alma
            Console.WriteLine("Lütfen sayıları girin (virgülle ayırarak):");
            string[] girdi = Console.ReadLine().Split(',');

            // Girilen sayıları listeye ekleme
            foreach (var sayı in girdi)
            {
                if (int.TryParse(sayı.Trim(), out int sayıDeğeri)) // Girilen değerin tam sayı olup olmadığını kontrol etme
                {
                    sayılar.Add(sayıDeğeri); // Sayıyı listeye ekleme
                }
                else
                {
                    Console.WriteLine($"'{sayı}' geçersiz bir sayı, lütfen yalnızca sayılar girin."); // Hatalı girişi bildirme
                    return; // Hatalı giriş olduğunda programı sonlandırma
                }
            }

            // Başlangıçta boş bir ifade ile başlıyoruz
            string ifade = "";
            GeriIzleme(ifade, 0, 0);

            // Geçerli ifadeleri yazdırma
            Console.WriteLine("Geçerli İfadeler ve Sonuçları:");
            foreach (var item in geçerliİfadeler)
            {
                Console.WriteLine(item); // Her geçerli ifadeyi ekrana yazdırma
            }

            Console.Read();
        }

        // Geri izleme fonksiyonu
        static void GeriIzleme(string ifade, int sayıIndex, int operatörIndex)
        {
            // Eğer ifade boş değilse ve geçerli bir sonuç veriyorsa, ifadeyi listeye ekle
            if (!string.IsNullOrEmpty(ifade))
            {
                double sonuç = Değerlendir(ifade); // İfadeyi değerlendir
                if (sonuç > 0) // Sonuç pozitifse
                {
                    geçerliİfadeler.Add($"{ifade} = {sonuç}"); // İfadeyi ve sonucunu ekle
                }
            }

            // Sayıları ve operatörleri eklemeye başla
            for (int i = sayıIndex; i < sayılar.Count; i++)
            {
                // Sayıyı ekle
                if (string.IsNullOrEmpty(ifade))
                {
                    // İfade boşsa, sadece sayıyı ekle
                    GeriIzleme(sayılar[i].ToString(), i + 1, operatörIndex);
                }
                else
                {
                    for (int j = operatörIndex; j < operatörler.Count; j++)
                    {
                        // Operatörü ekle
                        string yeniİfade = ifade + operatörler[j] + sayılar[i];
                        GeriIzleme(yeniİfade, i + 1, j); // Yeni ifadeyi geri izleme fonksiyonuna gönder
                    }
                }
            }
        }

        // İfadeyi değerlendirip sonucu döndüren fonksiyon
        static double Değerlendir(string ifade)
        {
            // İfade içerisindeki sayıları ve operatörleri değerlendir
            try
            {
                var sonuç = new DataTable().Compute(ifade, null); // DataTable ile ifadeyi değerlendir
                return Convert.ToDouble(sonuç); // Sonucu double olarak döndür
            }
            catch
            {
                return -1; // Hatalı ifade durumunda -1 döner
            }
        }
    }
}
