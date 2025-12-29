using System;

// Departman sınıfı: Departman bilgilerini tutar.
class Departman
{
    // Departmanın adı ve lokasyonu
    public string Ad { get; set; }
    public string Lokasyon { get; set; }

    // Departman sınıfının kurucusu
    public Departman(string ad, string lokasyon)
    {
        Ad = ad;
        Lokasyon = lokasyon;
    }
}

// Calisan sınıfı: Çalışan bilgilerini ve bağlı olduğu departmanı tutar.
class Calisan
{
    // Çalışanın adı ve pozisyonu
    public string Ad { get; set; }
    public string Pozisyon { get; set; }

    // Çalışanın bağlı olduğu departman
    public Departman Departman { get; set; }

    // Calisan sınıfının kurucusu
    public Calisan(string ad, string pozisyon)
    {
        Ad = ad;
        Pozisyon = pozisyon;
    }

    // Çalışana departman atama metodu
    public void DepartmanAtama(Departman departman)
    {
        Departman = departman; // Çalışana bir departman ata
    }
}
