# 🔄 Method Overloading (Metot Aşırı Yükleme)

Bu klasör, Nesne Tabanlı Programlama'nın (OOP) polimorfizm (çok biçimlilik) prensiplerinden biri olan **Method Overloading** yapısına dair uygulama örneklerini barındırır. Aynı isimli metotların farklı imzalara (parametre sayısı veya veri tipi) sahip olarak nasıl kullanıldığını gösterir.

## 📂 Uygulama Senaryoları

| Proje Adı | Overloading Tekniği | Açıklama |
| :--- | :--- | :--- |
| **Matematiksel-Toplama-Varyasyonlari** | Parametre Sayısı & Diziler | 2 sayı, 3 sayı veya bir tam sayı dizisini (`int[]`) toplayan aynı isimli metotlar. |
| **Geometrik-Alan-Hesaplayici** | Veri Tipi & Parametre Sayısı | Kare (tek int), Dikdörtgen (iki int) ve Daire (double yarıçap) alanlarını hesaplayan `AlanHesapla` metotları. |
| **Gelismis-Zaman-Farki-Analizi** | Dönüş Tipi & Parametre Çeşitliliği | İki tarih arasını Gün (int), Saat (double) veya detaylı (Yıl/Ay/Gün - struct) olarak döndüren metotlar. |



## 🛠️ Teknik Kazanımlar
- **İmza (Signature) Farklılığı:** Metotların sadece dönüş tipiyle değil, parametre listesiyle ayrıştırılması.
- **Esnek Kod Yapısı:** Aynı işi yapan farklı girdi tipleri için kullanıcıya tek bir metot ismi sunma kolaylığı.
- **Dinamik Hesaplama:** Tarih farkı örneğinde olduğu gibi, isteğe bağlı olarak basit veya detaylı (struct dönen) sonuç üretme yeteneği.

## 🚀 Çalıştırma
İlgili klasörün içine girip `Program.cs` dosyasını Visual Studio ile derleyebilir veya `dotnet run` komutuyla farklı parametre girişlerinin nasıl sonuçlandığını konsoldan takip edebilirsiniz.
