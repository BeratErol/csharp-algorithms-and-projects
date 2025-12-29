# 🛒 Market Yönetim Sistemi (OOP Case Study)

Bu proje, Nesne Tabanlı Programlama'nın (OOP) dört temel ilkesini gerçek dünya senaryosu üzerinde harmanlayan kapsamlı bir yönetim simülasyonudur. Sistem; müşteri yönetimi, ürün kataloglama, sepet işlemleri, indirim motoru ve polimorfik ödeme yöntemlerini içerir.



## 🏗️ Mimari Yapı ve OOP Kullanımı

### 1. Soyutlama ve Kalıtım (Abstraction & Inheritance)
- **Kişi Yönetimi:** `Kisi` soyut sınıfından türetilen `BireyselMusteri` ve `KurumsalMusteri` sınıfları ile müşteri hiyerarşisi kurulmuştur.
- **Ödeme Sistemleri:** `Odeme` soyut sınıfı kullanılarak `KrediKartiOdeme`, `NakitOdeme` ve `HavaleOdeme` yapıları oluşturulmuştur.

### 2. Çok Biçimlilik (Polymorphism)
- Farklı ödeme yöntemleri tek bir `OdemeYap()` metodu üzerinden çağrılır; ancak her sınıf kendi ödeme mantığını (kart no, IBAN vb.) çalıştırır.
- `BilgiYazdir()` metodu, müşterinin türüne göre (TC No veya Vergi No) farklı detaylar döndürür.

### 3. Esnek İndirim Motoru
- `Indirim` soyut sınıfı sayesinde sisteme kolayca `YuzdeIndirim` veya `SabitIndirim` gibi yeni kampanya türleri eklenebilir.

### 4. Durum Yönetimi (Enums)
- `SiparisDurumu` enumu ile siparişin yaşam döngüsü (`Onaylandi`, `Hazirlaniyor`, `TeslimEdildi`) tip güvenli bir şekilde takip edilir.

## 📂 Proje Bileşenleri

| Bileşen | Görev |
| :--- | :--- |
| **MusteriYonetimi** | Müşteri ekleme ve TC/Vergi No/Ad kriterlerine göre akıllı arama. |
| **UrunYonetimi** | Ürün kataloğunun güncellenmesi ve yönetimi. |
| **Sepet** | Ürünlerin toplanması, indirimlerin uygulanması ve net tutar hesabı. |
| **Siparis** | Sepet içeriğinin son aşamaya getirilmesi ve durum takibi. |

## 🚀 Çalıştırma
Projeyi Visual Studio ile açıp `Program.cs` dosyasını çalıştırdığınızda; sistemin otomatik olarak müşterileri eklediğini, ürünleri katalogladığını, sepet oluşturup indirim uyguladığını ve farklı yöntemlerle ödeme aldığını konsol üzerinden izleyebilirsiniz.
