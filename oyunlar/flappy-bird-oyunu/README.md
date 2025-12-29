# 🐦 Flappy Bird Oyunu (C# Windows Forms)

Bu proje, popüler **Flappy Bird** oyununun **C# Windows Forms** kullanılarak geliştirilmiş bir masaüstü versiyonudur. Proje; **temel 2D oyun fiziği**, **yer çekimi simülasyonu**, **sonsuz engel döngüsü** ve **çarpışma denetimi** gibi oyun geliştirme kavramlarını sade ve anlaşılır bir yapı ile sunar.

---

## 🕹️ Oyun Mekanikleri ve Kontroller

* **Kontrol:**

  * Kuşu yukarı zıplatmak için **Boşluk (Space)** tuşunu kullanın.

* **Yer Çekimi:**

  * Tuşa basılmadığında kuş, `gravity` değişkeni ile belirlenen hızda aşağı doğru düşer.
  * Boşluk tuşuna basıldığında yer çekimi tersine çevrilir ve zıplama efekti oluşur.

* **Engel Geçişi:**

  * Borular (`pipeUp`, `pipeDown`) sağdan sola doğru hareket eder.
  * Ekranın dışına çıkan borular sağ tarafta yeniden konumlandırılarak **sonsuz oyun döngüsü** sağlanır.

* **Puanlama:**

  * Her başarılı boru geçişinde skor **1 artar**.

* **Oyun Sonu:**

  * Kuş herhangi bir boruya, zemine veya ekranın üst sınırına çarptığında oyun sona erer.

---

## 🧠 Oyun Akışı

1. Oyun `Timer` ile sürekli güncellenir.
2. Her zaman adımında kuşun konumu ve boruların hareketi hesaplanır.
3. Çarpışma kontrolü yapılır.
4. Skora bağlı olarak oyun zorluğu dinamik şekilde artırılır.
5. Oyun bittiğinde kullanıcıya yeniden oynama seçeneği sunulur.

---

## 🛠️ Teknik Detaylar ve Algoritmalar

### 1️⃣ Yer Çekimi (Gravity) Simülasyonu

Kuşun dikey hareketi aşağıdaki satır ile kontrol edilir:

```csharp
bird.Top += gravity;
```

* Varsayılan durumda `gravity = 5` → Kuş aşağı düşer
* Boşluk tuşuna basıldığında `gravity = -17` → Kuş yukarı zıplar

Bu yöntem ile basit ama etkili bir **fizik simülasyonu** sağlanır.

---

### 2️⃣ Sonsuz Engel Döngüsü (Infinite Loop Mantığı)

Borular ekranın solundan çıktığında sağ tarafa yeniden yerleştirilir:

```csharp
if (pipeDown.Left < -150)
{
    pipeDown.Left = 600;
    score++;
}
```

Bu yapı sayesinde:

* Sürekli yeni engel üretmeye gerek kalmaz
* Performans korunur
* Oyun akışı kesintisiz devam eder

---

### 3️⃣ Dinamik Zorluk Seviyesi (Difficulty Scaling)

Oyuncunun skoruna göre boru hızı otomatik olarak artırılır:

| Skor Aralığı | Boru Hızı |
| ------------ | --------- |
| 0 – 5        | 7         |
| 6 – 20       | 10        |
| 21 – 50      | 13        |
| 51 – 100     | 16        |
| 100+         | 20 (Max)  |

Bu yaklaşım:

* Oyunu monotonluktan kurtarır
* Rekabet ve refleks ihtiyacını artırır

---

### 4️⃣ Çarpışma Denetimi (Collision Detection)

`IntersectsWith` metodu kullanılarak kuşun çevresel nesnelerle çarpışması kontrol edilir:

```csharp
if (bird.Bounds.IntersectsWith(pipeDown.Bounds) || bird.Top < -25)
{
    endGame();
}
```

Kontrol edilen çarpışmalar:

* Alt borular
* Üst borular
* Zemin (ground)
* Ekranın üst sınırı

---

### 5️⃣ Klavye Olay Yönetimi

* **KeyDown:** Zıplama başlatılır
* **KeyUp:** Yer çekimi tekrar aktif edilir

Bu yöntem ile:

* Akıcı kontrol hissi sağlanır
* Gerçek zamanlı input işleme pratiği kazanılır

---

### 6️⃣ Oyun Sonu ve Yeniden Başlatma Mekanizması

Oyun bittiğinde:

* Timer durdurulur
* Kullanıcıya skor ile birlikte bir mesaj gösterilir
* Tekrar oynamak isterse tüm oyun durumu sıfırlanır

Sıfırlanan bileşenler:

* Kuş pozisyonu
* Boru konumları
* Skor
* Hız ve yer çekimi değerleri

---

## 🎨 Görsel ve Kullanıcı Deneyimi

* Akıcı animasyon hissi
* Anlık skor güncellemesi
* Basit ve dikkat dağıtmayan arayüz
* Klavye tabanlı hızlı kontrol

---

## 📂 Dosya Yapısı

* **Form1.cs**

  * Oyun döngüsü (`Timer`)
  * Yer çekimi ve hareket hesapları
  * Çarpışma kontrolü
  * Skor ve zorluk yönetimi
  * Oyun sıfırlama mantığı

* **UI Bileşenleri**

  * PictureBox (kuş, borular, zemin)
  * Label (skor)
  * Timer

---

## 🚀 Nasıl Çalıştırılır?

1. Visual Studio ile projeyi açın
2. Projeyi **Build** edin
3. **Run** ile oyunu başlatın
4. Boşluk tuşu ile kuşu kontrol ederek engellerden kaçının 🐦

---

## 🎯 Projenin Amacı

Bu proje;

* C# WinForms ile basit 2D oyun geliştirmeyi öğrenmek
* Timer tabanlı oyun döngüsünü kavramak
* Fizik ve çarpışma mantığını uygulamak
* Oyun zorluk ölçeklendirmesi tasarlamak

amacıyla geliştirilmiştir.

---

**İyi uçuşlar ve bol şans! 🐦🎮**
