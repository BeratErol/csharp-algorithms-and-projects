using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Soyut Urun Sınıfı
public abstract class Urun
{
    public string Ad { get; set; }
    public decimal Fiyat { get; set; }

    // Soyut Metot: Her ürün kendi ödeme hesaplamasını tanımlayacak
    public abstract decimal HesaplaOdeme();

    // Genel Bilgi Yazdırma Metodu
    public virtual void BilgiYazdir()
    {
        Console.WriteLine($"Ürün Adı: {Ad}");
        Console.WriteLine($"Fiyat: {Fiyat} TL");
    }
}

// Kitap Sınıfı
public class Kitap : Urun
{
    public string Yazar { get; set; }
    public override decimal HesaplaOdeme()
    {
        // %10 Vergi ekleniyor
        return Fiyat + (Fiyat * 0.10m);
    }

    public override void BilgiYazdir()
    {
        base.BilgiYazdir();
        Console.WriteLine($"Yazar: {Yazar}");
        Console.WriteLine($"Ödenecek Tutar: {HesaplaOdeme()} TL");
    }
}

// Elektronik Sınıfı
public class Elektronik : Urun
{
    public string Marka { get; set; }
    public override decimal HesaplaOdeme()
    {
        // %25 Vergi ekleniyor
        return Fiyat + (Fiyat * 0.25m);
    }

    public override void BilgiYazdir()
    {
        base.BilgiYazdir();
        Console.WriteLine($"Marka: {Marka}");
        Console.WriteLine($"Ödenecek Tutar: {HesaplaOdeme()} TL");
    }
}

// Program Sınıfı
public class Program
{
    public static void Main()
    {
        // Ürün Listesi
        List<Urun> urunler = new List<Urun>();

        // Kitap Ekleme
        Kitap kitap = new Kitap
        {
            Ad = "C# Programlama",
            Fiyat = 500,
            Yazar = "Kemal Sayar"
        };
        urunler.Add(kitap);

        // Elektronik Ürün Ekleme
        Elektronik elektronik = new Elektronik
        {
            Ad = "Kulaklık",
            Fiyat = 1500,
            Marka = "JBL"
        };
        urunler.Add(elektronik);

        // Ürün Bilgilerini Yazdırma
        Console.WriteLine("Mağaza Ürünleri:\n");
        foreach (var urun in urunler)
        {
            urun.BilgiYazdir();
            Console.WriteLine("----------------------");
        }

        Console.Read();
    }
}
