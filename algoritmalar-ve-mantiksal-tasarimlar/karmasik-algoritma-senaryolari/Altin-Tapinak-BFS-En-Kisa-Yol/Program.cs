using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AltinTapinak
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcidan labirent boyutunu (N x N) alma
            Console.WriteLine("Labirent boyutunu giriniz (N x N): ");
            int n = int.Parse(Console.ReadLine());

            // Rastgele bir N x N boyutunda harita olusturma
            int[,] labirent = LabirentOlustur(n);

            // Olusturulan labirenti ekrana yazdirma
            LabirentiYazdir(labirent);
            
            // En kisa yolu bulan fonksiyonu atama
            int enKisaYol = EnKisaYoluBulma(labirent);

            // Labirentin başlangic noktasindan hedef noktasina ulasilabilmisse en kisa yolu yazdirma
            if (enKisaYol != -1)
            {
                Console.WriteLine("En Kısa Yol: " + enKisaYol + " adım");
                Console.Read();
            }
            // Ulasilamazsa yol yok yazdirma
            else
            {
                Console.WriteLine("Yol Yok");
                Console.Read();
            }
        }

        // N x N boyutunda rastgele bir labirent oluşturma
        static int[,] LabirentOlustur(int n)
        {
            Random rand = new Random();
            int[,] labirent = new int[n, n];
            
            // Hücreleri rastgele 0 ya da 1'lerle doldurma
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                     // Dongu ile tum degerlere atama yapma
                     labirent[i, j] = rand.Next(0, 2); 
                }
            }
            // Olusturulan labirenti dondurme
            return labirent;
        }

        // Labirenti ekrana yazdirma
        static void LabirentiYazdir(int[,] labirent)
        {
            int n = labirent.GetLength(0);
            Console.WriteLine("Girilen boyut carpiminda olusturulan rastgele labirent:");
            // Döngü ile tüm satir ve sütunlari yazdirma
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(labirent[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // En kısa yolu bulmak için fonksiyon
        static int EnKisaYoluBulma(int[,] labirent)
        {
            int n = labirent.GetLength(0);

            // Baslangic noktasi 0'sa ya da hedefin hicbir komsusu 1 degilse -1 yani olumsuz döndürme
            if (labirent[0, 0] == 0 || labirent[n - 1, n - 1] == 0)
            {
                return -1;
            }

            // Komsu hücreleri tarayabilmek icin x veya y'leri sabit tutarak komsulari gezebileceğimiz dizi olusturma
            int[,] yonler = { { -1, 0 }, { 1, 0 }, { 0, -1 }, { 0, 1 } };

            // Ziyaret edilen noktalar icin dogru yanlis atamasi
            bool[,] ziyaretEdildiMi = new bool[n, n];

            // Kuyruğa yeni konumlar ekleyip bu konumları işleyerek labirentte en kısa yolu bulma
            Queue<Tuple<int, int, int>> kuyruk = new Queue<Tuple<int, int, int>>();
            kuyruk.Enqueue(Tuple.Create(0, 0, 0)); // (satır, sütun, adım sayısı)
            ziyaretEdildiMi[0, 0] = true;

            // Labirentteki en kisa yolu bulmak icin BFS döngüsü
            while (kuyruk.Count > 0)
            {
                var konum = kuyruk.Dequeue();
                int x = konum.Item1;
                int y = konum.Item2;
                int adim = konum.Item3;

                // Hazine noktasina ulasildiginda adim sayisi döndürme
                if (x == n - 1 && y == n - 1)
                {
                    return adim;
                }

                // Komsu hücreleri tarama
                for (int i = 0; i < 4; i++)
                {
                    // 
                    int yeniX = x + yonler[i, 0];
                    int yeniY = y + yonler[i, 1];

                    // Komsu hücre harita siniri icindeyse, 1'se ve ziyaret edilmediyse en kisa yolu kuyruga ekleme 
                    if (yeniX >= 0 && yeniX < n && yeniY >= 0 && yeniY < n && labirent[yeniX, yeniY] == 1 && !ziyaretEdildiMi[yeniX, yeniY])
                    {
                        ziyaretEdildiMi[yeniX, yeniY] = true;
                        kuyruk.Enqueue(Tuple.Create(yeniX, yeniY, adim + 1));
                    }
                }
            }
            // Kuyruk bitmesine ragmen hazineye ulasilamadiysa yok yok yazdirma
            return -1;
        }
    }
}
/*
BU KODDA ÇÖZÜLMESİ İSTENEN PROBLEM:
Efsanelere göre, ormanın derinliklerinde saklı Altın Tapınak’a ulaşan kişi, tapınağın
içindeki paha biçilemez hazineyi bulacaktır. Ancak bu tapınağa ulaşmak o kadar kolay
değildir. Tapınağın etrafını kuşatan kadim bir labirent, içinde birçok tuzak ve çıkmaz
barındırıyor. Tapınağın içindeki hazineye ulaşabilmek için maceracılar N x N
boyutlarındaki bir labirentte doğru yolu bulmak zorunda. Labirent, 0 ve 1'lerden oluşan bir
grid ile temsil ediliyor. 1’ler yürünebilen yolları, 0’lar ise tuzaklar veya duvarları temsil
ediyor. Maceracılar, sadece 1 olan hücrelerde yürüyebilirler. Macera sırasında, maceracı
tapınağın girişinden (0, 0) hücresinden başlayarak (N-1, N-1) hücresindeki hazinenin
bulunduğu noktaya gitmek zorunda. Ancak bu yolculuk sırasında en kısa rotayı bulmak
çok önemlidir, çünkü tapınağın etrafındaki tuzaklar giderek kapanıyor. Maceracının
yukarı, aşağı, sağ ve sola doğru hareket edebildiğini unutmayın. Ayrıca sadece geçerli
hücrelere (1 olan hücrelere) adım atabilir.
Görev: Bu N x N boyutlarındaki labirentte maceracının başlangıç noktasından hazinenin
bulunduğu noktaya en kısa yolu bulması gerekiyor. En kısa yolu bulan bir fonksiyon yazın
ve kaç adımda hazinenin bulunduğunu hesaplayın. Eğer hazineye ulaşılamıyorsa, "Yol
Yok" sonucunu döndürün.
*/

/*
BAZI KAVRAMLARIN AÇIKLAMALARI: 
Queue: İlk giren ilk çıkar (FIFO) mantığıyla çalışan bir veri yapısıdır.
Tuple: Farklı türde birden fazla veriyi tek bir yapı altında saklayan sabit boyutlu bir veri tipidir.
Kuyruk: Queue'nun Türkçe karşılığı olup, sırayla işlem yapmak için kullanılan veri yapısıdır.
Enqueue: Kuyruğa (Queue) yeni bir eleman eklemek için kullanılan işlemdir.
*/
