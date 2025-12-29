using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketYonetimSistemi
{
    // Tüm kişiler için ortak özellikleri içeren abstract sınıf
    abstract class Kisi
    {
        public string Ad { get; set; } // Kişinin adı
        public string Soyad { get; set; } // Kişinin soyadı
        public string Telefon { get; set; } // Kişinin telefon numarası

        public abstract void BilgiYazdir(); // Her bir kişi türü için farklı bilgi yazdırma işlemi
    }

    // Bireysel müşteri sınıfı, Kisi sınıfından türetilmiştir
    class BireyselMusteri : Kisi
    {
        public string TCNo { get; set; } // Müşterinin TC kimlik numarası

        public override void BilgiYazdir()
        {
            Console.WriteLine($"Bireysel Müşteri: {Ad} {Soyad}, Telefon: {Telefon}, TC No: {TCNo}");
        }
    }

    // Kurumsal müşteri sınıfı, Kisi sınıfından türetilmiştir
    class KurumsalMusteri : Kisi
    {
        public string SirketAdi { get; set; } // Şirket adı
        public string VergiNo { get; set; } // Vergi numarası

        public override void BilgiYazdir()
        {
            Console.WriteLine($"Kurumsal Müşteri: {SirketAdi}, İlgili Kişi: {Ad} {Soyad}, Telefon: {Telefon}, Vergi No: {VergiNo}");
        }
    }

    // Tüm ödeme türleri için temel abstract sınıf
    abstract class Odeme
    {
        public decimal Tutar { get; set; } // Ödeme tutarı
        public abstract void OdemeYap(); // Ödeme işlemi
    }

    // Kredi kartı ile ödeme işlemini temsil eden sınıf
    class KrediKartiOdeme : Odeme
    {
        public string KartNumarasi { get; set; } // Kredi kartı numarası

        public override void OdemeYap()
        {
            Console.WriteLine($"Kredi kartı ile {Tutar} TL ödeme alındı. Kart No: {KartNumarasi}");
        }
    }

    // Nakit ödeme işlemini temsil eden sınıf
    class NakitOdeme : Odeme
    {
        public override void OdemeYap()
        {
            Console.WriteLine($"Nakit olarak {Tutar} TL ödeme alındı.");
        }
    }

    // Havale ile ödeme işlemini temsil eden sınıf
    class HavaleOdeme : Odeme
    {
        public string IBAN { get; set; } // Havale yapılacak IBAN numarası

        public override void OdemeYap()
        {
            Console.WriteLine($"Havale ile {Tutar} TL ödeme alındı. IBAN: {IBAN}");
        }
    }

    // Ürünleri temsil eden sınıf
    class Urun
    {
        public string Ad { get; set; } // Ürün adı
        public decimal Fiyat { get; set; } // Ürün fiyatı
    }

    // Alışveriş sepetini temsil eden sınıf
    class Sepet
    {
        public List<Urun> Urunler { get; set; } = new List<Urun>(); // Sepetteki ürünler listesi
        public decimal IndirimMiktari { get; set; } = 0; // Uygulanan indirim miktarı

        public void SepeteEkle(Urun urun)
        {
            Urunler.Add(urun); // Ürünü sepete ekle
            Console.WriteLine($"{urun.Ad} sepete eklendi. Fiyat: {urun.Fiyat} TL");
        }

        public decimal ToplamTutar()
        {
            decimal toplam = 0;
            foreach (var urun in Urunler)
                toplam += urun.Fiyat; // Tüm ürünlerin toplam fiyatını hesapla
            return toplam - IndirimMiktari; // İndirim uygulandıktan sonra toplam tutarı döndür
        }

        // Sepet genişletme: Sepeti temizleme
        public void SepetiTemizle()
        {
            Urunler.Clear();
            IndirimMiktari = 0;
            Console.WriteLine("Sepet temizlendi.");
        }
    }

    // İndirim işlemleri için temel abstract sınıf
    abstract class Indirim
    {
        public abstract decimal IndirimiHesapla(decimal toplamTutar); // İndirim hesaplama metodu
    }

    // Yüzdelik indirim işlemini temsil eden sınıf
    class YuzdeIndirim : Indirim
    {
        public decimal Yuzde { get; set; } // İndirim yüzdesi

        public override decimal IndirimiHesapla(decimal toplamTutar)
        {
            return toplamTutar * Yuzde / 100; // Yüzdeye göre indirim hesapla
        }
    }

    // Sabit tutarlı indirim işlemini temsil eden sınıf
    class SabitIndirim : Indirim
    {
        public decimal Miktar { get; set; } // Sabit indirim miktarı

        public override decimal IndirimiHesapla(decimal toplamTutar)
        {
            return Miktar; // Sabit bir indirim döndür
        }
    }

    // Sipariş durumlarını temsil eden enum
    enum SiparisDurumu
    {
        Onaylandi, // Sipariş onaylandı
        Hazirlaniyor, // Sipariş hazırlanıyor
        TeslimEdildi // Sipariş teslim edildi
    }

    // Sipariş işlemlerini temsil eden sınıf
    class Siparis
    {
        public Sepet Sepet { get; set; } // Siparişe ait sepet
        public SiparisDurumu Durum { get; set; } // Siparişin mevcut durumu

        public void SiparisDurumuGuncelle(SiparisDurumu yeniDurum)
        {
            Durum = yeniDurum; // Sipariş durumunu güncelle
            Console.WriteLine($"Sipariş durumu güncellendi: {Durum}");
        }
    }

    // Müşteri yönetimi: Müşteri ekleme ve arama işlemleri için sınıf
    class MusteriYonetimi
    {
        // Sistemde kayıtlı müşterileri tutan liste
        public List<Kisi> Musteriler { get; set; } = new List<Kisi>();

        // Yeni bir müşteri eklemek için kullanılan yöntem
        public void MusteriEkle(Kisi musteri)
        {
            Musteriler.Add(musteri); // Müşteri listeye ekleniyor
            Console.WriteLine($"{musteri.Ad} {musteri.Soyad} sisteme eklendi."); // Ekleme işlemi onay mesajı
        }

        // Belirtilen kritere göre müşteri arama fonksiyonu
        public Kisi MusteriAra(string aramaKriteri)
        {
            // Müşteri listesinde verilen kritere uygun bir müşteri aranıyor
            var musteri = Musteriler.FirstOrDefault(m =>
                (m is BireyselMusteri bireysel && bireysel.TCNo == aramaKriteri) || // Bireysel müşterilerde TC no kontrolü
                (m is KurumsalMusteri kurumsal && kurumsal.VergiNo == aramaKriteri) || // Kurumsal müşterilerde Vergi no kontrolü
                m.Ad.Contains(aramaKriteri) || m.Soyad.Contains(aramaKriteri)); // İsim veya soyisimle arama

            // Müşteri bulunduysa bilgi yazdırılıyor, bulunamadıysa uyarı mesajı
            if (musteri != null)
            {
                Console.WriteLine($"Müşteri bulundu: {musteri.Ad} {musteri.Soyad}");
            }
            else
            {
                Console.WriteLine("Müşteri bulunamadı.");
            }

            return musteri; // Bulunan müşteri döndürülüyor
        }
    }

    // Ürün yönetimi: Yeni ürün ekleme ve ürün kaldırma işlemleri için sınıf
    class UrunYonetimi
    {
        // Ürünleri saklayan liste
        public List<Urun> UrunListesi { get; set; } = new List<Urun>();

        // Yeni bir ürün eklemek için kullanılan yöntem
        public void UrunEkle(Urun urun)
        {
            UrunListesi.Add(urun); // Ürün listeye ekleniyor
            Console.WriteLine($"{urun.Ad} ürün listesine eklendi."); // Ekleme işlemi onay mesajı
        }

        // Bir ürünü kaldırmak için kullanılan yöntem
        public void UrunKaldir(string urunAdi)
        {
            // Ürün listesinde verilen ada uygun ürün aranıyor
            var urun = UrunListesi.FirstOrDefault(u => u.Ad == urunAdi);
            if (urun != null)
            {
                UrunListesi.Remove(urun); // Ürün listeden kaldırılıyor
                Console.WriteLine($"{urunAdi} ürün listesinden kaldırıldı."); // Kaldırma işlemi onay mesajı
            }
            else
            {
                Console.WriteLine($"{urunAdi} ürün listesinde bulunamadı."); // Ürün bulunamazsa uyarı mesajı
            }
        }
    }

    // Ana program
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("~~~ ELEKTRONİK MARKET YÖNETİM SİSTEMİNE HOŞGELDİNİZ ~~~");
                Console.WriteLine("-------------------------------------------------------");

                // Müşteri yönetimi
                MusteriYonetimi musteriYonetimi = new MusteriYonetimi();

                // Bireysel müşteri oluşturma ve ekleme
                BireyselMusteri musteri1 = new BireyselMusteri { Ad = "Berat", Soyad = "Erol", Telefon = "5550884776", TCNo = "58764138858" };
                musteriYonetimi.MusteriEkle(musteri1);

                BireyselMusteri musteri2 = new BireyselMusteri { Ad = "Hasan", Soyad = "Kumbas", Telefon = "5430884732", TCNo = "14667838208" };
                musteriYonetimi.MusteriEkle(musteri2);

                // Kurumsal müşteri oluşturma ve ekleme
                KurumsalMusteri musteri3 = new KurumsalMusteri { Ad = "Yusuf", Soyad = "Özalan", Telefon = "5057747686", SirketAdi = "Özalan A.Ş.", VergiNo = "2247778665" };
                musteriYonetimi.MusteriEkle(musteri3);

                KurumsalMusteri musteri4 = new KurumsalMusteri { Ad = "Harun", Soyad = "Kağıtçı", Telefon = "5157747087", SirketAdi = "Kağıtçı A.Ş.", VergiNo = "5867888665" };
                musteriYonetimi.MusteriEkle(musteri4);

                Console.WriteLine("-------------------------------------------------------");

                // Müşteri arama
                musteriYonetimi.MusteriAra("Berat"); // Ad ile arama
                musteriYonetimi.MusteriAra("14667838208"); // TC ile arama
                musteriYonetimi.MusteriAra("2247778665"); // Vergi numarası ile arama
                musteriYonetimi.MusteriAra("Kağıtçı"); // Soyad ile arama

                Console.WriteLine("-------------------------------------------------------");

                // Ürün yönetimi
                UrunYonetimi urunYonetimi = new UrunYonetimi();

                // Ürün oluşturma ve ekleme
                Urun urun1 = new Urun { Ad = "Bilgisayar", Fiyat = 30000 };
                Urun urun2 = new Urun { Ad = "Telefon", Fiyat = 40000 };
                Urun urun3 = new Urun { Ad = "Kulaklık", Fiyat = 5000 };
                Urun urun4 = new Urun { Ad = "Telefon Kılıfı", Fiyat = 400 };
                Urun urun5 = new Urun { Ad = "Tablet", Fiyat = 12000 };
                Urun urun6 = new Urun { Ad = "Monitör", Fiyat = 15000 };
                Urun urun7 = new Urun { Ad = "Klavye", Fiyat = 2000 };
                Urun urun8 = new Urun { Ad = "Mouse", Fiyat = 1000 };
                Urun urun9 = new Urun { Ad = "Şarj Aleti", Fiyat = 1500 };
                Urun urun10 = new Urun { Ad = "Web Kamera", Fiyat = 3000 };

                urunYonetimi.UrunEkle(urun1);
                urunYonetimi.UrunEkle(urun2);
                urunYonetimi.UrunEkle(urun3);
                urunYonetimi.UrunEkle(urun4);
                urunYonetimi.UrunEkle(urun5);
                urunYonetimi.UrunEkle(urun6);
                urunYonetimi.UrunEkle(urun7);
                urunYonetimi.UrunEkle(urun8);
                urunYonetimi.UrunEkle(urun9);
                urunYonetimi.UrunEkle(urun10);

                Console.WriteLine("-------------------------------------------------------");

                // Ürün kaldırma
                urunYonetimi.UrunKaldir("Telefon Kılıfı");

                Console.WriteLine("-------------------------------------------------------");

                // Sepet işlemleri
                Sepet sepet = new Sepet();
                sepet.SepeteEkle(urun1);
                sepet.SepeteEkle(urun8);
                sepet.SepeteEkle(urun3);

                Console.WriteLine("-------------------------------------------------------");

                // İndirim işlemleri
                YuzdeIndirim yuzdeIndirim = new YuzdeIndirim { Yuzde = 20 }; // %20 indirim tanımla
                decimal indirim = yuzdeIndirim.IndirimiHesapla(sepet.ToplamTutar());
                sepet.IndirimMiktari = indirim;

                Console.WriteLine($"İndirim sonrası toplam tutar: {sepet.ToplamTutar()} TL");

                Console.WriteLine("-------------------------------------------------------");

                // Sipariş işlemleri
                Siparis siparis = new Siparis { Sepet = sepet, Durum = SiparisDurumu.Onaylandi };
                siparis.SiparisDurumuGuncelle(SiparisDurumu.Hazirlaniyor);
                siparis.SiparisDurumuGuncelle(SiparisDurumu.TeslimEdildi);

                Console.WriteLine("-------------------------------------------------------");

                // Ödeme işlemleri
                HavaleOdeme havaleOdeme = new HavaleOdeme { Tutar = sepet.ToplamTutar(), IBAN = "TR65 0001 0056 8745 6987 6250 01" };
                havaleOdeme.OdemeYap();

                Console.WriteLine("-------------------------------------------------------");

                // Sepeti temizleme
                sepet.SepetiTemizle();

                Console.WriteLine("-------------------------------------------------------");

                // Tüm müşterileri listeleme
                Console.WriteLine("Müşteri Listesi:");
                foreach (var musteri in musteriYonetimi.Musteriler)
                {
                    musteri.BilgiYazdir();
                }

                Console.WriteLine("-------------------------------------------------------");

                // Ürün listesini yazdırma
                Console.WriteLine("Ürün Listesi:");
                foreach (var urun in urunYonetimi.UrunListesi)
                {
                    Console.WriteLine($"Ürün Adı: {urun.Ad}, Fiyat: {urun.Fiyat} TL");
                }

                Console.WriteLine("-------------------------------------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Bir hata oluştu: {ex.Message}");
            }

            Console.ReadLine();
        }
    }
}

