using System;
using System.Collections.Generic;

// Calisan sınıfı: Çalışan bilgilerini ve çalıştığı şirketi tutar.
class Calisan
{
    // Çalışanın başlığı ve işe başlama tarihi
    public string Baslik { get; set; }
    public DateTime YayinTarihi { get; set; }

    // Çalışanın bağlı olduğu şirket
    public Sirket Sirket { get; set; }

    // Calisan sınıfının kurucusu
    public Calisan(string baslik, DateTime yayinTarihi)
    {
        Baslik = baslik;
        YayinTarihi = yayinTarihi;
    }

    // Çalışana şirket atama metodu
    public void SirketAtama(Sirket sirket)
    {
        // Eğer şirket farklıysa atama yap
        if (Sirket != sirket)
        {
            Sirket = sirket;
        }
    }
}

// Sirket sınıfı: Şirket bilgilerini ve çalışanlarını tutar.
class Sirket
{
    // Şirketin adı ve konumu
    public string Ad { get; set; }
    public string Konum { get; set; }

    // Şirkete ait çalışanların listesi
    public List<Calisan> Calisanlar { get; set; }

    // Sirket sınıfının kurucusu
    public Sirket(string ad, string konum)
    {
        Ad = ad;
        Konum = konum;
        Calisanlar = new List<Calisan>(); // Çalışan listesini başlat
    }

    // Şirkete çalışan ekleme metodu
    public void CalisanEkle(Calisan calisan)
    {
        // Eğer çalışan listede yoksa ekle
        if (!Calisanlar.Contains(calisan))
        {
            Calisanlar.Add(calisan);
            calisan.SirketAtama(this); // Çalışana şirketi ata
        }
    }
}