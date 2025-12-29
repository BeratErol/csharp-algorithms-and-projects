using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml1_
{
    // Adres Sınıfı
    public class Adres
    {
        // Adres bilgilerini tutan özellikler
        public string Sokak { get; set; }
        public string Sehir { get; set; }
        public string Eyalet { get; set; }
        public int PostaKodu { get; set; }
        public string Ulke { get; set; }

        // Adres doğrulama metodu
        public bool Dogrula()
        {
            // Basit bir adres doğrulama kontrolü
            return !string.IsNullOrEmpty(Sokak) && !string.IsNullOrEmpty(Sehir);
        }

        // Adresi etiket formatında döndüren metot
        public string EtiketOlarakYazdir()
        {
            return $"{Sokak}, {Sehir}, {Eyalet}, {PostaKodu}, {Ulke}";
        }
    }

    // Kisi Sınıfı
    public class Kisi
    {
        // Temel kişi bilgileri
        public string Isim { get; set; }
        public string TelefonNumarasi { get; set; }
        public string EpostaAdresi { get; set; }
        public Adres Adres { get; set; }

        // Park kartı satın alma işlemi
        public void ParkKartıSatınAl()
        {
            Console.WriteLine($"{Isim}, park kartı satın aldı.");
        }
    }

    // Ogrenci Sınıfı (Soyut Sınıf)
    public abstract class Ogrenci : Kisi
    {
        // Öğrenciye özel bilgiler
        public int OgrenciNumarasi { get; set; }
        public int OrtalamaNot { get; set; }

        // Soyut metot (alt sınıflar tarafından uygulanacak)
        public abstract bool KayitOlabilirMi(string ders);

        // Seminer sayısını döndüren metot
        public int SeminerSayisiniAl()
        {
            return 5; // Varsayılan olarak 5 seminer
        }

        // Öğrencinin denetleyen profesörleri
        public List<Profesor> DenetleyenProfesörler { get; set; } = new List<Profesor>();
    }

    // LisansOgrenci Sınıfı (Ogrenci sınıfından türemekte)
    public class LisansOgrenci : Ogrenci
    {
        // KayitOlabilirMi metodu implementasyonu
        public override bool KayitOlabilirMi(string ders)
        {
            // Örneğin, öğrencinin ortalaması 50'den büyükse kayıt olabilir
            return OrtalamaNot >= 50;
        }
    }

    // Profesor Sınıfı
    public class Profesor : Kisi
    {
        // Profesöre özel bilgiler
        protected int maas;
        protected int personelNumarasi;
        private int hizmetYili;
        public int DersSayisi { get; set; }

        // Profesörün denetlediği öğrenciler
        public List<Ogrenci> DenetledigimOgrenciler { get; set; } = new List<Ogrenci>();

        // Yapıcı metot
        public Profesor(int maas, int personelNumarasi)
        {
            this.maas = maas;
            this.personelNumarasi = personelNumarasi;
        }

        // Öğrenci ekleme işlemi
        public void OgrenciEkle(Ogrenci ogrenci)
        {
            if (DenetledigimOgrenciler.Count < 5)
            {
                DenetledigimOgrenciler.Add(ogrenci);
                Console.WriteLine($"Profesör {Isim}, {ogrenci.Isim} öğrencisini denetlemeye başladı.");
            }
            else
            {
                Console.WriteLine($"Profesör {Isim} maksimum 5 öğrenciyi denetleyebilir.");
            }
        }

        // Maaş özelliği
        public int Maas
        {
            get { return maas; }
            set { maas = value; }
        }

        // Hizmet yılı özelliği
        public int HizmetYili
        {
            get { return hizmetYili; }
            set { hizmetYili = value; }
        }
    }

    // Test Programı
    class Program
    {
        static void Main(string[] args)
        {
            // Adres oluşturma
            Adres adres1 = new Adres
            {
                Sokak = "Ferah Sokak",
                Sehir = "Elazığ",
                Eyalet = "Merkez",
                PostaKodu = 27100,
                Ulke = "Türkiye"
            };

            // Profesör oluşturma
            Profesor profesor = new Profesor(15000, 67890)
            {
                Isim = "Dr. Cem Baydoğan",
                TelefonNumarasi = "05449876543",
                EpostaAdresi = "baydogan@gmail.com",
                Adres = adres1
            };

            // Lisans öğrencisi oluşturma
            LisansOgrenci ogrenci1 = new LisansOgrenci
            {
                Isim = "Berat Erol",
                TelefonNumarasi = "05551234567",
                EpostaAdresi = "beratlore00@gmail.com",
                OgrenciNumarasi = 235541010,
                OrtalamaNot = 85,
                Adres = adres1
            };

            // Test: Öğrencinin park kartı satın alması
            ogrenci1.ParkKartıSatınAl();

            // Test: Öğrenci kaydı
            bool kayitDurumu = ogrenci1.KayitOlabilirMi("Matematik");
            Console.WriteLine($"{ogrenci1.Isim}, Matematik dersine kayıt olabilir mi? {kayitDurumu}");

            // Test: Profesörün öğrenci eklemesi
            profesor.OgrenciEkle(ogrenci1);

            // Test: Adres doğrulama ve yazdırma
            Console.WriteLine($"Adres doğrulama sonucu: {adres1.Dogrula()}");
            Console.WriteLine($"Adres etiketi: {adres1.EtiketOlarakYazdir()}");

            // Test: Profesörün denetlediği öğrenciler
            Console.WriteLine($"Profesör {profesor.Isim} tarafından denetlenen öğrenciler:");
            foreach (var ogrenci in profesor.DenetledigimOgrenciler)
            {
                Console.WriteLine($"- {ogrenci.Isim}");
            }

            // Test: Öğrencinin denetleyen profesörleri
            ogrenci1.DenetleyenProfesörler.Add(profesor);
            Console.WriteLine($"Öğrenci {ogrenci1.Isim} tarafından denetlenen profesörler:");
            foreach (var profesör in ogrenci1.DenetleyenProfesörler)
            {
                Console.WriteLine($"- {profesör.Isim}");
            }

            Console.Read();
        }
    }
}


