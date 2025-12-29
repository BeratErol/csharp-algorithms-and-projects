# 🔗 Sınıf İlişkileri (Class Relationships)

Bu klasör, Nesne Tabanlı Programlama'nın (OOP) en kritik konularından biri olan sınıflar arası bağları ve etkileşim türlerini içeren kapsamlı uygulama örneklerini barındırır. Projeler, karmaşıklığı önlemek adına konu bazlı alt klasörlere ayrılmıştır.

## 📂 Klasör ve İçerik Yapısı

Her bir alt klasör, ilgili ilişki türünün farklı senaryolarını içeren numaralandırılmış `.cs` dosyalarından oluşur.

### 1. [Tek Yönlü İlişkiler](./Tek-Yonlu-Iliskiler/)
Bir sınıfın diğer bir sınıfa erişebildiği ancak karşılığının olmadığı (tek taraflı bağımlılık) durumları inceler.
- **Örnekler:** Temel erişim senaryoları ve nesne yönlendirmeleri.

### 2. [Çift Yönlü İlişkiler](./Cift-Yonlu-Iliskiler/)
Her iki sınıfın da birbirini referans olarak tuttuğu ilişki türüdür.
- **Senaryo:** Doktor-Hasta, Öğrenci-Ders gibi karşılıklı etkileşim içeren yapılar.

### 3. [Zayıf Bağlılık - Aggregation](./Zayif-Baglilik-Aggregation/)
"Parça-Bütün" ilişkisidir ancak nesnelerin yaşam süreleri birbirinden bağımsızdır. Bütün (Whole) nesnesi yok olduğunda, parça (Part) nesnesi varlığını sürdürmeye devam eder.
- **Senaryo:** Bir kütüphane ve içindeki kitaplar arasındaki ilişki.

### 4. [Güçlü Bağlılık - Composition](./Guclu-Baglilik-Composition/)
Sıkı bir parça-bütün ilişkisidir. Bütün nesnesi yok edildiğinde, onu oluşturan parça nesneler de sistem tarafından yok edilir.
- **Senaryo:** Bir insan vücudu ve organları veya bir ev ve odaları arasındaki ilişki.



## 🚀 Nasıl İncelenir?
Her klasör içerisindeki numaralandırılmış dosyalar (Örn: `Tek-Yonlu-Iliski-Ornek1.cs`) basit seviyeden ileri seviyeye doğru mantıksal bir sıra izler. Kodlar içerisindeki **Constructor (Yapıcı Metot)** kullanımlarına dikkat ederek nesnelerin birbirine nasıl aktarıldığını gözlemleyebilirsiniz.

## 🛠️ Çalıştırma
İlgili klasördeki `.sln` (Solution) dosyasını Visual Studio ile açarak tüm örnekleri tek bir çatı altında derleyebilir veya `dotnet run` komutuyla konsol çıktılarını görebilirsiniz.
