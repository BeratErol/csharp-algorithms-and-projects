# 📐 UML Tasarımları ve Mimari Modelleme

Bu klasör, karmaşık sistemlerin yazılım mimarilerini ve sınıflar arası ilişkilerini **Nesne Tabanlı Programlama (OOP)** prensipleri doğrultusunda modelleyen projeleri barındırır.  

Her proje, belirli bir iş senaryosunun (Üniversite Yönetimi, Evcil Hayvan Takibi, Araç Kiralama) **C# dili** kullanılarak nasıl somutlaştırıldığını ve **UML standartlarına** nasıl uyarlandığını göstermektedir.

---

## 📂 Modelleme Projeleri

Aşağıdaki tabloda, bu klasörde bulunan sistemlerin odaklandığı temel OOP kavramları özetlenmiştir:

| Proje Adı | Odak Noktası | Temel OOP Kavramları |
|---------|-------------|----------------------|
| **universite-yonetim-sistemi** | Akademik Hiyerarşi | Soyutlama (Abstraction), Kalıtım (Inheritance), Bire-Çok İlişkiler |
| **evcil-hayvan-yonetim-sistemi** | Sağlık ve Kimlik Takibi | Arayüzler (Interface), Bileşim (Composition), Kapsülleme (Encapsulation) |
| **arac-kiralama-sistemi** | Operasyonel İş Akışı | Olay Yönetimi (Event Handling), İlişkilendirme (Association) |

---

## 🛠️ Uygulanan Yazılım Mimarisi Prensipleri

Tüm tasarımlarda aşağıdaki mimari ve yazılım mühendisliği standartları gözetilmiştir:

### 1. Sınıf İlişkileri (Class Relationships)
- Sınıflar arası **bağımlılık seviyesi (Coupling)** kontrol altında tutulmuştur.
- Senaryoya göre:
  - **Kalıtım (Is-a)**
  - **Bileşim (Has-a)**
  - **İlişkilendirme (Association)**
  
  ilişkileri doğru şekilde modellenmiştir.

### 2. Arayüzler ve Sözleşmeler (Interfaces)
- `IKimlikli`, `IDeneyimli` gibi arayüzler kullanılarak:
  - Ortak davranışlar standartlaştırılmış
  - Kodun esnekliği ve yeniden kullanılabilirliği artırılmıştır.

### 3. Bakım ve Genişletilebilirlik
- `Guncelle`, `Onayla`, `Besle` gibi dinamik metotlar sayesinde:
  - Sistem çekirdeği bozulmadan yeni özellikler eklenebilir
  - Modüler ve sürdürülebilir bir yapı sağlanmıştır.

---

## 🚀 Öğrenim Çıktıları

Bu klasördeki UML ve mimari tasarımlar incelendiğinde şu kazanımlar elde edilir:

- Gerçek dünya nesnelerinin sınıflara dönüştürülmesi
- Soyut (`abstract`) sınıfların doğru kullanım senaryoları
- Kapsülleme (Encapsulation) ile veri güvenliği
- `Guid` gibi benzersiz kimlik yapılarıyla nesne takibi
- UML diyagramlarının kod ile birebir eşleştirilmesi

---

## ℹ️ Not

Her projenin **detaylı teknik analizi, UML diyagramları ve açıklamaları**, ilgili projenin kendi klasörü içerisinde bulunan özel **README.md** dosyalarında yer almaktadır.
