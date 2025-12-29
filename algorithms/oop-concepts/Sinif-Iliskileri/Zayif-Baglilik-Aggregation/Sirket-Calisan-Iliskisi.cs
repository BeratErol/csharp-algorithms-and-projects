using System;
using System.Collections.Generic;

// Calisan sınıfı: Çalışan bilgilerini tutar.
class Calisan
{
    // Çalışanın adı ve pozisyonu
    public string Ad { get; set; }
    public string Pozisyon { get; set; }

    // Calisan sınıfının kurucusu
    public Calisan(string ad, string pozisyon)
    {
        Ad = ad;
        Pozisyon = pozisyon;
    }
}

// Sirket sınıfı: Şirket bilgilerini ve çalışanlarını tutar.
class Sirket
{
    // Şirketin adı ve çalışanlar listesi
    public string Ad { get; set; }
    public List<Calisan> Calisanlar { get; set; }

    // Sirket sınıfının kurucusu
    public Sirket(string ad)
    {
        Ad = ad;
        Calisanlar = new List<Calisan>(); // Çalışan listesini başlat
    }

    // Şirkete yeni bir çalışan ekleme metodu
    public void CalisanEkle(Calisan calisan)
    {
        Calisanlar.Add(calisan); // Yeni bir çalışan ekle
    }
}