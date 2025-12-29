using System;

// Motor sınıfı: Motor bilgilerini tutar.
class Motor
{
    // Motorun gücü ve tipi
    public int Guc { get; set; }
    public string Tip { get; set; }

    // Motor sınıfının kurucusu
    public Motor(int guc, string tip)
    {
        Guc = guc;
        Tip = tip;
    }

    // Motor bilgilerini ekrana yazdıran metot
    public void MotorBilgisi()
    {
        Console.WriteLine("Motor Gücü: " + Guc + " HP, Tip: " + Tip);
    }
}

// Otomobil sınıfı: Otomobil bilgilerini ve motorunu tutar.
class Otomobil
{
    // Otomobilin markası
    public string Marka { get; set; }

    // Otomobile ait motor
    public Motor Motor { get; set; }

    // Otomobil sınıfının kurucusu
    public Otomobil(string marka)
    {
        Marka = marka;
        MotorOlustur(); // Varsayılan bir motor oluştur
    }

    // Otomobile bir motor oluşturma metodu
    public void MotorOlustur()
    {
        Motor = new Motor(150, "Benzinli"); // 150 HP, benzinli motor oluştur
    }
}
