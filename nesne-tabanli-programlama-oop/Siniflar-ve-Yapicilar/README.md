# 🏗️ Sınıflar ve Yapıcı Metotlar (Classes & Constructors)

Bu klasör, Nesne Tabanlı Programlama'nın (OOP) temel yapı taşlarını içeren çeşitli gerçek dünya senaryolarını barındırır. Projeler; sınıfların nasıl inşa edildiğini, verilerin nasıl kapsüllendiğini ve nesne oluşturulurken yapıcı metotların (`Constructor`) nasıl kullanıldığını gösterir.

## 📂 İçerik ve Senaryolar

| Dosya Adı | OOP Kavramı | Senaryo Açıklaması |
| :--- | :--- | :--- |
| **BankaHesabiSinifi.cs** | Encapsulation | Bakiyenin sadece sınıf içinden değiştirilebildiği, para yatırma/çekme mantığı. |
| **UrunSinifi.cs** | Validation (Doğrulama) | İndirim oranının 0-50% arasında olmasını zorunlu kılan `Property` kullanımı. |
| **AracKiralamaSinifi.cs** | State Management | Bir aracın plaka ve ücret bilgileriyle beraber müsaitlik durumunun yönetimi. |
| **KutuphaneSinifi.cs** | Collections (List/Dict) | Kütüphaneye kitap ekleme ve dinamik liste üzerinden kitapları listeleme. |
| **AdresDefteriSinifi.cs** | Basic Class Structure | Kişi bilgilerini tutan ve formatlı çıktı veren temel sınıf yapısı. |



## 🛠️ Teknik Kazanımlar
- **Yapıcı Metotlar (Constructors):** Nesne ilk oluşturulduğunda (`new`) başlangıç değerlerinin atanması.
- **Kapsülleme (Encapsulation):** `private set` ve `get` blokları ile veriye erişimin kontrol altına alınması.
- **Hata Yönetimi:** `ArgumentException` kullanarak iş mantığına (Business Logic) aykırı durumların (örn: geçersiz indirim oranı) engellenmesi.
- **this Anahtar Kelimesi:** Sınıf üyeleri ile metot parametreleri arasındaki isim çakışmalarının çözülmesi.

## 🚀 Çalıştırma
`Program.cs` dosyası içerisinde her bir sınıf için hazırlanmış `#region` blokları bulunmaktadır. İncelemek istediğiniz örneğin çıktılarını konsol üzerinden takip edebilirsiniz.
