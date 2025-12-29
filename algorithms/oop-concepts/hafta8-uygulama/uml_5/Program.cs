using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml_5
{
    // İşlem Sınıfı: İşlemlerle ilgili bilgileri tutar ve güncelleme yapar
    public class Islem
    {
        protected int id; // İşlem için benzersiz kimlik
        public string Ad { get; set; } // İşlemin adı
        public string Tarih { get; set; } // İşlemin tarihi
        public string Adres { get; set; } // İşlemin adresi

        // Bir işlem birden çok rezervasyon içerebilir (1..*)
        public List<Rezervasyon> Rezervasyonlar { get; set; } = new List<Rezervasyon>();

        // İşlem güncelleme metodu
        public void Guncelle()
        {
            Console.WriteLine("İşlem güncellendi.");
        }
    }

    // Rezervasyon Sınıfı: Rezervasyonlarla ilgili bilgileri tutar
    public class Rezervasyon
    {
        protected int id; // Rezervasyon için benzersiz kimlik
        public string Detaylar { get; set; } // Rezervasyonun detayları
        public string Liste { get; set; } // Rezervasyon listesi

        // Her rezervasyon sadece bir işlemle ilişkilidir (*..1)
        public Islem IlgiliIslem { get; set; }

        public KiralamaSahibi IlgiliKiralamaSahibi { get; set; } // Kiralama Sahibi ile ilişki kurma

        // Rezervasyonu onaylama metodu
        public void Onayla()
        {
            Console.WriteLine("Rezervasyon onaylandı.");

            // Kiralama sahibine bildirim gönder
            IlgiliKiralamaSahibi?.BildirimGonder(this);
        }
    }

    // Müşteri Sınıfı: Müşteri ile ilgili bilgileri tutar
    public class Musteri
    {
        protected int id; // Müşteri için benzersiz kimlik
        public string Ad { get; set; } // Müşterinin adı
        public string Iletisim { get; set; } // Müşterinin iletişim bilgisi
        public string Adres { get; set; } // Müşterinin adresi
        public List<Odeme> Odemeler { get; set; } = new List<Odeme>(); // Müşterinin ödemeleri

        // İşlem oluşturma metodu
        public Islem IslemOlustur()
        {
            Islem yeniIslem = new Islem();
            Console.WriteLine("Yeni işlem oluşturuldu.");
            return yeniIslem;
        }

        // Müşteri bilgilerini güncelleme metodu
        public void Guncelle()
        {
            Console.WriteLine("Müşteri bilgileri güncellendi.");
        }

        // Müşteriye ödeme ekleme metodu
        public void OdemeEkle(Odeme odeme)
        {
            Odemeler.Add(odeme);
            Console.WriteLine("Müşteriye yeni ödeme kaydedildi.");
        }
    }

    // Araç Sınıfı: Araçlarla ilgili bilgileri tutar
    public class Arac
    {
        protected int id; // Araç için benzersiz kimlik
        public string Marka { get; set; } // Aracın markası
        public string Model { get; set; } // Aracın modeli
        public decimal Fiyat { get; set; } // Aracın fiyatı

        // Araç ödemesini işleme metodu
        public void OdemeIsle()
        {
            Console.WriteLine("Araç ödemesi işlendi.");
        }
    }

    // Ödeme Sınıfı: Ödemelerle ilgili bilgileri tutar
    public class Odeme
    {
        public int id; // Ödeme için benzersiz kimlik
        public string KartNumarasi { get; set; } // Kart numarası
        public decimal Tutar { get; set; } // Ödeme tutarı

        // Ödeme ekleme metodu
        public void Ekle()
        {
            Console.WriteLine($"{Tutar} tutarında ödeme eklendi.");
        }

        // Ödeme güncelleme metodu
        public void Guncelle()
        {
            Console.WriteLine("Ödeme güncellendi.");
        }
    }

    // Kiralama Sahibi Sınıfı: Kiralama sahipleriyle ilgili bilgileri tutar
    public class KiralamaSahibi
    {
        protected int id; // Kiralama sahibi için benzersiz kimlik
        public string Ad { get; set; } // Kiralama sahibinin adı
        public string Yas { get; set; } // Kiralama sahibinin yaşı
        public string IletisimNo { get; set; } // Kiralama sahibinin iletişim numarası
        private string KullaniciAdi { get; set; } // Kiralama sahibinin kullanıcı adı
        private string Sifre { get; set; } // Kiralama sahibinin şifresi

        // Hesap doğrulama metodu
        public void HesapDogrula()
        {
            Console.WriteLine("Hesap doğrulandı.");
        }

        // Kiralama sahibine rezervasyon bildirimi gönderme metodu
        public void BildirimGonder(Rezervasyon rezervasyon)
        {
            Console.WriteLine($"Rezervasyon bildirimi: {rezervasyon.Detaylar}");
        }
    }

    // Kiralama Sınıfı: Kiralamalarla ilgili bilgileri tutar
    public class Kiralama
    {
        public int id; // Kiralama için benzersiz kimlik
        public string Adlar { get; set; } // Kiralama adları
        public decimal Fiyat { get; set; } // Kiralamanın fiyatı

        // Kiralamayı ekleme metodu
        public void Ekle()
        {
            Console.WriteLine("Kiralama eklendi.");
        }

        // Kiralamayı güncelleme metodu
        public void Guncelle()
        {
            Console.WriteLine("Kiralama güncellendi.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Müşteri oluşturma
            Musteri musteri = new Musteri { Ad = "Berat", Iletisim = "555-7467", Adres = "Elazığ" };

            // Müşteriye ödeme ekleme
            Odeme odeme1 = new Odeme { KartNumarasi = "1234567812345678", Tutar = 500m };
            Odeme odeme2 = new Odeme { KartNumarasi = "9876543210987654", Tutar = 300m };
            musteri.OdemeEkle(odeme1);
            musteri.OdemeEkle(odeme2);

            // Ödemeleri ekrana yazdırma
            Console.WriteLine("Müşterinin Ödemeleri:");
            foreach (var odeme in musteri.Odemeler)
            {
                odeme.Ekle();
            }

            // İşlem oluşturma
            Islem yeniIslem = musteri.IslemOlustur();
            yeniIslem.Ad = "Araç Kiralama";
            yeniIslem.Tarih = "2024-12-30";
            yeniIslem.Adres = "Elazığ, Merkez";

            // Araç oluşturma
            Arac arac = new Arac { Marka = "Dacia", Model = "Duster", Fiyat = 200m };

            // Araç ödemesini işleme
            Console.WriteLine("\nAraç Ödeme İşlemi:");
            arac.OdemeIsle();

            // Rezervasyon oluşturma
            Rezervasyon rezervasyon = new Rezervasyon { Detaylar = "Haftalık araç kiralama" };
            KiralamaSahibi kiralamaSahibi = new KiralamaSahibi { Ad = "Harun", Yas = "40", IletisimNo = "555-4358" };
            rezervasyon.IlgiliKiralamaSahibi = kiralamaSahibi;

            // Rezervasyonu onaylama
            Console.WriteLine("\nRezervasyon Onaylama:");
            rezervasyon.Onayla();

            // Yeni kiralama oluşturma
            Kiralama yeniKiralama = new Kiralama { Adlar = "Araba Kiralama", Fiyat = 150m };
            yeniKiralama.Ekle();

            // Müşteri bilgilerini ekrana yazdırma
            Console.WriteLine("\nMüşteri Bilgileri:");
            Console.WriteLine($"Ad: {musteri.Ad}");
            Console.WriteLine($"İletişim: {musteri.Iletisim}");
            Console.WriteLine($"Adres: {musteri.Adres}");

            // Araç sahibinin bilgilerini ekrana yazdırma
            Console.WriteLine("\nKiralama Sahibi Bilgileri:");
            Console.WriteLine($"Ad: {kiralamaSahibi.Ad}");
            Console.WriteLine($"Yaş: {kiralamaSahibi.Yas}");
            Console.WriteLine($"İletişim No: {kiralamaSahibi.IletisimNo}");

            // Müşteriyi güncelleme
            musteri.Adres = "Karabük, Safranbolu"; // Müşterinin adresini güncelliyoruz
            musteri.Guncelle();

            // İşlem güncelleme
            yeniIslem.Guncelle();

            // Kiralama sahibinin hesap doğrulaması
            kiralamaSahibi.HesapDogrula();

            // Ödeme güncelleme
            odeme1.Tutar = 550m; // İlk ödemeyi güncelliyoruz
            odeme1.Guncelle();

            Console.Read();
        }
    }
}
