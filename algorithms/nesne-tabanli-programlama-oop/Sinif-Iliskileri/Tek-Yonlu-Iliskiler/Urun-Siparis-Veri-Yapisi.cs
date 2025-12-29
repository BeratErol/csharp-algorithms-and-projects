using System;

// Urun sınıfı: Ürün bilgilerini tutar.
class Urun
{
    // Ürünün adı
    public string Ad { get; set; }

    // Ürünün fiyatı (yalnızca bu sınıf içinde erişilebilir)
    private int Fiyat { get; set; }

    // Urun sınıfının kurucusu
    public Urun(string ad, int fiyat)
    {
        Ad = ad;
        Fiyat = fiyat;
    }

    // Ürünün fiyatını döndüren metot
    public int GetFiyat()
    {
        return Fiyat;
    }

    // Ürün bilgilerini döndüren metot
    public string UrunBilgisi()
    {
        return "Ürün: " + Ad + ", Fiyat: " + GetFiyat() + " TL";
    }
}

// Siparis sınıfı: Sipariş bilgilerini tutar.
class Siparis
{
    // Siparişin tarihi
    public DateTime Tarih { get; set; }

    // Siparişin toplam tutarı
    public decimal Toplam { get; set; }

    // Siparis sınıfının kurucusu
    public Siparis(DateTime tarih, decimal toplam)
    {
        Tarih = tarih;
        Toplam = toplam;
    }
}
