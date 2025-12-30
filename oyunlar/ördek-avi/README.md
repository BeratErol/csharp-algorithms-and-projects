# 🦆 Ördek Avı Oyunu (AimLab Duck Game)

**Refleks ve hedef alma odaklı masaüstü oyunu**

C# Windows Forms kullanılarak geliştirilmiş, oyuncunun belirli bir süre içinde ekranda rastgele konumlara hareket eden ördeğe tıklayarak en yüksek puanı elde etmeyi amaçladığı bir av simülasyonudur.

---

## 🎯 Oyun Mantığı

- Oyunda **zaman sınırlı** bir av senaryosu bulunur
- Ördek, belirlenen zorluk seviyesine göre ekranda **rastgele konumlara** taşınır
- Oyuncunun performansı şu metriklerle ölçülür:
  - Toplam tıklama sayısı
  - İsabetli tıklama sayısı
  - Toplam puan
- Oyun sonunda detaylı istatistik raporu sunulur

---

## 🕹️ Oynanış Özellikleri

### Zorluk Seviyeleri

| Seviye | Hareket Hızı | Timer Interval |
|--------|--------------|----------------|
| **Kolay** | Yavaş | 700ms |
| **Orta** | Dengeli | 600ms |
| **Zor** | Hızlı | 500ms |

### Puanlama Sistemi

- ✅ Her isabetli ördek tıklaması: **+5 puan**
- 📊 Form üzerine yapılan tüm tıklamalar toplam tıklama olarak sayılır
- 🎯 İsabet oranı hesaplanır: `(İsabetli Tıklama / Toplam Tıklama) × 100`

### Süre Mekaniği

- ⏱️ Geri sayım timer ile kontrol edilir
- ⏰ Süre bittiğinde oyun otomatik olarak sona erer
- 🔄 Oyun sonu ekranından yeniden başlatma imkanı

---

## 🛠️ Teknik Yapı ve Mimari

### Kullanılan Bileşenler

```
┌─────────────────────────────────────┐
│         Form1 (Ana Oyun)            │
├─────────────────────────────────────┤
│ • Timer (Süre Kontrolü)             │
│ • Timer (Ördek Hareketi)            │
│ • PictureBox (Ördek Nesnesi)        │
│ • Panel (Başlangıç Ekranı)          │
│ • Panel (Sonuç Ekranı)              │
│ • RadioButton (Zorluk Seçimi)       │
│ • Label (UI Bilgileri)              │
└─────────────────────────────────────┘
```

### Rastgele Konumlandırma

Ördek, belirli aralıklarla form içerisinde rastgele bir noktaya taşınır:

```csharp
ordek.Location = new Point(rnd.Next(10, 800), rnd.Next(10, 300));
```

### Zorluk Seviyesine Göre Hız Ayarı

```csharp
if (rbtnkolay.Checked)
    timerLoc.Interval = 700;
else if (rbtnorta.Checked)
    timerLoc.Interval = 600;
else if (rbtnzor.Checked)
    timerLoc.Interval = 500;
```

---

## 📊 Oyun Sonu İstatistikleri

Oyun tamamlandığında kullanıcıya sunulan veriler:

- 🎯 **Toplam Tıklama Sayısı** - Formdaki tüm tıklamalar
- ✅ **İsabetli Tıklama Sayısı** - Ördeğe yapılan başarılı tıklamalar
- 🏆 **Toplam Puan** - (İsabetli Tıklama × 5)
- 📈 **İsabet Oranı** - Doğruluk yüzdesi

---

## 🔄 Yeniden Başlatma Mekanizması

Oyun sona erdiğinde:

1. ⏱️ Süre, skor ve sayaçlar sıfırlanır
2. 🎮 Zorluk seviyesi varsayılan olarak "Kolay" seçilir
3. 🦆 Ördek başlangıç konumuna alınır
4. ▶️ Oyun yeniden başlatılabilir hale gelir

---

### Ana Bileşenler

- **Form1.cs** - Oyun döngüsü, sayaçlar, timer yönetimi ve kullanıcı etkileşimleri
- **UI Controls** - Panel, PictureBox, Button, RadioButton ve Label kontrolleri

---

## 🚀 Kurulum ve Çalıştırma

### Gereksinimler

- .NET Framework 4.7.2 veya üzeri
- Visual Studio 2019 veya üzeri (Windows Forms desteği ile)

### Adımlar

1. Projeyi klonlayın veya indirin
2. `DuckHuntGame.sln` dosyasını Visual Studio ile açın
3. F5 tuşuna basarak projeyi derleyin ve çalıştırın

---

## 🎓 Öğrenme Kazanımları

Bu proje aşağıdaki konuları kapsar:

- ⏲️ **Timer Kullanımı** - Zaman tabanlı işlemler
- 🎲 **Random Sınıfı** - Rastgele sayı üretimi
- 🖱️ **Event Handling** - Kullanıcı etkileşimleri (Click, MouseEnter, vb.)
- 🎨 **Windows Forms UI** - Kontrol yönetimi ve düzenleme
- 📊 **Değişken Yönetimi** - Skor, sayaç ve durum takibi
- 🔄 **Game Loop** - Temel oyun döngüsü mantığı

---

## 👨‍💻 Geliştirici Notları

Bu proje, zamanlayıcılar (Timer), rastgelelik (Random), olay tabanlı programlama ve kullanıcı etkileşimi konularını tek bir oyun senaryosu içerisinde birleştiren bir Windows Forms uygulamasıdır.

**Geliştirme Ortamı:** Visual Studio 2022, C# Windows Forms  
**Hedef Framework:** .NET Framework 4.8

---

**🦆 İyi oyunlar! Reflekslerinizi test edin ve yüksek skoru yakalayın!**
