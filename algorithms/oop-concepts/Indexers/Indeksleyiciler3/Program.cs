using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class SatrancTasi
{
    private string[,] tahta;  // Satranç tahtasını temsil etmek için 2 boyutlu dizi (8x8)

    public SatrancTasi()
    {
        tahta = new string[8, 8];  // Satranç tahtası oluşturuluyor, 8 satır 8 sütun
        // Tahtadaki her kareye "Boş" atanıyor
        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                tahta[i, j] = "Boş";  // Başlangıçta tüm kareler boş
            }
        }
    }

    // İndeksleyici
    public string this[int satir, int sutun]  // Kullanıcı, satır ve sütun girerek kareye taş koyabilecek
    {
        get
        {
            if (satir >= 0 && satir < 8 && sutun >= 0 && sutun < 8)  // Geçerli bir kare mi kontrol ediliyor
                return tahta[satir, sutun];  // Tahtadaki taş ya da "Boş" döndürülüyor
            else
                throw new IndexOutOfRangeException("Geçersiz kare.");  // Geçersiz bir kare seçildiyse hata mesajı
        }
        set
        {
            if (satir >= 0 && satir < 8 && sutun >= 0 && sutun < 8)  // Geçerli bir kare mi kontrol ediliyor
                tahta[satir, sutun] = value;  // Taş, belirtilen kareye yerleştiriliyor
            else
                throw new IndexOutOfRangeException("Geçersiz kare.");  // Geçersiz bir kare seçildiyse hata mesajı
        }
    }
}

class Program
{
    static void Main()
    {
        SatrancTasi tahta = new SatrancTasi();  // Yeni bir satranç tahtası oluşturuluyor
        tahta[0, 0] = "Kale";  // 0. satır, 0. sütununa Kale yerleştiriliyor
        tahta[0, 1] = "At";  // 0. satır, 1. sütununa At yerleştiriliyor

        Console.WriteLine(tahta[0, 0]);  // 0,0 noktasındaki taş ekrana yazdırılıyor: Kale
        Console.WriteLine(tahta[0, 1]);  // 0,1 noktasındaki taş ekrana yazdırılıyor: At

        try
        {
            Console.WriteLine(tahta[8, 8]);  // 8,8 noktası geçersiz, hata oluşacak
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);  // Geçersiz kare hatası yazdırılıyor
        }

        Console.Read();
    }
}
