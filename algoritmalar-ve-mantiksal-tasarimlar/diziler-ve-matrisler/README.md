# 📊 Diziler ve Matris Yapıları

Bu dizin, C# dilinde tek boyutlu diziler (Arrays) ve çok boyutlu matrisler (Matrices) üzerinde veri manipülasyonu, istatistiksel hesaplama ve arama algoritmalarını içeren projeleri barındırır.



## 📂 Proje Listesi ve Teknik İçerik

| Proje Adı | Veri Yapısı | Temel Algoritma / Teknik |
| :--- | :--- | :--- |
| **Ardisik-Sayi-Gruplayici** | `int[]` | Diziyi sıralama ve ardışık sayı bloklarını tespit etme. |
| **Ortalama-ve-Medyan-Hesabi** | `List<int>` | Dinamik liste yönetimi, aritmetik ortalama ve medyan bulma mantığı. |
| **Siralama-ve-Ikili-Arama** | `int[]` | **Binary Search (İkili Arama)** algoritması ile $O(\log n)$ karmaşıklığında veri bulma. |
| **Matris-Carpimi** | `int[,]` | İki matrisin satır-sütun çarpımı ($n \times n$ matris çarpımı). |
| **Spiral-Matris** | `int[,]` | Matris sınırlarını dinamik yöneterek spiral (saat yönünde) dolgu yapma. |

## 🚀 Öne Çıkan Algoritmalar

### 🧩 Spiral Matris Dolgusu
Matrisin dış sınırlarından başlayarak içe doğru saat yönünde dönen bir döngü ile sayıları yerleştirir. `ust`, `alt`, `sol`, `sag` olmak üzere 4 farklı sınır kontrolü içerir.



### 🔍 İkili Arama (Binary Search)
Sıralanmış bir dizide hedef elemanı bulmak için her adımda arama alanını yarıya indiren verimli bir yöntemdir. Karmaşıklığı $O(\log n)$ olması sebebiyle büyük verilerde çok hızlı sonuç verir.



### 🔢 Matris Çarpımı
İki matrisin çarpılabilmesi için gereken kuralı (birincinin sütun sayısının ikincinin satır sayısına eşitliği) baz alarak $n^3$ karmaşıklığında bir hesaplama motoru sunar.

## 🛠️ Çalıştırma Notları
- **Binary Search** uygulamasının çalışması için dizinin önce `Array.Sort()` ile sıralanması zorunludur.
- **Spiral Matris** uygulaması, matris boyutuna göre (`n`) çıktıların okunabilirliğini artırmak için dinamik boşluklandırma (padding) yapar.
