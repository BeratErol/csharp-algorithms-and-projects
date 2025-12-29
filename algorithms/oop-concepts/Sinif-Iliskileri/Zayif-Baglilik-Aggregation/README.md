# 🧱 Zayıf Bağlılık (Aggregation)

Bu klasör, Nesne Tabanlı Programlama'daki **Aggregation** (Birleşim) ilişkisine dair örnekleri içerir. Bu yapıda parça nesneler, bütün nesnesinden bağımsız bir yaşam döngüsüne sahiptir. "Bütün" nesnesi yok edildiğinde "Parça" nesneleri silinmez.

## 📂 Uygulama Senaryoları

| Dosya Adı | İlişki Tanımı | Açıklama |
| :--- | :--- | :--- |
| **Ev-Oda-Iliskisi.cs** | `Ev <>-- Oda` | Odalar evden bağımsız olarak tanımlanabilir ve bir eve eklenebilir. |
| **Sirket-Calisan-Iliskisi.cs** | `Sirket <>-- Calisan` | Şirket kapansa bile çalışan nesnesi sistemde var olmaya devam eder. |
| **Kutuphane-Kitap-Iliskisi.cs** | `Kutuphane <>-- Kitap` | Kitaplar kütüphaneden bağımsız varlıklardır; kütüphaneye dahil edilir veya çıkarılır. |

## 🛠️ Teknik Ayırt Edici Özellik
Aggregation ilişkisinde parçalar genellikle ana sınıfın kurucusunda `new` ile oluşturulmaz; bunun yerine **parametre olarak** dışarıdan alınır (Dependency Injection mantığına yakındır). Bu durum, nesneler arasındaki bağımlılığın "zayıf" kalmasını sağlar.
