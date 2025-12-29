using System;

// Siparis sınıfı: Sipariş bilgilerini tutar.
class Siparis
{
    // Siparişin tarihi ve durumu
    public DateTime Tarih { get; set; }
    public string Durum { get; set; }

    // Siparis sınıfının kurucusu
    public Siparis(DateTime tarih, string durum)
    {
        Tarih = tarih;
        Durum = durum;
    }
}

// Müsteri sınıfı: Müşteri bilgilerini tutar ve sipariş verme işlemi gerçekleştirir.
class Müsteri
{
    // Müşterinin adı ve telefonu
    public string Ad { get; set; }
    public string Telefon { get; set; }

    // Müsteri sınıfının kurucusu
    public Müsteri(string ad, string telefon)
    {
        Ad = ad;
        Telefon = telefon;
    }

    // Müşterinin sipariş verme metodu
    public void SiparisVer(Siparis siparis)
    {
        // Siparişin durumuna göre mesaj yazdırma
        Console.WriteLine(Ad + " adlı müşteri " + siparis.Durum + " siparişi verdi.");
    }
}
