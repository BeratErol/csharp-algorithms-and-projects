# 🏎️ Araba Yarışı Oyunu (C# Windows Forms)

Bu proje, **C# Windows Forms** kullanılarak geliştirilmiş, retro tarzda bir **sonsuz sürüş (endless runner)** ve **kaçış (dodge)** oyunudur. Oyuncunun amacı, yoğun akan trafikte diğer araçlara çarpmadan mümkün olduğunca uzun süre hayatta kalmak ve en yüksek skoru elde etmektir.

Oyun; **timer tabanlı game loop**, **klavye olay yönetimi**, **çarpışma algılama**, **dinamik zorluk ayarlama** ve **rastgele nesne üretimi** gibi temel oyun geliştirme kavramlarını öğretici bir örnek üzerinden sunar.

---

## 🎮 Oyunun Amacı ve Oynanış

Oyuncu, ekranın alt kısmında bulunan kendi aracını kontrol eder. Yukarıdan aşağıya doğru akan trafikten kaçınarak yol üzerinde ilerler.

* **Hareket:**

  * Klavyedeki **Sol Ok (←)** ve **Sağ Ok (→)** tuşları ile araç yönlendirilir.

* **Hayatta Kalma:**

  * Oyuncu, rakip araçlara çarpmadan ne kadar uzun süre dayanırsa o kadar yüksek skor elde eder.

* **Zorluk:**

  * Skor arttıkça yolun akış hızı ve rakip araçların hızı **dinamik olarak artırılır**.

* **Ödüller:**

  * Belirli skor eşiklerinde oyuncuya **Bronz, Gümüş ve Altın** madalyalar verilir.

---

## 🧠 Oyun Akışı (Game Flow)

1. Oyun başlatıldığında zamanlayıcı (`oyunZamanlayicisi`) aktif edilir.
2. Her `Tick`’te:

   * Oyuncu aracı hareket ettirilir
   * Yol animasyonu güncellenir
   * Rakip araçlar aşağı doğru kaydırılır
   * Çarpışma kontrolü yapılır
   * Skor ve zorluk seviyesi güncellenir
3. Çarpışma gerçekleşirse oyun durur ve sonuç ekranı gösterilir.

---

## 🛠️ Teknik Özellikler ve Kod Yapısı

### 1️⃣ Oyun Döngüsü (Timer Tabanlı Game Loop)

Oyun, Windows Forms’un **Timer** bileşeni ile sürekli güncellenir:

* Yol animasyonu
* Trafik akışı
* Skor artışı
* Çarpışma denetimi

Bu yapı, klasik **game loop** mantığının WinForms üzerindeki sade bir uygulamasıdır.

---

### 2️⃣ Klavye Olay Yönetimi (Input Handling)

Oyuncu hareketleri klavye olayları ile kontrol edilir:

* `KeyDown` → Hareket başlatılır
* `KeyUp` → Hareket durdurulur

```csharp
if (e.KeyCode == Keys.Left) solaGit = true;
if (e.KeyCode == Keys.Right) sagaGit = true;
```

Bu yöntem ile:

* Akıcı ve gecikmesiz kontrol
* Sürekli basılı tutma desteği

sağlanır.

---

### 3️⃣ Yol Animasyonu (Scrolling Background)

Yol, iki ayrı `PictureBox` kullanılarak sürekli akan bir zemin efekti oluşturur:

* Yol aşağı doğru hareket eder
* Ekranın dışına çıkan yol tekrar yukarı alınır

Bu teknik, **sonsuz yol hissi** oluşturmak için sıkça kullanılan bir yaklaşımdır.

---

### 4️⃣ Rakip Araç Yönetimi (Dynamic Traffic System)

Rakip araçlar:

* Ekranın altına ulaştığında yeniden konumlandırılır
* Rastgele bir görsel ile güncellenir
* Rastgele şeritlere yerleştirilir

```csharp
BotDegistirme(Bot1);
```

Bu sayede:

* Oyun tekrar etmez
* Trafik sürekli değişken kalır

---

### 5️⃣ Çarpışma Algılama (Collision Detection)

Oyuncunun diğer araçlarla çarpışması şu yöntemle kontrol edilir:

```csharp
oyuncu.Bounds.IntersectsWith(Bot1.Bounds)
```

Çarpışma gerçekleştiğinde:

* Oyun durdurulur
* Patlama animasyonu gösterilir
* Çarpışma sesi çalınır

---

### 6️⃣ Dinamik Zorluk ve Ödül Sistemi

Skora bağlı olarak oyun zorluğu ve ödüller güncellenir:

| Skor Aralığı | Ödül  | Yol Hızı | Trafik Hızı |
| ------------ | ----- | -------- | ----------- |
| 0 – 40       | —     | 12       | 15          |
| 40 – 500     | Bronz | 12       | 15          |
| 500 – 2000   | Gümüş | 20       | 22          |
| 2000+        | Altın | 25       | 27          |

Bu sistem:

* Oyuncuyu motive eder
* Oyunun temposunu kademeli artırır

---

### 7️⃣ Ses ve Görsel Efektler

* Çarpışma anında **patlama animasyonu**
* `hit.wav` ile sesli geri bildirim
* Rastgele araba görselleri

Bu efektler, oyunun **retro arcade** hissini güçlendirir.

---

## 📂 Dosya Yapısı

* **Form1.cs**

  * Oyun döngüsü
  * Hareket kontrolleri
  * Çarpışma algoritmaları
  * Skor ve zorluk yönetimi

* **Resources**

  * Araç görselleri (Ambulans, Kamyon, farklı renkli arabalar)
  * Patlama animasyonu
  * Çarpışma sesi (`hit.wav`)

---

## 🚀 Nasıl Çalıştırılır?

1. `ArabaYarisi.sln` dosyasını Visual Studio ile açın
2. `Properties.Resources` altında görsel ve ses dosyalarının eksiksiz olduğundan emin olun
3. Projeyi **Build** edin ve **F5** ile çalıştırın
4. Ok tuşlarını kullanarak trafikten kaçınmaya başlayın 🏁

---

## 🎯 Projenin Amacı

Bu proje;

* C# WinForms ile basit oyun geliştirme
* Timer tabanlı game loop mantığı
* Çarpışma algılama ve input yönetimi
* Dinamik zorluk ve ödül sistemi tasarlama

konularını öğrenmek ve pekiştirmek amacıyla geliştirilmiş bir **eğitim projesidir**.

---

**Güvenli sürüşler ve bol şans! 🏎️🎮**
