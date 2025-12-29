using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZamanMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Bugünün tarihini alıyoruz
            DateTime bugun = DateTime.Today;
            int baslangicYili = 2000; // Başlangıç yılı
            int bitisYili = 3000; // Bitiş yılı

            Console.WriteLine("Geçerli tarihler:");

            // Yıllar arasında döngü
            for (int yil = baslangicYili; yil <= bitisYili; yil++)
            {
                // Aylar arasında döngü
                for (int ay = 1; ay <= 12; ay++)
                {
                    // O ayın gün sayısını al
                    int ayinGunu = DateTime.DaysInMonth(yil, ay);

                    // Günler arasında döngü
                    for (int gun = 1; gun <= ayinGunu; gun++)
                    {
                        // Geçerli bir tarih oluştur
                        DateTime tarih = new DateTime(yil, ay, gun);

                        // Tarih koşullarını kontrol et
                        if (AsalMi(gun) && CiftBasamakToplamiMi(ay) && YilGeçerliMi(yil))
                        {
                            // Geçerli tarih bugünden büyükse yazdır
                            if (tarih > bugun)
                            {
                                Console.WriteLine(tarih.ToString("dd/MM/yyyy")); // Tarihi yazdırma
                            }
                        }
                    }
                }
            }
            Console.Read();
        }

        // Asal sayı kontrolü
        static bool AsalMi(int sayi)
        {
            if (sayi <= 1) return false; // 1 ve altındaki sayılar asal değildir
            for (int i = 2; i <= Math.Sqrt(sayi); i++)
            {
                if (sayi % i == 0) return false; // Eğer sayı i'ye tam bölünüyorsa asal değildir
            }
            return true; // Sayı asal
        }

        // Ayın basamaklarının toplamının çift olup olmadığını kontrol et
        static bool CiftBasamakToplamiMi(int ay)
        {
            int toplam = 0; // Basamak toplamı
            while (ay > 0)
            {
                toplam += ay % 10; // Ayın son basamağını ekle
                ay /= 10; // Ayın birler basamağını çıkar
            }
            return toplam % 2 == 0; // Toplam çift mi?
        }

        // Yılın rakamları toplamının, yılın dörtte birinden küçük olup olmadığını kontrol et
        static bool YilGeçerliMi(int yil)
        {
            int toplam = 0; // Rakamlar toplamı
            int geciciYil = yil; // Yılı geçici olarak saklama

            // Yılın rakamlarını toplama
            while (geciciYil > 0)
            {
                toplam += geciciYil % 10; // Yılın son basamağını ekleme
                geciciYil /= 10; // Yılın birler basamağını çıkarma
            }

            return toplam < yil / 4; // Rakamlar toplamı, yılın dörtte birinden küçük mü?
        }
    }
}
