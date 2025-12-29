using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct Zaman
{
    public int Hour { get; private set; }  // Saat
    public int Minute { get; private set; }  // Dakika

    // Yapıcı (Constructor) metodu
    public Zaman(int hour, int minute)
    {
        // Eğer saat 0-23 arasında değilse 0 yapılır
        Hour = (hour >= 0 && hour < 24) ? hour : 0;
        // Eğer dakika 0-59 arasında değilse 0 yapılır
        Minute = (minute >= 0 && minute < 60) ? minute : 0;
    }

    // Toplam dakika hesaplayan metot
    public int ToplamDakika()
    {
        return (Hour * 60) + Minute;  // Saat * 60 + dakika olarak toplam dakika döndürülür
    }

    // İki zaman arasındaki farkı dakika olarak hesaplayan metot
    public static int Fark(Zaman zaman1, Zaman zaman2)
    {
        int fark = Math.Abs(zaman1.ToplamDakika() - zaman2.ToplamDakika());  // İki zaman arasındaki fark mutlak değeri alınarak hesaplanır
        return fark;
    }
}

class Program
{
    static void Main()
    {
        Zaman zaman1 = new Zaman(14, 30);  // 14 saat, 30 dakika
        Zaman zaman2 = new Zaman(16, 45);  // 16 saat, 45 dakika
        Console.WriteLine($"Zaman 1 Toplam Dakika: {zaman1.ToplamDakika()}");  // Toplam dakika yazdırılır
        Console.WriteLine($"Zaman 2 Toplam Dakika: {zaman2.ToplamDakika()}");  // Toplam dakika yazdırılır
        Console.WriteLine($"Zamanlar Arasındaki Fark: {Zaman.Fark(zaman1, zaman2)} dakika");  // Zamanlar arasındaki fark yazdırılır

        Console.Read();
    }
}
