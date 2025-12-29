using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum CalisanRolu
{
    Manager,   // Yönetici
    Developer, // Geliştirici
    Designer,  // Tasarımcı
    Tester     // Testçi
}

public class Calisan
{
    public CalisanRolu Rolu { get; set; }

    public Calisan(CalisanRolu rolu)
    {
        Rolu = rolu;  // Çalışanın rolünü alır
    }

    public void MaasHesapla()
    {
        // Enum'a göre maaş hesaplama
        double maas = 0;

        switch (Rolu)
        {
            case CalisanRolu.Manager:
                maas = 150000;  // Yönetici maaşı
                break;
            case CalisanRolu.Developer:
                maas = 80000;  // Geliştirici maaşı
                break;
            case CalisanRolu.Designer:
                maas = 70000;  // Tasarımcı maaşı
                break;
            case CalisanRolu.Tester:
                maas = 60000;  // Testçi maaşı
                break;
            default:
                Console.WriteLine("Bilinmeyen rol");
                break;
        }

        Console.WriteLine($"Çalışan maaşı: {maas} TL");
    }
}

class Program
{
    static void Main()
    {
        Calisan calisan = new Calisan(CalisanRolu.Developer);  // Geliştirici rolü
        calisan.MaasHesapla();  // Geliştirici maaşı hesaplanır

        Console.Read();
    }
}
