# 🔗 Sınıf İlişkileri (Class Relationships)

Bu klasör, Nesne Tabanlı Programlama'nın (OOP) en kritik konularından biri olan sınıflar arası bağları ve etkileşim türlerini içeren kapsamlı uygulama örneklerini barındırır. Projeler, karmaşıklığı önlemek ve öğrenme sürecini kolaylaştırmak adına ilişki türlerine göre kategorize edilmiştir.



## 📂 Klasör Yapısı ve Senaryolar

Her bir alt klasör, ilgili ilişki türünü gerçek dünya senaryolarıyla somutlaştıran dosyalar içerir.

### 1. [Tek Yönlü İlişkiler](./Tek-Yonlu-Iliskiler/)
Bir sınıfın diğerini bildiği ancak karşı tarafın bu durumdan haberdar olmadığı yapılardır.
- **İçerik:** Yazar-Kitap listesi, Çalışan-Departman ataması ve Müşteri-Siparis yönetimi.

### 2. [Çift Yönlü İlişkiler](./Cift-Yonlu-Iliskiler/)
Sınıfların birbirini karşılıklı referans olarak tuttuğu, etkileşimin iki yönlü olduğu yapılardır.
- **İçerik:** Doktor-Hasta, Yazar-Kitap, Şirket-Çalışan ve Ebeveyn-Çocuk ilişkileri.

### 3. [Zayıf Bağlılık - Aggregation](./Zayif-Baglilik-Aggregation/)
"Parça-Bütün" ilişkisidir ancak nesnelerin yaşam süreleri bağımsızdır. Bütün yok olduğunda parçalar yaşamaya devam eder.
- **İçerik:** Ev-Oda, Şirket-Çalışan ve Kütüphane-Kitap senaryoları.

### 4. [Güçlü Bağlılık - Composition](./Guclu-Baglilik-Composition/)
Sıkı bir parça-bütün ilişkisidir. Bütün nesnesi yok edildiğinde, onu oluşturan parçalar da sistem tarafından yok edilir.
- **İçerik:** Bilgisayar-İşlemci, Otomobil-Motor ve Okul-Öğrenci hiyerarşileri.



## 🚀 Nasıl İncelenir?
Klasörler içindeki dosyalar (Örn: `Doktor-Hasta-Iliskisi.cs`) konuyu en yalın haliyle anlatmak üzere tasarlanmıştır. İnceleme yaparken şunlara dikkat edin:
- **Constructor (Yapıcı Metot):** Nesneler birbirine parametre olarak mı gönderiliyor (Aggregation), yoksa sınıf içinde mi oluşturuluyor (Composition)?
- **Listeler:** Birden fazla nesne (`List<T>`) arasındaki bağlar nasıl yönetiliyor?
- **Referans Kontrolü:** Çift yönlü ilişkilerde sonsuz döngülerin nasıl engellendiği.

## 🛠️ Çalıştırma
İlgili klasördeki `.sln` (Solution) dosyasını Visual Studio ile açarak tüm örnekleri derleyebilir veya terminal üzerinden ilgili klasöre gidip `dotnet run` komutunu kullanabilirsiniz.
