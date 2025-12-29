using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechCity
{
    class Program
    {
        static void Main(string[] args)
        {
            // Robotlarin komsularini tarayabilmek icin x veya y'leri sabit tutarak komsulari gezebileceğimiz dizi olusturma
            int[,] yonler = new int[,] { { -1, 0 }, { 1, 0 }, { 0, -1 }, { 0, 1 } };

            // Kullanıcidan harita boyutunu (N x N) alma
            Console.WriteLine("Harita boyutunu giriniz (N x N): ");
            int n = int.Parse(Console.ReadLine());

            // Rastgele bir N x N boyutunda harita olusturma
            int[,] grid = GridOlustur(n);

            // Olusturulan haritayı ekrana yazdirma
            GridiYazdir(grid);

            // Robotlarin baslangic pozisyonlarini liste halinde tutma
            List<Tuple<int, int>> robotlarinBaslangicPozisyonlari = new List<Tuple<int, int>>
            {
            Tuple.Create(0, 0),
            Tuple.Create(2, 2),
            Tuple.Create(3, 3)
            };

            // Kurtarilan toplam dugum sayisini yazdirma
            int toplamKurtarilanDugum = KurtarilanDugumSayisiniHesapla(grid, robotlarinBaslangicPozisyonlari, yonler);
            Console.WriteLine("Toplam kurtarılan düğüm sayısı: " + toplamKurtarilanDugum);
            Console.ReadKey();
        }

        // N x N boyutunda rastgele bir labirent oluşturma
        static int[,] GridOlustur(int n)
        {
            Random rand = new Random();
            int[,] grid = new int[n, n];

            // Hücreleri rastgele 0 ya da 1'lerle doldurma
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    // Dongu ile tum degerlere atama yapma
                    grid[i, j] = rand.Next(0, 2);
                }
            }
            // Olusturulan labirenti dondurme
            return grid;
        }

        // Labirenti ekrana yazdirma
        static void GridiYazdir(int[,] grid)
        {
            int n = grid.GetLength(0);
            Console.WriteLine("Girilen boyut carpiminda olusturulan rastgele harita:");
            // Döngü ile tüm satir ve sütunlari yazdirma
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(grid[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        // Kurtarilan toplam dugum sayisini hesaplamak icin olusturulan fonksiyon
        static int KurtarilanDugumSayisiniHesapla(int[,] grid, List<Tuple<int, int>> robotlarinBaslangicPozisyonlari, int[,] yonler)
        {
            // Gerekli degiskenleri tanimlama
            int n = grid.GetLength(0);
            bool[,] ziyaretEdildiMi = new bool[n, n];
            int toplamKurtarilanDugum = 0;

            // Tüm degerler icin kontrol
            foreach (var baslangicPozisyonu in robotlarinBaslangicPozisyonlari)
            {   
                // Robotlarin baslangic pozisyonunu cekme
                int baslangicX = baslangicPozisyonu.Item1;
                int baslangicY = baslangicPozisyonu.Item2;
                int kurtarilanDugum = 0;

                // Robotun başlangic konumunun harita sinirlari icinde oldugunu kontrol etme
                if (baslangicX >= 0 && baslangicX < n && baslangicY >= 0 && baslangicY < n)
                {
                    // Robotun başlangıç konumu 1'se ve daha önce o koordinat ziyaret edilmediyse düğümü kurtar
                    if (grid[baslangicX, baslangicY] == 1 && !ziyaretEdildiMi[baslangicX, baslangicY])
                    {
                        ziyaretEdildiMi[baslangicX, baslangicY] = true;
                        kurtarilanDugum++;
                    }
                }

                // Robotun baslangic konumu komsularini kontrol etme
                for (int i = 0; i < 4; i++)
                {
                    int yeniX = baslangicX + yonler[i, 0];
                    int yeniY = baslangicY + yonler[i, 1];

                    // Komsular harita siniri icindeyse, 1'se ve ziyaret edilmediyse dugumu kurtarma 
                    if (yeniX >= 0 && yeniX < n && yeniY >= 0 && yeniY < n && grid[yeniX, yeniY] == 1 && !ziyaretEdildiMi[yeniX, yeniY])
                    {
                        ziyaretEdildiMi[yeniX, yeniY] = true;
                        kurtarilanDugum++;
                    }
                }

                // Toplam kurtarilan dugumu hesaplama
                toplamKurtarilanDugum += kurtarilanDugum;
            }

            // Kurtarilan dugum sayisini geri döndürme
            return toplamKurtarilanDugum;
        }
    }
}
/*
BU KODDA ÇÖZÜLMESİ İSTENEN PROBLEM:
Bir gün, büyük bir teknoloji şehri olan TechCity büyük bir felaketle karşı karşıya kaldı.
Şehrin merkezindeki büyük bir veri merkezine kötü amaçlı yazılım bulaştı ve tüm
bilgisayarlar ve sistemler tehlikeye girdi.Eğer bu yazılım durdurulamazsa, şehir tamamen
çökecek ve insanlar dijital kimliklerini kaybedecekler.TechCity'nin merkezindeki
mühendisler, durumu kurtarmak için çok hızlı düşünmek zorundalar.Şehrin veri
merkezindeki bilgisayar ağı, bir N x N boyutunda bir grid ile temsil ediliyor.Bu grid,
birbirine bağlı bilgisayar düğümlerinden oluşuyor ve bazı düğümler zarar görmüş
durumda.Şehir, 3 robot kullanarak zararı durdurmaya çalışacak.Ancak robotlar
birbirlerinden bağımsız çalışıyor ve aynı anda birden fazla düğüme müdahale
edebiliyorlar.Robotlar bir kez çalışmaya başladıklarında, zarar görmemiş bir düğüme
geçiş yapabiliyorlar ve komşu düğümlere (yukarı, aşağı, sağ, sol) müdahale edebiliyorlar.
Amaç, robotların şehirdeki en fazla düğümü kurtarmasıdır. Ancak robotlar aynı düğüme
birden fazla kez müdahale edemez.Her robot yalnızca bir düğüme bir kez müdahale
edebilir ve komşu düğümlere geçebilir.
Görev: Bir N x N boyutundaki grid'i (haritayı) ve robotların başlangıç noktalarını temsil
eden bir listeyi giriş olarak alan bir fonksiyon yazın.Bu fonksiyon, robotların kaç tane
düğümü kurtarabileceğini hesaplamalıdır.
*/

/*
BAZI KAVRAMLARIN AÇIKLAMALARI: 
List<T>: Bir türden öğeleri tutan dinamik bir koleksiyondur.
foreach: Bir koleksiyonun elemanlarını sırayla gezmeye yarar.
var: Değişken türünü derleyicinin otomatik belirlemesine izin verir.
Tuple: Birden fazla değeri bir arada tutan bir yapıdır, Item1, Item2 gibi elemanlarla içindeki değerlere erişilir.
Tuple.Create: Birden fazla değeri bir Tuple içinde hızlı bir şekilde birleştirmenize ve bu değerlere kolayca erişmenize yardımcı olan bir metottur.
*/
