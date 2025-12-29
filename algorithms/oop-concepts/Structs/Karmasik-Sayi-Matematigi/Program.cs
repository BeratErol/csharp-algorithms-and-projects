using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public struct KarmasikSayı
{
    public double Real { get; private set; }  // Gerçek kısmı
    public double Imaginary { get; private set; }  // Sanal kısmı

    // Yapıcı (Constructor) metodu
    public KarmasikSayı(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    // Toplama işlemi (operatör overloading ile)
    public static KarmasikSayı operator +(KarmasikSayı sayi1, KarmasikSayı sayi2)
    {
        double realToplam = sayi1.Real + sayi2.Real;  // Gerçek kısımlar toplanır
        double imaginaryToplam = sayi1.Imaginary + sayi2.Imaginary;  // Sanal kısımlar toplanır
        return new KarmasikSayı(realToplam, imaginaryToplam);  // Yeni karmaşık sayı döndürülür
    }

    // Çıkarma işlemi (operatör overloading ile)
    public static KarmasikSayı operator -(KarmasikSayı sayi1, KarmasikSayı sayi2)
    {
        double realFark = sayi1.Real - sayi2.Real;  // Gerçek kısımlar çıkarılır
        double imaginaryFark = sayi1.Imaginary - sayi2.Imaginary;  // Sanal kısımlar çıkarılır
        return new KarmasikSayı(realFark, imaginaryFark);  // Yeni karmaşık sayı döndürülür
    }

    // Karmaşık sayıyı "a + bi" formatında döndüren ToString() metodu
    public override string ToString()
    {
        return $"{Real} + {Imaginary}i";  // a + bi formatında döndürülür
    }
}

class Program
{
    static void Main()
    {
        KarmasikSayı sayi1 = new KarmasikSayı(6, 7);  // 6 + 7i
        KarmasikSayı sayi2 = new KarmasikSayı(4, 2);  // 4 + 2i
        KarmasikSayı toplam = sayi1 + sayi2;  // Toplama işlemi
        KarmasikSayı fark = sayi1 - sayi2;  // Çıkarma işlemi

        Console.WriteLine($"Toplam: {toplam}");  // Toplam yazdırılır: 10 + 9i
        Console.WriteLine($"Fark: {fark}");  // Fark yazdırılır: 2 + 5i

        Console.Read();
    }
}
