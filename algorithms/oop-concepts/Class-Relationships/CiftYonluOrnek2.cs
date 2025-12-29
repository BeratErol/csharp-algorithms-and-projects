using System;
using System.Collections.Generic;

// Doktor sınıfı: Doktor bilgilerini ve hastalarını tutar.
class Doktor
{
    // Doktorun adı ve branşı
    public string Ad { get; set; }
    public string Brans { get; set; }

    // Doktorun baktığı hastalar
    public List<Hasta> Hastalar { get; set; }

    // Doktor sınıfının kurucusu
    public Doktor(string ad, string brans)
    {
        Ad = ad;
        Brans = brans;
        Hastalar = new List<Hasta>(); // Hasta listesini başlat
    }

    // Hastayı doktora ekleme metodu
    public void HastaEkle(Hasta hasta)
    {
        // Eğer hasta listede yoksa ekle
        if (!Hastalar.Contains(hasta))
        {
            Hastalar.Add(hasta);
            hasta.DoktorAtama(this); // Hastaya doktor ataması yap
        }
    }
}

// Hasta sınıfı: Hasta bilgilerini ve doktorunu tutar.
class Hasta
{
    // Hastanın adı ve T.C. kimlik numarası
    public string Ad { get; set; }
    public string TCNo { get; set; }

    // Hastaya atanmış doktor
    public Doktor Doktor { get; set; }

    // Hasta sınıfının kurucusu
    public Hasta(string ad, string tcNo)
    {
        Ad = ad;
        TCNo = tcNo;
    }

    // Hastaya doktor atama metodu
    public void DoktorAtama(Doktor doktor)
    {
        // Eğer doktor farklıysa atama yap
        if (Doktor != doktor)
        {
            Doktor = doktor;
        }
    }
}
