# 💣 Mayın Tarlası Oyunu (C# Form App)

Bu proje, klasik "Minesweeper" oyununun C# Windows Forms kullanılarak geliştirilmiş modern bir versiyonudur. Proje, dinamik kontrol (kontrol) oluşturma, matris navigasyonu ve yayılma algoritmalarını temel alır.



## 🎮 Oyunun Kuralları ve Mekanikleri

- **Sol Tık:** Hücreyi açar. Eğer hücrede mayın varsa oyun biter.
- **Sağ Tık:** Hücreye "X" işareti (bayrak) koyar veya kaldırır.
- **Sayılar:** Açılan bir hücredeki sayı, o hücrenin etrafındaki (8 komşu) toplam mayın sayısını gösterir.
- **Kazanma:** Mayın olmayan tüm hücreler açıldığında oyun kazanılır.

## 🛠️ Teknik Özellikler ve Algoritmalar

Bu oyunun arka planında çalışan temel yazılım teknikleri şunlardır:

### 1. Dinamik Kontrol Oluşturma
Butonlar tasarım anında değil, çalışma anında (runtime) `panel1` genişliği ve yüksekliğine göre döngüyle oluşturulur. Bu, oyunun farklı grid boyutlarına kolayca uyarlanabilmesini sağlar.

### 2. Otomatik Alan Açma (Flood Fill Mantığı)
Bir hücreye tıklandığında, eğer etrafında hiç mayın yoksa (`etrafMayınSayısı == 0`), oyun otomatik olarak komşu hücreleri de tıklar. Bu işlem, etrafında mayın olan bir hücreye rastlayana kadar devam eder:
```csharp
if (etrafMayınSayısı == 0) 
{
    // Komşu butonları otomatik olarak tıklar (Rekürsif yayılım)
    komsuButon.PerformClick(); 
}
