# 🧬 Kalıtım ve Çok Biçimlilik (Inheritance & Polymorphism)

Bu klasör, Nesne Tabanlı Programlama'nın en güçlü özellikleri olan Kalıtım ve Çok Biçimlilik kavramlarını, gerçek dünya senaryoları (Bankacılık, Personel Yönetimi, Mağaza Sistemleri) üzerinden inceleyen 6 farklı uygulama barındırır.

## 📂 Uygulama Senaryoları

| Proje Adı | İşlenen Teknikler | Açıklama |
| :--- | :--- | :--- |
| **Calisan-Yonetim-Sistemi** | `virtual`, `override`, `base` | Yazılımcı ve Muhasebeci sınıflarının ortak bir `Calisan` sınıfından türetilmesi. |
| **Hayvanlar-Alemi-Simulasyonu** | Polimorfizm, Tür Dönüşümü | Farklı hayvan türlerinin (`Memeli`, `Kus`) kendilerine özgü sesleri polimorfik olarak çıkarması. |
| **Banka-Hesap-Turleri** | Mantıksal Kalıtım | Vadeli ve Vadesiz hesapların, para çekme kurallarını (`override`) farklılaştırması. |
| **Banka-Arayuz-ve-Soyutlama** | `interface`, `abstract` | Banka hesabı standartlarının arayüz ile belirlenip soyut sınıflar üzerinden uygulanması. |
| **Magaza-Urun-Odeme-Sistemi** | `List<Urun>`, Soyut Metotlar | Kitap ve Elektronik ürünler için farklı vergi oranlarıyla dinamik ödeme hesaplama. |
| **Yayin-Abone-Bildirim-Sistemi** | Interface, Observer Pattern | Yayıncı ve Abone arasındaki etkileşimin arayüzler üzerinden yönetilmesi. |

## 🛠️ Teknik Kazanımlar
- **Kodu Yeniden Kullanma (Reusability):** Ortak özellikleri (`Ad`, `Fiyat`, `Bakiye`) temel sınıflarda toplayarak kod tekrarını önleme.
- **Çok Biçimlilik (Polymorphism):** Aynı metodun (`SesCikar`, `ParaCek`, `BilgiYazdir`) farklı sınıflarda farklı işler yapması.
- **Güvenli Soyutlama:** `abstract` sınıflar ve `interface` yapısı ile uygulama standartlarının (sözleşmelerin) belirlenmesi.

## 🚀 Çalıştırma
İlgili klasördeki `Program.cs` dosyasını Visual Studio ile açarak kullanıcı etkileşimli (konsol girişi bekleyen) senaryoları test edebilirsiniz.
