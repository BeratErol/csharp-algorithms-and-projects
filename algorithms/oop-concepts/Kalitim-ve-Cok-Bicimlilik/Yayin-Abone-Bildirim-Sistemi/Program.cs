using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// IYayinci Arayüzü
public interface IYayinci
{
    void AboneEkle(IAbone abone);
    void AboneCikar(IAbone abone);
    void AboneListele();
    void BildirimGonder(string mesaj);
}

// IAbone Arayüzü
public interface IAbone
{
    void BilgiAl(string mesaj);
}

// Yayinci Sınıfı
public class Yayinci : IYayinci
{
    private List<IAbone> aboneler = new List<IAbone>();

    // Abone ekleme
    public void AboneEkle(IAbone abone)
    {
        aboneler.Add(abone);
        Console.WriteLine("Abone eklendi.");
    }

    // Abone çıkarma
    public void AboneCikar(IAbone abone)
    {
        aboneler.Remove(abone);
        Console.WriteLine("Abone çıkarıldı.");
    }

    // Abonelere bildirim gönderme
    public void BildirimGonder(string mesaj)
    {
        Console.WriteLine("\nYayıncı bir bildirim gönderiyor: " + mesaj);
        foreach (var abone in aboneler)
        {
            abone.BilgiAl(mesaj);
        }
    }

    // Aboneleri listeleme
    public void AboneListele()
    {
        Console.WriteLine("\nAboneler:");
        foreach (var abone in aboneler)
        {
            Console.WriteLine(abone.GetType().Name);
        }
    }
}

// Abone Sınıfı
public class Abone : IAbone
{
    public string Ad { get; set; }

    public Abone(string ad)
    {
        Ad = ad;
    }

    // Bildirimi alma
    public void BilgiAl(string mesaj)
    {
        Console.WriteLine($"{Ad} adlı abone mesaj aldı: {mesaj}");
    }
}

// Program Sınıfı
public class Program
{
    public static void Main()
    {
        // Yayıncı oluşturuluyor
        Yayinci yayinci = new Yayinci();

        // Aboneler oluşturuluyor
        Abone abone1 = new Abone("Berat");
        Abone abone2 = new Abone("Mustafa");
        Abone abone3 = new Abone("Emir");

        // Aboneleri yayına ekliyoruz
        yayinci.AboneEkle(abone1);
        yayinci.AboneEkle(abone2);
        yayinci.AboneEkle(abone3);

        // Yayıncı bir değişiklik yapıyor ve abonelere bildirim gönderiyor
        yayinci.BildirimGonder("Yeni yayın başlıyor!");

        // Aboneleri listeleyelim
        yayinci.AboneListele();

        // Mehmet aboneliğini iptal etsin
        yayinci.AboneCikar(abone2);

        // Yayıncı tekrar bir değişiklik yapıyor
        yayinci.BildirimGonder("Yeni haber! Yayın değişti.");

        Console.Read();
    }
}
