# 🐦 Flappy Bird Oyunu (C# Form App)

Bu proje, popüler "Flappy Bird" oyununun C# Windows Forms kullanılarak geliştirilmiş bir versiyonudur. Temel 2D oyun fiziği, yer çekimi simülasyonu ve sonsuz döngü mantığını içerir.



## 🕹️ Oyun Mekanikleri ve Kontroller

- **Kontrol:** Kuşu yukarı zıplatmak için **Boşluk (Space)** tuşunu kullanın.
- **Yer Çekimi:** Tuşa basılmadığında kuş, `gravity` değişkeni ile belirlenen hızda aşağı doğru düşer.
- **Engel Geçişi:** Borular (`pipeUp` ve `pipeDown`) sağdan sola doğru `pipeSpeed` hızında hareket eder. Ekrandan çıkan borular sağ tarafta yeniden konumlandırılarak sonsuz bir akış sağlanır.
- **Puanlama:** Her başarılı boru geçişinde skorunuz artar.

## 🛠️ Teknik Detaylar

Kod içerisinde kullanılan temel programlama mantıkları şunlardır:

### 1. Yer Çekimi Simülasyonu
Kuşun dikey hareketi `bird.Top += gravity;` kodu ile kontrol edilir. Boşluk tuşuna basıldığında `gravity` değeri negatif yapılır (`-17`), bırakıldığında ise tekrar pozitif (`5`) değere çekilerek zıplama etkisi yaratılır.

### 2. Dinamik Zorluk Seviyesi
Oyun, oyuncunun skoruna göre otomatik olarak hızlanır. Bu, rekabet hissini artırmak için tasarlanmış bir "Difficulty Scaling" örneğidir:
- **Skor > 5:** Hız 10
- **Skor > 20:** Hız 13
- **Skor > 100:** Hız 20 (Maksimum Zorluk)

### 3. Çarpışma Denetimi (Collision Detection)
`IntersectsWith` metodu kullanılarak kuşun borulara, zemine (`ground`) veya gökyüzü sınırına çarpıp çarpmadığı anlık olarak kontrol edilir:
```csharp
if (bird.Bounds.IntersectsWith(pipeDown.Bounds) || bird.Top < -25)
{
    endGame(); // Oyun biter
}
