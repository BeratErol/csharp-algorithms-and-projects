# 💎 Güçlü Bağlılık (Composition)

Bu klasör, Nesne Tabanlı Programlama'daki en sıkı ilişki türü olan **Composition** örneklerini içerir. Bu yapıda "Bütün" (Whole), "Parça" (Part) nesnesinin oluşturulmasından ve yok edilmesinden sorumludur. Parça nesnesi, bütünden bağımsız olarak var olamaz.

## 📂 Uygulama Senaryoları

| Dosya Adı | İlişki Tanımı | Açıklama |
| :--- | :--- | :--- |
| **Bilgisayar-Islemci-Iliskisi.cs** | `Bilgisayar -> Islemci` | Bilgisayar nesnesi oluşturulduğunda işlemci de otomatik olarak onun içinde oluşturulur. |
| **Otomobil-Motor-Iliskisi.cs** | `Otomobil -> Motor` | Otomobilin ana parçası olan motor, otomobil sınıfı tarafından yönetilir. |
| **Okul-Ogrenci-Iliskisi.cs** | `Okul -> Ogrenci` | Okul kurucusu içinde öğrenci listesi başlatılır ve öğrenciler okul üzerinden eklenir. |

## 🛠️ Teknik Ayırt Edici Özellik
Bu örneklerde parça nesneleri (İşlemci, Motor, Öğrenci) **dışarıdan parametre olarak alınmaz**, doğrudan ana sınıfın kurucusunda veya bir metodu içinde `new`lenir. Bu sayede ana nesne silindiğinde, bellekteki bağımlı nesneler de erişilemez hale gelir.
