using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum HavaDurumu
{
    Sunny,   // Güneşli
    Rainy,   // Yağmurlu
    Cloudy,  // Bulutlu
    Stormy   // Fırtınalı
}

public class HavaDurumuTahmini
{
    public HavaDurumu Durum { get; set; }

    public HavaDurumuTahmini(HavaDurumu durum)
    {
        Durum = durum;  // Hava durumu tipini alır
    }

    public void TavsiyeVer()
    {
        // Enum'a göre tavsiyeleri verir
        switch (Durum)
        {
            case HavaDurumu.Sunny:
                Console.WriteLine("Güneşli hava - Dışarıda vakit geçirebilirsiniz.");
                break;
            case HavaDurumu.Rainy:
                Console.WriteLine("Yağmurlu hava - Şemsiye almayı unutmayın.");
                break;
            case HavaDurumu.Cloudy:
                Console.WriteLine("Bulutlu hava - Üstünüzü kalın tutun.");
                break;
            case HavaDurumu.Stormy:
                Console.WriteLine("Fırtınalı hava - Dışarı çıkmayın.");
                break;
            default:
                Console.WriteLine("Bilinmeyen hava durumu.");
                break;
        }
    }
}

class Program
{
    static void Main()
    {
        HavaDurumuTahmini tahmin = new HavaDurumuTahmini(HavaDurumu.Rainy);  // Yağmurlu hava
        tahmin.TavsiyeVer();  // Yağmurlu hava için tavsiye verir

        Console.Read();
    }
}
