using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum TrafikIsigiDurumu
{
    Red,    // Kırmızı
    Yellow, // Sarı
    Green   // Yeşil
}

public class TrafikIsigi
{
    public TrafikIsigiDurumu Durum { get; set; }

    public TrafikIsigi(TrafikIsigiDurumu durum)
    {
        Durum = durum;  // Trafik ışığının durumunu alır
    }

    public void DurumaGoreIslem()
    {
        // Enum'a göre yapılacak işlemler
        switch (Durum)
        {
            case TrafikIsigiDurumu.Red:
                Console.WriteLine("Kırmızı ışık - Durdurun");
                break;
            case TrafikIsigiDurumu.Yellow:
                Console.WriteLine("Sarı ışık - Hazırlanın");
                break;
            case TrafikIsigiDurumu.Green:
                Console.WriteLine("Yeşil ışık - Geçin");
                break;
            default:
                Console.WriteLine("Bilinmeyen durum");
                break;
        }
    }
}

class Program
{
    static void Main()
    {
        TrafikIsigi isik = new TrafikIsigi(TrafikIsigiDurumu.Green);  // Yeşil ışık
        isik.DurumaGoreIslem();  // Yeşil ışığa göre işlem yapılır

        Console.Read();
    }
}

