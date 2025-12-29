# ➡️ Tek Yönlü İlişkiler (One-Way Relationships)

Bu klasör, Nesne Tabanlı Programlama'da (OOP) bir sınıfın diğerini referans olarak tuttuğu veya kullandığı, ancak ikinci sınıfın birinciye dair bir bilgisinin olmadığı **Unidirectional Association** örneklerini barındırır.

## 📂 Uygulama Senaryoları

| Dosya Adı | İlişki Yapısı | Açıklama |
| :--- | :--- | :--- |
| **Yazar-Kitap-Listesi.cs** | `Yazar -> Kitap` | Yazar kendi yazdığı kitapların listesini tutar; kitap nesnesi yazarını bilmez. |
| **Calisan-Departman-Atama.cs** | `Calisan -> Departman` | Çalışan hangi departmana bağlı olduğunu bilir; departman kendisine bağlı çalışanları listelemez. |
| **Urun-Siparis-Veri-Yapisi.cs** | Veri Tanımlama | Ürün ve Sipariş sınıflarının temel özelliklerini ve veri erişim yöntemlerini tanımlar. |
| **Musteri-Siparis-Yonetimi.cs** | `Musteri -> Siparis` | Müşteri bir sipariş verme eylemi gerçekleştirir ve sipariş durumunu kullanır. |

## 🛠️ Teknik Detay
Tek yönlü ilişkilerde veri akışı ve referans tek taraflıdır. Bu yaklaşım, sistemdeki bağımlılıkları (coupling) azaltmak ve sınıfların sorumluluklarını daha net ayırmak (S.O.L.I.D prensipleri kapsamında) için tercih edilir.
