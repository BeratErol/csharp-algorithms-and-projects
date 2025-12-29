using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru1
{
    // Temel Calisan sınıfı
    class Calisan
    {
        public string Ad { get; set; } // Çalışanın adı
        public string Soyad { get; set; } // Çalışanın soyadı
        public decimal Maas { get; set; } // Çalışanın maaşı
        public string Pozisyon { get; set; } // Çalışanın pozisyonu

        // Polimorfizm için sanal bir metot
        public virtual void BilgiYazdir()
        {
            Console.WriteLine($"Ad: {Ad}, Soyad: {Soyad}, Maaş: {Maas} TL, Pozisyon: {Pozisyon}");
        }
    }

    // Yazilimci sınıfı, Calisan sınıfından türetiliyor
    class Yazilimci : Calisan
    {
        public string YazilimDili { get; set; } // Yazılımcının bildiği yazılım dili

        // BilgiYazdir() metodunu override ederek özelleştiriyoruz
        public override void BilgiYazdir()
        {
            base.BilgiYazdir(); // Temel sınıftaki bilgileri yazdır
            Console.WriteLine($"Yazılım Dili: {YazilimDili}"); // Yazılım dili bilgisini ekle
        }
    }

    // Muhasebeci sınıfı, Calisan sınıfından türetiliyor
    class Muhasebeci : Calisan
    {
        public string MuhasebeYazilimi { get; set; } // Muhasebecinin kullandığı muhasebe yazılımı

        // BilgiYazdir() metodunu override ederek özelleştiriyoruz
        public override void BilgiYazdir()
        {
            base.BilgiYazdir(); // Temel sınıftaki bilgileri yazdır
            Console.WriteLine($"Muhasebe Yazılımı: {MuhasebeYazilimi}"); // Muhasebe yazılımı bilgisini ekle
        }
    }

    // Program sınıfı
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan çalışan türünü seçmesini iste
            Console.WriteLine("Çalışan türünü seçiniz (1: Yazılımcı, 2: Muhasebeci): ");
            int secim = int.Parse(Console.ReadLine()); // Kullanıcı girişi
            Calisan calisan; // Polimorfizm için temel sınıf referansı oluşturuyoruz

            if (secim == 1) // Yazılımcı seçildiyse
            {
                calisan = new Yazilimci(); // Yazilimci nesnesi oluştur
                Console.Write("Ad: ");
                calisan.Ad = Console.ReadLine();
                Console.Write("Soyad: ");
                calisan.Soyad = Console.ReadLine();
                Console.Write("Maaş: ");
                calisan.Maas = decimal.Parse(Console.ReadLine());
                Console.Write("Pozisyon: ");
                calisan.Pozisyon = Console.ReadLine();
                Console.Write("Yazılım Dili: ");
                ((Yazilimci)calisan).YazilimDili = Console.ReadLine(); // Tür dönüşümü ile yazılım dili bilgisi al
            }
            else if (secim == 2) // Muhasebeci seçildiyse
            {
                calisan = new Muhasebeci(); // Muhasebeci nesnesi oluştur
                Console.Write("Ad: ");
                calisan.Ad = Console.ReadLine();
                Console.Write("Soyad: ");
                calisan.Soyad = Console.ReadLine();
                Console.Write("Maaş: ");
                calisan.Maas = decimal.Parse(Console.ReadLine());
                Console.Write("Pozisyon: ");
                calisan.Pozisyon = Console.ReadLine();
                Console.Write("Muhasebe Yazılımı: ");
                ((Muhasebeci)calisan).MuhasebeYazilimi = Console.ReadLine(); // Tür dönüşümü ile muhasebe yazılımı bilgisi al
            }
            else
            {
                Console.WriteLine("Geçersiz seçim! Program sonlandırılıyor.");
                return; // Geçersiz seçimde program sonlandırılır
            }

            // Çalışanın bilgilerini ekrana yazdır
            Console.WriteLine("\nÇalışan Bilgileri:");
            calisan.BilgiYazdir(); // Polimorfik olarak doğru BilgiYazdir() çağrılır

            Console.Read();
        }
    }
}
