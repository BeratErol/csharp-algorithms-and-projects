using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Kitaplik
{
    private string[] kitaplar;  // Kitapları saklamak için bir dizi tanımlanıyor

    public Kitaplik(int kapasite)
    {
        kitaplar = new string[kapasite];  // Kitaplık, verilen kapasiteye göre başlatılıyor
    }

    // İndeksleyici
    public string this[int index]  // Kullanıcı, kitaplara indeksle erişebilecek
    {
        get
        {
            if (index >= 0 && index < kitaplar.Length)  // İndeksin geçerli olup olmadığı kontrol ediliyor
                return kitaplar[index];  // Geçerli indeksle kitabın adı döndürülüyor
            else
                throw new IndexOutOfRangeException("Geçersiz indeks.");  // Geçersiz indeksse hata mesajı
        }
        set
        {
            if (index >= 0 && index < kitaplar.Length)  // İndeksin geçerli olup olmadığı kontrol ediliyor
                kitaplar[index] = value;  // Geçerli indeksse, kitap adı güncelleniyor
            else
                throw new IndexOutOfRangeException("Geçersiz indeks.");  // Geçersiz indeksse hata mesajı
        }
    }
}

class Program
{
    static void Main()
    {
        Kitaplik kitaplik = new Kitaplik(5);  // Kitaplık oluşturuluyor, kapasite 5
        kitaplik[0] = "Kitap 1";  // 0. indekse "Kitap 1" ekleniyor
        kitaplik[1] = "Kitap 2";  // 1. indekse "Kitap 2" ekleniyor
        Console.WriteLine(kitaplik[0]);  // 0. indeksteki kitap ekrana yazdırılıyor: "Kitap 1"

        try
        {
            Console.WriteLine(kitaplik[10]);  // 10. indeks geçersiz, hata oluşacak
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);  // Geçersiz indeks hatası yazdırılıyor
        }

        Console.Read();
    }
}
