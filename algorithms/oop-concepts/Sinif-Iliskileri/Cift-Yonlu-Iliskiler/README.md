# 🔄 Çift Yönlü İlişkiler (Two-Way Relationships)

Bu klasör, iki sınıfın birbirini referans olarak bildiği ve etkileşimin karşılıklı olduğu nesne tabanlı programlama örneklerini barındırır. Bu yapıda, bir nesne üzerinden diğerine erişilebildiği gibi, tersi de mümkündür.

## 📂 Örnek Senaryolar

| Dosya Adı | İlişki Yapısı | Açıklama |
| :--- | :--- | :--- |
| **Doktor-Hasta-Iliskisi.cs** | `Doktor <-> Hasta` | Doktorun hasta listesi vardır, hastanın da atanmış bir doktoru bulunur. |
| **Yazar-Kitap-Iliskisi.cs** | `Yazar <-> Kitap` | Yazara ait kitaplar listelenirken, kitap üzerinden yazara ulaşılabilir. |
| **Sirket-Calisan-Iliskisi.cs** | `Sirket <-> Calisan` | Şirketin çalışan havuzu ve çalışanın bağlı olduğu şirket bilgisi tutulur. |
| **Ebeveyn-Cocuk-Iliskisi.cs** | `Ebeveyn <-> Cocuk` | Aile ağacı mantığında karşılıklı ebeveyn ve çocuk referansları yönetilir. |



## 🛠️ Teknik Detay: Referans Yönetimi
Çift yönlü ilişkilerde dikkat edilmesi gereken en önemli nokta **sonsuz döngüden kaçınmaktır**. Kodlarda kullanılan `if (!Liste.Contains(nesne))` ve `if (Referans != yeniReferans)` kontrolleri, atama işlemlerinin birbirini sürekli tetiklemesini önleyerek güvenli bir bağ kurar.
