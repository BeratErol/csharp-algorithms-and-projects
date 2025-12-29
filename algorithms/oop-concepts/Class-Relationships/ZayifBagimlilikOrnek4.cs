using System;
using System.Collections.Generic;

// Kitap sınıfı: Kitap bilgilerini tutar.
class Kitap
{
    // Kitabın başlığı ve yazarı
    public string Baslik { get; set; }
    public string Yazar { get; set; }

    // Kitap sınıfının kurucusu
    public Kitap(string baslik, string yazar)
    {
        Baslik = baslik;
        Yazar = yazar;
    }
}

// Kutuphane sınıfı: Kütüphane bilgilerini ve kitaplarını tutar.
class Kutuphane
{
    // Kütüphanenin adı ve kitaplar listesi
    public string Ad { get; set; }
    public List<Kitap> Kitaplar { get; set; }

    // Kutuphane sınıfının kurucusu
    public Kutuphane(string ad)
    {
        Ad = ad;
        Kitaplar = new List<Kitap>(); // Kitaplar listesini başlat
    }

    // Kütüphaneye yeni bir kitap ekleme metodu
    public void KitapEkle(Kitap kitap)
    {
        Kitaplar.Add(kitap); // Yeni bir kitap ekle
    }
}