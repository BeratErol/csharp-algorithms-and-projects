using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Otopark
{
    private string[][] katlar;  // Katlar dizisi, her kat için park yeri dizisi tutuyor

    public Otopark(int katSayisi, int parkYeriSayisi)
    {
        katlar = new string[katSayisi][];  // Katlar dizisi, belirli bir sayıda katla başlatılıyor
        for (int i = 0; i < katSayisi; i++)
        {
            katlar[i] = new string[parkYeriSayisi];  // Her kat için park yerleri dizisi oluşturuluyor
            // Başlangıçta tüm park yerleri boş
            for (int j = 0; j < parkYeriSayisi; j++)
            {
                katlar[i][j] = "Empty";  // Her park yeri "Empty" olarak işaretleniyor
            }
        }
    }

    // İndeksleyici
    public string this[int kat, int parkYeri]  // Kullanıcı, kat ve park yeri kombinasyonu ile park yerlerine erişebilecek
    {
        get
        {
            if (kat >= 0 && kat < katlar.Length && parkYeri >= 0 && parkYeri < katlar[kat].Length)  // Geçerli park yeri kontrol ediliyor
                return katlar[kat][parkYeri];  // Park yerindeki durumu (boş/dolu) döndürüyor
            else
                throw new IndexOutOfRangeException("Geçersiz park yeri.");  // Geçersiz park yeri hatası
        }
        set
        {
            if (kat >= 0 && kat < katlar.Length && parkYeri >= 0 && parkYeri < katlar[kat].Length)  // Geçerli park yeri kontrol ediliyor
                katlar[kat][parkYeri] = value;  // Park yerine yeni değer (boş/dolu) atanıyor
            else
                throw new IndexOutOfRangeException("Geçersiz park yeri.");  // Geçersiz park yeri hatası
        }
    }
}

class Program
{
    static void Main()
    {
        Otopark otopark = new Otopark(3, 5);  // 3 kat, her kat için 5 park yeri olan bir otopark oluşturuluyor
        otopark[0, 0] = "34DR123";  // 0. kat, 0. park yerine 34DR123 plakalı araç yerleştiriliyor
        otopark[1, 2] = "44AAE777";  // 1. kat, 2. park yerine 44AAE777 plakalı araç yerleştiriliyor

        Console.WriteLine(otopark[0, 0]);  // 0. kat, 0. park yerindeki araç ekrana yazdırılıyor
        Console.WriteLine(otopark[1, 2]);  // 1. kat, 2. park yerindeki araç ekrana yazdırılıyor

        // Boş park yeri
        Console.WriteLine(otopark[2, 4]);  // "Empty" yazdırılacak

        try
        {
            Console.WriteLine(otopark[3, 5]);  // Geçersiz park yeri, hata oluşacak
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);  // Geçersiz park yeri hatası yazdırılıyor
        }

        Console.Read();
    }
}
