using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class OgrenciNotSistemi
{
    private Dictionary<string, int> notlar;  // Dersler ve notlarını tutan bir sözlük (Dictionary)

    public OgrenciNotSistemi()
    {
        notlar = new Dictionary<string, int>();  // Yeni bir sözlük oluşturuluyor
    }

    // İndeksleyici
    public int this[string dersAdi]  // Kullanıcı, ders adına göre notlara erişebilecek
    {
        get
        {
            if (notlar.ContainsKey(dersAdi))  // Ders adı sözlükte var mı kontrol ediliyor
                return notlar[dersAdi];  // Dersin notu döndürülüyor
            else
                throw new KeyNotFoundException("Ders bulunamadı.");  // Ders bulunmazsa hata mesajı
        }
        set
        {
            notlar[dersAdi] = value;  // Ders adı ve notu sözlüğe ekleniyor veya güncelleniyor
        }
    }
}

class Program
{
    static void Main()
    {
        OgrenciNotSistemi ogrenci = new OgrenciNotSistemi();  // Öğrenci not sistemi oluşturuluyor
        ogrenci["Matematik"] = 65;  // Matematik dersinin notu 65 olarak ayarlanıyor
        ogrenci["Fizik"] = 70;  // Fizik dersinin notu 70 olarak ayarlanıyor

        Console.WriteLine("Matematik Notu: " + ogrenci["Matematik"]);  // Matematik dersinin notu ekrana yazdırılıyor

        try
        {
            Console.WriteLine(ogrenci["Kimya"]);  // Kimya dersi sözlükte yok, hata oluşacak
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);  // Ders bulunamadı hatası yazdırılıyor
        }

        Console.Read();
    }
}
