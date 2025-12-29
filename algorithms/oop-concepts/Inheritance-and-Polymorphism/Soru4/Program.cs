using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
    public static void Main()
    {
        // BirikimHesabi oluşturma
        BirikimHesabi birikimHesap = new BirikimHesabi(5) { HesapNo = 58436 };
        birikimHesap.ParaYatir(3000);
        birikimHesap.ParaCek(200);
        Console.WriteLine(birikimHesap.HesapOzeti());

        Console.WriteLine("-------------------------");

        // VadesizHesap oluşturma
        VadesizHesap vadesizHesap = new VadesizHesap(10) { HesapNo = 67740 };
        vadesizHesap.ParaYatir(20000);
        vadesizHesap.ParaCek(1100);
        Console.WriteLine(vadesizHesap.HesapOzeti());

        Console.Read();
    }
}

// IBankaHesabi Arayüzü
public interface IBankaHesabi
{
    DateTime HesapAcilisTarihi { get; }
    string HesapOzeti();
}

// Soyut Hesap Sınıfı
public abstract class Hesap : IBankaHesabi
{
    public int HesapNo { get; set; }
    public decimal Bakiye { get; protected set; }
    public DateTime HesapAcilisTarihi { get; private set; }

    // Constructor
    protected Hesap()
    {
        HesapAcilisTarihi = DateTime.Now;
    }

    // Abstract Metotlar
    public abstract void ParaYatir(decimal miktar);
    public abstract void ParaCek(decimal miktar);

    // Hesap Özeti Metodu
    public virtual string HesapOzeti()
    {
        return $"Hesap No: {HesapNo}\nBakiye: {Bakiye} TL\nAçılış Tarihi: {HesapAcilisTarihi}";
    }
}

// BirikimHesabi Sınıfı
public class BirikimHesabi : Hesap
{
    public decimal FaizOrani { get; set; }

    public BirikimHesabi(decimal faizOrani)
    {
        FaizOrani = faizOrani;
    }

    public override void ParaYatir(decimal miktar)
    {
        decimal faiz = miktar * FaizOrani / 100;
        Bakiye += miktar + faiz;
        Console.WriteLine($"Birikim hesabınıza {miktar} TL yatırıldı. Faiz kazancı: {faiz} TL");
    }

    public override void ParaCek(decimal miktar)
    {
        if (miktar > Bakiye)
        {
            Console.WriteLine("Yetersiz bakiye.");
        }
        else
        {
            Bakiye -= miktar;
            Console.WriteLine($"Birikim hesabınızdan {miktar} TL çekildi.");
        }
    }
}

// VadesizHesap Sınıfı
public class VadesizHesap : Hesap
{
    public decimal IslemUcreti { get; set; }

    public VadesizHesap(decimal islemUcreti)
    {
        IslemUcreti = islemUcreti;
    }

    public override void ParaYatir(decimal miktar)
    {
        Bakiye += miktar;
        Console.WriteLine($"Vadesiz hesabınıza {miktar} TL yatırıldı.");
    }

    public override void ParaCek(decimal miktar)
    {
        decimal toplamMiktar = miktar + IslemUcreti;

        if (toplamMiktar > Bakiye)
        {
            Console.WriteLine("Yetersiz bakiye.");
        }
        else
        {
            Bakiye -= toplamMiktar;
            Console.WriteLine($"Vadesiz hesabınızdan {miktar} TL çekildi. İşlem ücreti: {IslemUcreti} TL");
        }
    }
}
