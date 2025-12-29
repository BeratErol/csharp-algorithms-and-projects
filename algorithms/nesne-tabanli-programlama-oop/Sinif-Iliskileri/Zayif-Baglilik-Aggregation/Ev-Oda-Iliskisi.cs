using System;
using System.Collections.Generic;

// Oda sınıfı: Oda bilgilerini tutar.
class Oda
{
    // Odanın boyutu ve tipi
    public string Boyut { get; set; }
    public string Tip { get; set; }

    // Oda sınıfının kurucusu
    public Oda(string boyut, string tip)
    {
        Boyut = boyut;
        Tip = tip;
    }
}

// Ev sınıfı: Ev bilgilerini ve odalarını tutar.
class Ev
{
    // Evin adı ve odaların listesi
    public string Ad { get; set; }
    public List<Oda> Odalar { get; set; }

    // Ev sınıfının kurucusu
    public Ev(string ad)
    {
        Ad = ad;
        Odalar = new List<Oda>(); // Oda listesini başlat
    }

    // Evde bir oda ekleme metodu
    public void OdaEkle(Oda oda)
    {
        Odalar.Add(oda); // Yeni bir oda ekle
    }
}
