# 🧭 Temel Algoritmalar ve Macera Senaryoları

Bu klasör, karmaşık problemleri çözmek için kullanılan temel bilgisayar bilimi algoritmalarını (Arama, Gezinme, Şifreleme, Dinamik Programlama) sürükleyici hikayeler üzerinden sunar. Her bir proje, belirli bir algoritma mantığını pekiştirmek için tasarlanmıştır.



## 📂 Macera Haritası ve Algoritmalar

| Proje Adı | Algoritma / Teknik | Senaryo Özeti |
| :--- | :--- | :--- |
| **Altin-Tapinak** | **BFS (Breadth-First Search)** | N x N boyutundaki tuzaklarla dolu bir labirentte hazineye giden en kısa yolu bulma. |
| **Labirent-Zarva** | **DFS & Backtracking** | Özel kapı açma koşullarına (asal sayı vb.) sahip bir labirentten çıkış stratejisi. |
| **Fibonacci-Sifreleme** | **Fibonacci & ASCII** | Karakterlerin pozisyonlarına göre Fibonacci serisi kullanarak mesaj şifreleme ve çözme. |
| **Tapinak-Kapisi** | **Recursive Backtracking** | Verilen sayılar ve operatörlerle pozitif sonuçlar üreten tüm geçerli matematiksel ifadeleri bulma. |
| **Tech-City** | **Grid Traversal** | Bir veri merkezindeki bilgisayar ağında robotlar aracılığıyla kurtarılabilecek maksimum düğüm sayısını hesaplama. |
| **Uzay-Madeni** | **Dynamic Programming** | Minimum enerji harcayarak bir grid üzerinde hedefe ulaşma (Pathfinding). |
| **Zaman-Makinesi** | **Logical Date Processing** | Belirli matematiksel kurallara (asal gün, rakam toplamı vb.) uyan gelecekteki tarihleri hesaplama. |

## 🛠️ Teknik Kazanımlar

- **Yol Bulma (Pathfinding):** BFS ile en kısa yol garantisi ve DFS ile labirent tarama mantığı.
- **Dinamik Programlama:** `Uzay-Madeni` örneğinde görüldüğü gibi, karmaşık alt problemleri hafızaya alarak (memoization) enerji optimizasyonu sağlama.
- **Geri İzleme (Backtracking):** Tüm olasılıkları deneyip yanlış yollardan geri dönerek (`Tapinak-Kapisi`) çözüm kümesi oluşturma.
- **Veri Yapıları:** `Queue`, `Stack`, `List<T>` ve `Tuple` yapılarının algoritma akışındaki kritik rolleri.

## 🚀 Nasıl Çalıştırılır?
Her klasör bağımsız bir C# konsol projesidir. İlgili dizine girerek `dotnet run` komutu ile senaryolara dahil olabilir ve algoritma çıktılarını izleyebilirsiniz.
