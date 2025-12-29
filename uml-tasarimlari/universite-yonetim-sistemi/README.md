# 🏛️ Üniversite Yönetim Sistemi (UML Modelleme)

Bu proje, bir üniversite yapısını Nesne Tabanlı Programlama (OOP) prensipleriyle modelleyen teknik bir çalışmadır. Sistem; kişiler, öğrenciler ve profesörler arasındaki hiyerarşik ve ilişkisel bağları C# üzerinden somutlaştırır.

## 🛠️ Uygulanan OOP Kavramları

### 1. Kalıtım ve Polimorfizm (Inheritance & Polymorphism)
- **Kisi:** Üst sınıf (Base Class) olarak ad, telefon ve e-posta gibi temel verileri saklar.
- **Ogrenci & Profesor:** Bu sınıflar `Kisi` sınıfından miras alır. `Ogrenci` sınıfı soyut (`abstract`) tanımlanarak, farklı öğrenci türleri (Lisans, Yüksek Lisans vb.) için bir şablon oluşturulmuştur.

### 2. Sınıf İlişkileri (Association)
- **Composition (Bileşim):** `Adres` sınıfı, `Kisi` sınıfının ayrılmaz bir parçasıdır. Her kişinin bir adresi vardır ve bu adres doğrulanabilir bir nesnedir.
- **Bire-Çok İlişkisi:** Bir profesörün denetlediği öğrencileri tutan bir `List<Ogrenci>` mevcuttur. Kod içerisinde bir profesöre en fazla 5 öğrenci atanabileceğine dair bir iş mantığı (business logic) kurgulanmıştır.



## 💻 Sistem Yetenekleri
- **Adres Doğrulama:** `Adres.Dogrula()` metodu ile sokak ve şehir bilgisinin girilip girilmediği kontrol edilir.
- **Dinamik Kayıt Kontrolü:** `LisansOgrenci.KayitOlabilirMi()` metodu, öğrencinin ortalama notuna göre (Örn: >= 50) kayıt durumunu boolean olarak döndürür.
- **Çift Yönlü Takip:** Hem profesör denetlediği öğrencileri hem de öğrenci kendisini denetleyen profesörleri listeleyebilir.

## 📂 Dosya Yapısı
- **Program.cs:** Sistemin tüm mantığını, sınıfları ve örnek test verilerini içeren konsol uygulaması dosyası.

## 🚀 Nasıl Çalıştırılır?
1. Visual Studio projesini açın.
2. `Program.cs` dosyasını derleyip çalıştırın.
3. Konsol ekranında profesörün öğrenci atamalarını ve adres doğrulama çıktılarını takip edin.
