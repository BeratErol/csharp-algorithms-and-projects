# 💣 Mayın Tarlası Oyunu (Minesweeper)

Bu proje, klasik **Minesweeper (Mayın Tarlası)** oyununun **C# Windows Forms** kullanılarak geliştirilmiş, algoritma ve mantık ağırlıklı modern bir masaüstü uygulamasıdır. Proje özellikle **dinamik kontrol oluşturma**, **matris tabanlı gezinme**, **komşuluk hesaplama** ve **Flood Fill (yayılma)** algoritmalarını öğretici bir örnek üzerinden ele alır.

---

## 🎮 Oyunun Kuralları ve Mekanikleri

* **Sol Tık:**

  * Hücreyi açar.
  * Eğer hücrede mayın varsa oyun kaybedilir.

* **Sağ Tık:**

  * Hücreye **"X" (bayrak)** koyar veya kaldırır.
  * Oyuncunun şüpheli hücreleri işaretlemesini sağlar.

* **Sayılar:**

  * Açılan bir hücrede görünen sayı, o hücrenin etrafındaki **8 komşu hücrede bulunan toplam mayın sayısını** ifade eder.

* **Kazanma:**

  * Mayın olmayan **tüm hücreler açıldığında** oyun kazanılır.

---

## 🧠 Oyun Mantığı ve Akış

1. Form açıldığında oyun alanı **dinamik olarak** oluşturulur.
2. Mayınlar rastgele ancak kontrollü bir şekilde yerleştirilir.
3. Oyuncu hücrelere sol veya sağ tık ile etkileşim kurar.
4. Her hamlede:

   * Kazanma durumu
   * Kaybetme durumu
   * Yayılma (flood fill)
     kontrol edilir.
5. Oyun bittiğinde otomatik olarak **yeniden başlatılır**.

---

## 🛠️ Teknik Özellikler ve Kullanılan Algoritmalar

### 1️⃣ Dinamik Kontrol (Button) Oluşturma

Oyun alanındaki butonlar tasarım zamanında değil, **çalışma anında (runtime)** oluşturulur. `panel1` boyutları baz alınarak 25x25 piksel ölçülerinde bir grid elde edilir:

* Esnek grid yapısı
* Farklı alan boyutlarına kolay uyarlanabilirlik
* Kod tekrarının önlenmesi

Bu yapı sayesinde oyun, klasik sabit tasarımlara kıyasla daha **ölçeklenebilir** bir mimariye sahiptir.

---

### 2️⃣ Rastgele ve Kontrollü Mayın Yerleştirme

* Toplam mayın sayısı: **80**
* Her buton oluşturulurken belirli bir olasılıkla mayın yerleştirilir
* Mayın konumları `HashSet<Point>` içinde saklanır

```csharp
HashSet<Point> mayınlar = new HashSet<Point>();
```

`HashSet` kullanımı sayesinde:

* Aynı noktaya tekrar mayın eklenmesi engellenir
* Konum kontrolü yüksek performansla yapılır

---

### 3️⃣ İlk Tıklama Güvenliği

Oyuncunun ilk hamlede oyunu kaybetmemesi için özel bir kontrol uygulanır:

* Eğer **ilk tıklanan hücre mayın ise**, bu hücre mayından arındırılır
* Böylece kullanıcı deneyimi iyileştirilir

Bu yaklaşım, modern Minesweeper oyunlarında da kullanılan **adil oyun** prensibidir.

---

### 4️⃣ Komşu Hücre Analizi (8-Yönlü Kontrol)

Her hücre için etrafındaki 8 komşu hücre kontrol edilir:

* Üst, alt, sağ, sol
* 4 çapraz yön

```csharp
int[] komsuX = { -25, 0, 25 };
int[] komsuY = { -25, 0, 25 };
```

Bu yöntem ile grid, matematiksel olarak **iki boyutlu matris** gibi ele alınır.

---

### 5️⃣ Otomatik Alan Açma (Flood Fill / Yayılma Algoritması)

Bir hücrenin etrafında hiç mayın yoksa (`etrafMayınSayısı == 0`):

* Komşu hücreler otomatik olarak açılır
* Bu işlem rekürsif şekilde devam eder

```csharp
if (etrafMayınSayısı == 0)
{
    komsuButon.PerformClick();
}
```

Bu mekanizma:

* Oyun alanının büyük bölümlerini tek hamlede açar
* Flood Fill algoritmasının pratik bir uygulamasıdır

---

### 6️⃣ Durum Takibi ve Oyun Sonu Kontrolleri

* Açılan güvenli hücre sayısı `mayınYok` ile takip edilir
* Toplam hücre sayısından mayınlar çıkarılarak **kazanma koşulu** hesaplanır

```csharp
if (mayınYok == 400 - yerleştirilenMayın)
```

* Mayına basıldığında tüm mayınlar görünür hale getirilir

---

### 7️⃣ Zaman Takibi (Timer Kullanımı)

* `Timer` bileşeni ile geçen süre saniye bazında ölçülür
* Süre, kullanıcı arayüzünde canlı olarak gösterilir

Bu özellik oyuna:

* Rekabet hissi
* Performans ölçümü

katar.

---

## 🎨 Görsel ve Kullanıcı Deneyimi

* Satranç tahtası benzeri **iki tonlu arka plan**
* Açılan hücreler için pasif gri renk
* Bayrak (X) ile işaretleme desteği
* Fare imleci geri bildirimi (`Cursor.Hand`)

---

## 📂 Dosya Yapısı

* **Form1.cs**

  * Oyun alanı oluşturma
  * Mayın yerleştirme algoritması
  * Komşuluk ve flood fill mantığı
  * Kazanma / kaybetme kontrolleri
  * Oyun sıfırlama işlemleri

* **UI Bileşenleri**

  * Panel (oyun alanı)
  * Label (süre, kalan hücre, toplam mayın)

---

## 🚀 Nasıl Çalıştırılır?

1. Visual Studio ile projeyi açın
2. Projeyi **Build** edin
3. **Run** ile uygulamayı başlatın
4. Mayınlara dikkat ederek tüm güvenli alanları açmaya çalışın 💥

---

## 🎯 Projenin Amacı

Bu proje;

* C# WinForms event mantığını kavramak
* Flood Fill ve komşuluk algoritmalarını uygulamak
* Dinamik UI üretimini öğrenmek
* Oyun mantığı geliştirme pratiği kazanmak

amacıyla geliştirilmiştir.

---

**İyi eğlenceler ve bol şans! 💣🎮**
