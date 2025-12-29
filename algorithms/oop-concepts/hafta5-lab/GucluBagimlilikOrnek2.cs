using System;

// Islemci sınıfı: İşlemci bilgilerini tutar.
class Islemci
{
    // İşlemcinin çekirdek sayısı ve frekansı
    public int Cekirdekler { get; set; }
    public int Frekans { get; set; }

    // Islemci sınıfının kurucusu
    public Islemci(int cekirdekler, int frekans)
    {
        Cekirdekler = cekirdekler;
        Frekans = frekans;
    }

    // İşlemci bilgilerini ekrana yazdıran metot
    public void IslemciBilgisi()
    {
        Console.WriteLine("Çekirdek Sayısı: " + Cekirdekler + ", Frekans: " + Frekans + " MHz");
    }
}

// Bilgisayar sınıfı: Bilgisayar bilgilerini ve işlemcisini tutar.
class Bilgisayar
{
    // Bilgisayarın modeli
    public string Model { get; set; }

    // Bilgisayara ait işlemci
    public Islemci Islemci { get; set; }

    // Bilgisayar sınıfının kurucusu
    public Bilgisayar(string model)
    {
        Model = model;
        IslemciOlustur(); // Varsayılan bir işlemci oluştur
    }

    // Bilgisayara bir işlemci oluşturma metodu
    public void IslemciOlustur()
    {
        Islemci = new Islemci(4, 3200); // 4 çekirdekli, 3200 MHz işlemci oluştur
    }
}
