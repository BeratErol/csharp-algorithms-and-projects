# 🧮 Hesap Makinesi Uygulaması

Bu proje, **C# Windows Forms** kullanılarak geliştirilmiş, temel aritmetik işlemleri destekleyen masaüstü bir hesap makinesi uygulamasıdır. Kullanıcı etkileşimleri, olay tabanlı programlama (event-driven) yaklaşımıyla ele alınmış; giriş kontrolü ve işlem yönetimi sade bir mimariyle uygulanmıştır.

## 🚀 Uygulama Özellikleri

* **Temel Aritmetik İşlemler:** Toplama (+), çıkarma (-), çarpma (×) ve bölme (÷)
* **Dinamik Ekran Yönetimi:** Sayı girişlerinde ekranın otomatik temizlenmesi ve doğru biçimde güncellenmesi
* **Durum Takibi:** Seçilen işlem türü ve ilk girilen sayının arka planda saklanması
* **Sıfırlama (Clear):** Tek tuşla ekranı ve giriş durumunu sıfırlama

## 🕹️ Kullanım Mantığı

1. Kullanıcı sayısal butonlarla ilk sayıyı girer.
2. Bir işlem butonu (+, -, ×, ÷) seçilir.
3. İkinci sayı girilir.
4. **Sonuç (=)** butonuna basıldığında işlem gerçekleştirilir ve sonuç ekranda gösterilir.
5. **C (Clear)** butonu ile ekran tekrar `0` değerine döndürülür.

## 🛠️ Teknik Detaylar

### 1. İşlem ve Durum Yönetimi

Uygulama içerisinde üç temel değişken kullanılarak işlem akışı kontrol edilir:

* `_secilenIslem` → Kullanıcının seçtiği matematiksel işlem
* `_ekrandakiIlkSayi` → İşlem öncesi girilen ilk sayı
* `_ekranTemizlensinMi` → Yeni sayı girişinde ekranın temizlenip temizlenmeyeceğini belirler

Bu yapı sayesinde kullanıcı ardışık işlemleri hatasız şekilde gerçekleştirebilir.

### 2. Olay Tabanlı Buton Yönetimi

Her sayısal ve işlem butonu, kendi **Click** olayında ekrana müdahale eder. Sayı butonları ekrana karakter eklerken, işlem butonları mevcut değeri saklayıp yeni giriş için ekranı hazırlar.

### 3. Sonuç Hesaplama Mantığı

`=` butonuna basıldığında seçilen işlem türüne göre uygun matematiksel hesaplama yapılır ve sonuç ekrana yazdırılır.

## 📂 Dosya Yapısı

* **Form1.cs**
  Uygulamanın tüm aritmetik mantığını, buton olaylarını ve ekran kontrolünü içeren ana dosya.

* **UI (Windows Forms)**
  Sayısal tuşlar, işlem butonları ve sonuç ekranı için `Button` ve `Label` bileşenlerinden oluşur.

## ▶️ Çalıştırma

1. Proje klasörünü Visual Studio ile açın.
2. Projeyi derleyin (**F5**).
3. Hesap makinesi arayüzü üzerinden işlemleri gerçekleştirmeye başlayın.

---

Bu uygulama, Windows Forms üzerinde **durum yönetimi**, **olay tabanlı kullanıcı etkileşimi** ve **temel işlem mantığının** sade ve okunabilir bir şekilde uygulanmasını göstermektedir.
