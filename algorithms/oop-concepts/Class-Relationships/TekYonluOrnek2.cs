using System;
using System.Collections.Generic;

// Kitap sınıfı: Kitap bilgilerini tutar.
class Kitap
{
    // Kitabın başlığı ve ISBN numarası
    public string Baslik { get; set; }
    public string ISBN { get; set; }

    // Kitap sınıfının kurucusu
    public Kitap(string baslik, string isbn)
    {
        Baslik = baslik;
        ISBN = isbn;
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
        Kitaplar.Add(kitap); // Yeni bir kitabı listeye ekle
    }
}
