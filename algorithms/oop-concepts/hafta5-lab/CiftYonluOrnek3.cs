using System;
using System.Collections.Generic;

// Kitap sınıfı: Kitap bilgilerini ve yazarını tutar.
class Kitap
{
    // Kitabın başlığı ve yayın tarihi
    public string Baslik { get; set; }
    public DateTime YayinTarihi { get; set; }

    // Kitabın yazarı
    public Yazar Yazar { get; set; }

    // Kitap sınıfının kurucusu
    public Kitap(string baslik, DateTime yayinTarihi)
    {
        Baslik = baslik;
        YayinTarihi = yayinTarihi;
    }

    // Kitaba yazar atama metodu
    public void YazarAtama(Yazar yazar)
    {
        // Eğer yazar farklıysa atama yap
        if (Yazar != yazar)
        {
            Yazar = yazar;
        }
    }
}

// Yazar sınıfı: Yazar bilgilerini ve yazdığı kitapları tutar.
class Yazar
{
    // Yazarın adı ve ülkesi
    public string Ad { get; set; }
    public string Ulke { get; set; }

    // Yazarın yazdığı kitapların listesi
    public List<Kitap> Kitaplar { get; set; }

    // Yazar sınıfının kurucusu
    public Yazar(string ad, string ülke)
    {
        Ad = ad;
        Ulke = ülke;
        Kitaplar = new List<Kitap>(); // Kitap listesini başlat
    }

    // Yazara kitap ekleme metodu
    public void KitapEkle(Kitap kitap)
    {
        // Eğer kitap listede yoksa ekle
        if (!Kitaplar.Contains(kitap))
        {
            Kitaplar.Add(kitap);
            kitap.YazarAtama(this); // Kitaba yazarı ata
        }
    }
}
