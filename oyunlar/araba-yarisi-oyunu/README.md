# 🏎️ Araba Yarışı Oyunu (Car Race Game)

Bu proje, C# Form App kullanılarak geliştirilmiş, retro tarzda bir sonsuz sürüş ve kaçış oyunudur. Oyuncunun amacı, akan trafikte diğer araçlara çarpmadan en yüksek skoru elde etmektir.



## 🎮 Oyunun Amacı ve Oynanış
Oyunda oyuncu, yolun alt kısmında bulunan aracını kontrol eder. Yukarıdan aşağıya doğru gelen trafikten sıyrılmalı ve hayatta kaldığı her saniye için skorunu artırmalıdır.

- **Hareket:** Klavyedeki **Sol Ok (←)** ve **Sağ Ok (→)** tuşları ile aracınızı yönlendirebilirsiniz.
- **Zorluk:** Skor arttıkça hem yolun akış hızı hem de rakip araçların hızı dinamik olarak artar.
- **Ödüller:** Belirli skor eşiklerini geçtiğinizde Bronz, Gümüş ve Altın madalyalar kazanırsınız.

## 🛠️ Teknik Özellikler ve Kod Yapısı
Bu uygulama, Windows Forms kütüphanesinin sunduğu olay tabanlı (event-driven) programlama prensipleriyle yazılmıştır.

- **Oyun Döngüsü (Game Loop):** `Timer` nesnesi (`oyunZamanlayicisi`) kullanılarak her tikte (tick) ekran güncellenir.
- **Çarpışma Algılama (Collision Detection):** `.Bounds.IntersectsWith()` metodu kullanılarak oyuncunun diğer araçlarla temas edip etmediği kontrol edilir.
- **Dinamik Nesne Yönetimi:** Rakip araçlar (`BotDegistirme` metodu) ekranın altına ulaştığında rastgele görseller (Ambulans, Kamyon, Yeşil Araba vb.) ve rastgele şerit konumları ile tekrar ekranın tepesine gönderilir.
- **Hız Optimizasyonu:** Skora bağlı olarak `yolHizi` ve `trafikHizi` değişkenleri güncellenerek oyunun akıcılığı korunur.



## 📂 Dosya Yapısı
- **Form1.cs:** Oyunun tüm mantığını, hareket kontrollerini ve çarpışma algoritmalarını barındıran ana dosya.
- **Resources:** Araba görselleri (Ambulans, kamyonlar, farklı renkli arabalar), patlama efekti ve çarpışma ses dosyasını (`hit.wav`) içerir.

## 🚀 Nasıl Çalıştırılır?
1. `ArabaYarisi.sln` dosyasını Visual Studio ile açın.
2. `Properties.Resources` altındaki görsel ve ses dosyalarının eksiksiz olduğundan emin olun.
3. Projeyi derleyip (F5) yarışa başlayın!

---
*Not: Bu oyun, C# ile nesne hareketi ve basit oyun fiziği mantığını anlamak için geliştirilmiş bir eğitim materyalidir.*
