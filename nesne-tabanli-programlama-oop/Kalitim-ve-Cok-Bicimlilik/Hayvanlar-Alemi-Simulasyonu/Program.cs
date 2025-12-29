using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru2
{
    // Temel Hayvan sınıfı
    class Hayvan
    {
        public string Ad { get; set; } // Hayvanın adı
        public string Tur { get; set; } // Hayvanın türü
        public int Yas { get; set; } // Hayvanın yaşı

        // Polimorfizm için sanal bir metot
        public virtual void SesCikar()
        {
            Console.WriteLine("Hayvan bir ses çıkardı."); // Varsayılan ses
        }
    }

    // Memeli sınıfı, Hayvan sınıfından türetiliyor
    class Memeli : Hayvan
    {
        public string TuyRengi { get; set; } // Memelinin tüy rengi

        // SesCikar() metodunu override ederek özelleştiriyoruz
        public override void SesCikar()
        {
            Console.WriteLine("Memeli: Grrr!"); // Memeliye özgü ses
        }
    }

    // Kus sınıfı, Hayvan sınıfından türetiliyor
    class Kus : Hayvan
    {
        public double KanatGenisligi { get; set; } // Kuşun kanat genişliği

        // SesCikar() metodunu override ederek özelleştiriyoruz
        public override void SesCikar()
        {
            Console.WriteLine("Kuş: Cik cik!"); // Kuşa özgü ses
        }
    }

    // Program sınıfı
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan hayvan türünü seçmesini iste
            Console.WriteLine("Hayvan türünü seçiniz (1: Memeli, 2: Kuş): ");
            int secim = int.Parse(Console.ReadLine()); // Kullanıcı girişi
            Hayvan hayvan; // Polimorfizm için temel sınıf referansı oluşturuyoruz

            if (secim == 1) // Memeli seçildiyse
            {
                hayvan = new Memeli(); // Memeli nesnesi oluştur
                Console.Write("Ad: ");
                hayvan.Ad = Console.ReadLine();
                Console.Write("Tür: ");
                hayvan.Tur = Console.ReadLine();
                Console.Write("Yaş: ");
                hayvan.Yas = int.Parse(Console.ReadLine());
                Console.Write("Tüy Rengi: ");
                ((Memeli)hayvan).TuyRengi = Console.ReadLine(); // Tür dönüşümü ile tüy rengi bilgisi al
            }
            else if (secim == 2) // Kuş seçildiyse
            {
                hayvan = new Kus(); // Kuş nesnesi oluştur
                Console.Write("Ad: ");
                hayvan.Ad = Console.ReadLine();
                Console.Write("Tür: ");
                hayvan.Tur = Console.ReadLine();
                Console.Write("Yaş: ");
                hayvan.Yas = int.Parse(Console.ReadLine());
                Console.Write("Kanat Genişliği (cm): ");
                ((Kus)hayvan).KanatGenisligi = double.Parse(Console.ReadLine()); // Tür dönüşümü ile kanat genişliği bilgisi al
            }
            else
            {
                Console.WriteLine("Geçersiz seçim! Program sonlandırılıyor.");
                return; // Geçersiz seçimde program sonlandırılır
            }

            // Hayvanın bilgilerini ekrana yazdır
            Console.WriteLine("\nHayvan Bilgileri:");
            Console.WriteLine($"Ad: {hayvan.Ad}, Tür: {hayvan.Tur}, Yaş: {hayvan.Yas}");
            if (hayvan is Memeli) // Eğer hayvan Memeli sınıfındansa
            {
                Console.WriteLine($"Tüy Rengi: {((Memeli)hayvan).TuyRengi}"); // Memeliye özel bilgiyi yazdır
            }
            else if (hayvan is Kus) // Eğer hayvan Kuş sınıfındansa
            {
                Console.WriteLine($"Kanat Genişliği: {((Kus)hayvan).KanatGenisligi} cm"); // Kuşa özel bilgiyi yazdır
            }

            // Hayvanın sesini çıkar
            Console.WriteLine("\nHayvanın Sesi:");
            hayvan.SesCikar(); // Polimorfik olarak doğru SesCikar() çağrılır

            Console.Read();
        }
    }
}
