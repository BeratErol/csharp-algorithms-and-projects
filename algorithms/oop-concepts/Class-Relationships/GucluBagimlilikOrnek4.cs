using System;
using System.Collections.Generic;

// Ogrenci sınıfı: Öğrenci bilgilerini tutar.
class Ogrenci
{
    // Öğrencinin adı
    public string Ad { get; set; }

    // Öğrencinin yaşı (sadece bu sınıf içinde erişilebilir)
    private int Yas { get; set; }

    // Ogrenci sınıfının kurucusu
    public Ogrenci(string ad, int yas)
    {
        Ad = ad;
        Yas = yas;
    }

    // Öğrenci bilgilerini ekrana yazdıran metot
    public void OgrenciBilgisi()
    {
        Console.WriteLine("Öğrenci Adı: " + Ad + ", Yaşı: " + Yas);
    }
}

// Okul sınıfı: Okul bilgilerini ve öğrencilerini tutar.
class Okul
{
    // Okulun adı
    public string Ad { get; set; }

    // Okula kayıtlı öğrencilerin listesi
    public List<Ogrenci> Ogrenciler { get; set; }

    // Okul sınıfının kurucusu
    public Okul(string ad)
    {
        Ad = ad;
        Ogrenciler = new List<Ogrenci>(); // Öğrenci listesini başlat
    }

    // Okula yeni bir öğrenci ekleme metodu
    public void OgrenciOlustur(string ad, int yas)
    {
        Ogrenciler.Add(new Ogrenci(ad, yas)); // Yeni bir öğrenci oluştur ve listeye ekle
    }
}