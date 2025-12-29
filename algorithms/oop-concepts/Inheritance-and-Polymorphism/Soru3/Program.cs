using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace Soru3
{
    // Temel Hesap sınıfı
    class Hesap
    {
        public string HesapNumarasi { get; set; } // Hesap numarası
        public decimal Bakiye { get; set; } // Hesap bakiyesi
        public string HesapSahibi { get; set; } // Hesap sahibi

        // Para yatırma işlemi (sanal metot)
        public virtual void ParaYatir(decimal miktar)
        {
            Bakiye += miktar;
            Console.WriteLine($"{miktar} TL yatırıldı. Yeni bakiye: {Bakiye} TL");
        }

        // Para çekme işlemi (sanal metot)
        public virtual void ParaCek(decimal miktar)
        {
            if (miktar <= Bakiye)
            {
                Bakiye -= miktar;
                Console.WriteLine($"{miktar} TL çekildi. Yeni bakiye: {Bakiye} TL");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye!");
            }
        }

        // Hesap bilgilerini yazdırma
        public virtual void BilgiYazdir()
        {
            Console.WriteLine($"Hesap Numarası: {HesapNumarasi}");
            Console.WriteLine($"Hesap Sahibi: {HesapSahibi}");
            Console.WriteLine($"Bakiye: {Bakiye} TL");
        }
    }

    // VadesizHesap sınıfı
    class VadesizHesap : Hesap
    {
        public decimal EkHesapLimiti { get; set; } // Ek hesap limiti

        // Para çekme işlemini özelleştir
        public override void ParaCek(decimal miktar)
        {
            decimal toplamBakiye = Bakiye + EkHesapLimiti;

            if (miktar <= toplamBakiye)
            {
                if (miktar <= Bakiye)
                {
                    Bakiye -= miktar;
                }
                else
                {
                    decimal ekHesapKullanimi = miktar - Bakiye;
                    EkHesapLimiti -= ekHesapKullanimi;
                    Bakiye = 0;
                }
                Console.WriteLine($"{miktar} TL çekildi. Yeni bakiye: {Bakiye} TL, Kalan Ek Hesap Limiti: {EkHesapLimiti} TL");
            }
            else
            {
                Console.WriteLine("Yetersiz bakiye ve ek hesap limiti!");
            }
        }

        // Hesap bilgilerini yazdırma
        public override void BilgiYazdir()
        {
            base.BilgiYazdir();
            Console.WriteLine($"Ek Hesap Limiti: {EkHesapLimiti} TL");
        }
    }

    // VadeliHesap sınıfı
    class VadeliHesap : Hesap
    {
        public int VadeSuresi { get; set; } // Vade süresi (gün)
        public decimal FaizOrani { get; set; } // Faiz oranı
        public bool VadeDolduMu { get; set; } // Vade durumu

        // Para çekme işlemini özelleştir
        public override void ParaCek(decimal miktar)
        {
            if (VadeDolduMu)
            {
                base.ParaCek(miktar);
            }
            else
            {
                Console.WriteLine("Vade dolmadan para çekemezsiniz!");
            }
        }

        // Hesap bilgilerini yazdırma
        public override void BilgiYazdir()
        {
            base.BilgiYazdir();
            Console.WriteLine($"Vade Süresi: {VadeSuresi} gün");
            Console.WriteLine($"Faiz Oranı: {FaizOrani}%");
            Console.WriteLine($"Vade Durumu: {(VadeDolduMu ? "Doldu" : "Dolmadı")}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hesap türünü seçiniz (1: Vadesiz Hesap, 2: Vadeli Hesap): ");
            int secim = int.Parse(Console.ReadLine()); // Kullanıcı girişi
            Hesap hesap; // Polimorfizm için temel sınıf referansı oluşturuyoruz

            if (secim == 1) // VadesizHesap seçildiyse
            {
                hesap = new VadesizHesap();
                Console.Write("Hesap Numarası: ");
                hesap.HesapNumarasi = Console.ReadLine();
                Console.Write("Hesap Sahibi: ");
                hesap.HesapSahibi = Console.ReadLine();
                Console.Write("Bakiye: ");
                hesap.Bakiye = decimal.Parse(Console.ReadLine());
                Console.Write("Ek Hesap Limiti: ");
                ((VadesizHesap)hesap).EkHesapLimiti = decimal.Parse(Console.ReadLine());
            }
            else if (secim == 2) // VadeliHesap seçildiyse
            {
                hesap = new VadeliHesap();
                Console.Write("Hesap Numarası: ");
                hesap.HesapNumarasi = Console.ReadLine();
                Console.Write("Hesap Sahibi: ");
                hesap.HesapSahibi = Console.ReadLine();
                Console.Write("Bakiye: ");
                hesap.Bakiye = decimal.Parse(Console.ReadLine());
                Console.Write("Vade Süresi (gün): ");
                ((VadeliHesap)hesap).VadeSuresi = int.Parse(Console.ReadLine());
                Console.Write("Faiz Oranı (%): ");
                ((VadeliHesap)hesap).FaizOrani = decimal.Parse(Console.ReadLine());
                Console.Write("Vade Doldu Mu? (true/false): ");
                ((VadeliHesap)hesap).VadeDolduMu = bool.Parse(Console.ReadLine());
            }
            else
            {
                Console.WriteLine("Geçersiz seçim! Program sonlandırılıyor.");
                return;
            }

            // Hesap bilgilerini yazdır
            Console.WriteLine("\nHesap Bilgileri:");
            hesap.BilgiYazdir();

            // İşlem seçimi
            Console.WriteLine("\nBir işlem seçiniz (1: Para Yatır, 2: Para Çek): ");
            int islem = int.Parse(Console.ReadLine());
            Console.Write("Miktar: ");
            decimal miktar = decimal.Parse(Console.ReadLine());

            if (islem == 1)
            {
                hesap.ParaYatir(miktar);
            }
            else if (islem == 2)
            {
                hesap.ParaCek(miktar);
            }
            else
            {
                Console.WriteLine("Geçersiz işlem!");
            }

            Console.Read();
        }
    }
}
