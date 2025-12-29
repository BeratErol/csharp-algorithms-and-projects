# 🎭 Karmaşık Algoritma Senaryoları (Complex Algorithm Scenarios)

Bu klasör, bilgisayar bilimlerinin en temel ve güçlü algoritmalarını (BFS, DFS, Backtracking, Dinamik Programlama) gerçek dünya benzeri oyunlaştırılmış senaryolar üzerinden sunar. Buradaki projeler, standart "temel" seviyenin ötesinde, mantıksal derinlik ve optimizasyon gerektiren zorlayıcı problemlerden oluşmaktadır.



## 📂 Macera Haritası ve Teknik Analiz

| Proje Adı | Uygulanan Algoritma | Teknik Zorluk Derecesi | Senaryo Özeti |
| :--- | :--- | :--- | :--- |
| **Altin-Tapinak** | **BFS (Breadth-First Search)** | ⭐⭐⭐ | N x N boyutundaki bir grid üzerinde engel (duvar) takibi yaparak en kısa yolu bulma. |
| **Labirent-Zarva** | **DFS & Backtracking** | ⭐⭐⭐ | Asal sayı ve matematiksel mod kontrolleri içeren kapılardan geçerek labirentten kurtulma. |
| **Fibonacci-Sifreleme**| **Fibonacci & ASCII Logic** | ⭐⭐ | Mesajın her bir karakterini Fibonacci dizisindeki karşılığına göre şifreleyen/çözen kriptografik yapı. |
| **Tapinak-Kapisi** | **Recursive Backtracking** | ⭐⭐⭐⭐ | Operatör kombinasyonlarını rekürsif olarak deneyerek hedef sonuca ulaşan ifadeleri keşfetme. |
| **Tech-City** | **Grid Traversal (Multi-Robot)** | ⭐⭐⭐ | Bağımsız çalışan birden fazla aktörün (robot) bir ağ üzerinde kesişmeden maksimum alan taraması yapması. |
| **Uzay-Madeni** | **Dynamic Programming** | ⭐⭐⭐⭐⭐ | Bir matris üzerinde minimum maliyetle hedefe ulaşmak için önceki adımların sonuçlarını optimize eden algoritma. |
| **Zaman-Makinesi** | **Complex Logic & Filtering** | ⭐⭐ | Asal sayılar, basamak toplamları ve tarih kütüphanesini harmanlayan gelişmiş filtreleme motoru. |

## 🛠️ Teknik Derinlik ve Kazanımlar

### 1. En Kısa Yol ve Arama (BFS/DFS)
`Altin-Tapinak` ve `Labirent-Zarva` projeleri, graf teorisindeki arama yöntemlerini bir grid (matris) üzerinde uygular. BFS ile en kısa yol garantisi verilirken, DFS ile olası tüm yollar taranır.



### 2. Dinamik Programlama (DP)
`Uzay-Madeni` projesi, bir problemin en iyi çözümünü bulmak için (minimum enerji) alt problemlerin sonuçlarını kullanan klasik bir DP uygulamasıdır. Bu yöntem, kaba kuvvet (brute-force) yaklaşımlarına göre devasa performans artışı sağlar.

### 3. Geri İzleme (Backtracking)
`Tapinak-Kapisi` örneğinde olduğu gibi, doğru çözüme giden yolda yanlış bir adım atıldığında geri dönüp farklı olasılıkları deneyen bu teknik, yapay zeka ve oyun teorisinin temelidir.

## 🚀 Çalıştırma Rehberi
Her bir klasör bağımsız bir C# konsol uygulamasıdır. Terminalinizde klasörün içine girdikten sonra aşağıdaki komutla senaryoları test edebilirsiniz:

```bash
dotnet run
