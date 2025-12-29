using System;
using System.Collections.Generic;

// Cocuk sınıfı: Çocuk bilgilerini ve ebeveynini tutar.
class Cocuk
{
    // Çocuğun adı ve yaşı
    public string Ad { get; set; }
    public int Yas { get; set; }

    // Çocuğun bağlı olduğu ebeveyn
    public Ebeveyn Ebeveyn { get; set; }

    // Cocuk sınıfının kurucusu
    public Cocuk(string ad, int yas)
    {
        Ad = ad;
        Yas = yas;
    }

    // Çocuğa ebeveyn atama metodu
    public void EbeveynAtama(Ebeveyn ebeveyn)
    {
        // Eğer ebeveyn farklıysa atama yap
        if (Ebeveyn != ebeveyn)
        {
            Ebeveyn = ebeveyn;
        }
    }
}

// Ebeveyn sınıfı: Ebeveyn bilgilerini ve çocuklarını tutar.
class Ebeveyn
{
    // Ebeveynin adı ve yaşı
    public string Ad { get; set; }
    public int Yas { get; set; }

    // Ebeveynin sahip olduğu çocukların listesi
    public List<Cocuk> Cocuklar { get; set; }

    // Ebeveyn sınıfının kurucusu
    public Ebeveyn(string ad, int yas)
    {
        Ad = ad;
        Yas = yas;
        Cocuklar = new List<Cocuk>(); // Çocuk listesini başlat
    }

    // Ebeveyne çocuk ekleme metodu
    public void CocukEkle(Cocuk cocuk)
    {
        // Eğer çocuk listede yoksa ekle
        if (!Cocuklar.Contains(cocuk))
        {
            Cocuklar.Add(cocuk);
            cocuk.EbeveynAtama(this); // Çocuğa ebeveyni ata
        }
    }
}
