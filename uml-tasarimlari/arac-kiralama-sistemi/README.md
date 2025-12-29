# 🚗 Araç Kiralama Sistemi (UML Modelleme)

Bu proje, bir araç kiralama platformunun iş akışını Nesne Tabanlı Programlama (OOP) prensipleriyle modelleyen teknik bir çalışmadır. Sistem; müşteri yönetimi, rezervasyon işlemleri, ödeme takibi ve bildirim mekanizmalarını kapsar.



## 🛠️ Mimari Yapı ve OOP İlişkileri

Sistemdeki sınıflar, gerçek bir kiralama operasyonunu simüle etmek için belirli ilişki türleri (Association) ile birbirine bağlanmıştır:

### 1. Bire-Çok İlişkisi (1..*)
- **İşlem ve Rezervasyon:** Bir `Islem` nesnesi, içerisinde birden fazla `Rezervasyon` barındırabilir. Bu, müşterinin tek bir işlem altında birden fazla araç veya hizmet rezerve edebilmesini sağlar.
- **Müşteri ve Ödeme:** Bir müşteri sistemde birden fazla ödeme kaydına (`List<Odeme>`) sahip olabilir.

### 2. Nesne Etkileşimi (Collaboration)
- **Rezervasyon Onay Mekanizması:** `Rezervasyon.Onayla()` metodu tetiklendiğinde, sadece durumu değiştirmekle kalmaz, aynı zamanda `IlgiliKiralamaSahibi` nesnesine dinamik olarak bildirim gönderir. Bu, sistem içi olay tetikleme (Event triggering) mantığını temsil eder.



### 3. Veri Kapsülleme (Encapsulation)
- `KiralamaSahibi` sınıfında `KullaniciAdi` ve `Sifre` gibi hassas bilgiler `private` olarak tanımlanarak veri gizliliği sağlanmıştır. Kritik işlemler `HesapDogrula()` gibi kontrollü metotlar üzerinden yürütülür.

## 💻 Sistem Yetenekleri

- **Dinamik Ödeme İşleme:** Araç kiralama bedeli, `Arac` sınıfı üzerinden işlenir ve `Musteri` ödeme geçmişine eklenir.
- **Esnek Güncelleme:** `Islem`, `Odeme` ve `Musteri` sınıfları kendi içlerinde `Guncelle()` metotlarına sahiptir, bu da sistemin bakımını (maintainability) kolaylaştırır.
- **Otomatik Bildirim Sistemi:** Rezervasyon onaylandığı anda ilgili kiralama sahibine detaylı bilgi mesajı ulaştırılır.

## 📂 Dosya Yapısı
- **Program.cs:** Araç kiralama akışının (Müşteri oluşturma, araç seçimi, ödeme ve rezervasyon onayı) test edildiği ana kod dosyası.

## 🚀 Nasıl Çalıştırılır?
1. Visual Studio ile projeyi açın.
2. `Program.cs` dosyasını derleyip çalıştırın.
3. Konsol ekranında ödeme ekleme, araç kiralama işlemi ve kiralama sahibine giden onay bildirimini adım adım takip edin.
