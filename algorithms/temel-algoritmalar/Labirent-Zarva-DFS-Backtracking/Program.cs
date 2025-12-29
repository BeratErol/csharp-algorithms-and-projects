using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabirentZarva
{
    class Program
    {
        // Sağ, Aşağı, Sol, Yukarı yönlerini temsil eden dizi
        static int[,] yönler = { { 0, 1 }, { 1, 0 }, { 0, -1 }, { -1, 0 } };
        static int satirSayisi = 5; // Labirentin satır sayısı
        static int sutunSayisi = 5; // Labirentin sütun sayısı
        static bool[,] ziyaretEdildi; // Ziyaret edilen hücreler için dizi

        static void Main()
        {
            // Ziyaret edilmeyen hücreler için dizi oluştur
            ziyaretEdildi = new bool[satirSayisi, sutunSayisi];

            // Labirenti yazdır
            Console.WriteLine("Labirent Haritası:");
            HaritayıYazdır();

            // Başlangıç noktasından hedef noktaya ulaşmaya çalış
            List<string> yol = new List<string>(); // Yolu saklamak için bir liste
            if (LabirentiÇöz(0, 0, yol))
            {
                Console.WriteLine("Şehre ulaşıldı!");
            }
            else
            {
                Console.WriteLine("Şehir kayboldu!"); // Hedefe ulaşılamazsa
            }
            Console.Read();
        }

        // Labirentteki hücreleri kontrol eden ve hedefe ulaşmaya çalışan metot
        static bool LabirentiÇöz(int x, int y, List<string> yol)
        {
            // Eğer hedef noktasına ulaşıldıysa
            if (x == satirSayisi - 1 && y == sutunSayisi - 1)
            {
                // Adımları yazdır
                yol.Add($"({x}, {y})");
                Console.WriteLine("Geçilen yollar: " + string.Join(" -> ", yol));
                return true;
            }

            // Geçerli hücre kontrolü
            if (x < 0 || x >= satirSayisi || y < 0 || y >= sutunSayisi || !KapıAçıkMi(x, y) || ziyaretEdildi[x, y])
            {
                return false; // Geçersiz hücre
            }

            // Mevcut hücreyi yola ekle ve ziyaret edildi olarak işaretle
            yol.Add($"({x}, {y})");
            ziyaretEdildi[x, y] = true; // Hücre ziyaret edildi

            // Tüm yönlerde ilerlemeyi dene
            for (int i = 0; i < yönler.GetLength(0); i++)
            {
                int yeniX = x + yönler[i, 0]; // Yeni x koordinatı
                int yeniY = y + yönler[i, 1]; // Yeni y koordinatı

                // Eğer hedefe ulaşılabilirse
                if (LabirentiÇöz(yeniX, yeniY, yol))
                {
                    return true; // Hedefe ulaşıldı
                }
            }

            // Mevcut hücreden çıkarken yolu temizle
            yol.RemoveAt(yol.Count - 1);
            return false; // Hedefe ulaşılamadı
        }

        // Kapının açılıp açılmadığını kontrol eden metot
        static bool KapıAçıkMi(int x, int y)
        {
            return AsalMi(x) && AsalMi(y) && (x + y) % (x * y) == 0; // Asal ve koşula göre
        }

        // Bir sayının asal olup olmadığını kontrol eden metot
        static bool AsalMi(int sayi)
        {
            if (sayi < 2) return false; // 2'den küçük sayılar asal değildir
            for (int i = 2; i <= Math.Sqrt(sayi); i++)
            {
                if (sayi % i == 0) return false; // Sayı asal değilse
            }
            return true; // Sayı asal
        }

        // Labirent haritasını yazdıran metot
        static void HaritayıYazdır()
        {
            for (int x = 0; x < satirSayisi; x++)
            {
                for (int y = 0; y < sutunSayisi; y++)
                {
                    // Eğer hücre geçebiliyorsa 'O', geçilemiyorsa 'X' yazdır
                    Console.Write(KapıAçıkMi(x, y) ? "O " : "X ");
                }
                Console.WriteLine(); // Her satırdan sonra yeni bir satıra geç
            }
        }
    }
}
