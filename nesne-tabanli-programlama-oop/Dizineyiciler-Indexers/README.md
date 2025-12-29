# 📑 C# Indexers (Dizinleyiciler)

Bu klasör, C# dilinde sınıfların bir dizi (`array`) veya koleksiyon gibi indekslenerek kullanılmasına olanak tanıyan **Indexer** yapısına ait uygulama örneklerini içerir.

## 📂 Uygulama Senaryoları

| Proje Adı | Veri Yapısı | Açıklama |
| :--- | :--- | :--- |
| **Kitaplik-Yonetim-Sistemi** | `string[]` | Tek boyutlu dizi kullanarak kitaplara tam sayı indeksiyle erişim sağlar. |
| **Ogrenci-Not-Sistemi** | `Dictionary<string, int>` | Anahtar tabanlı (`string`) indeksleyici kullanarak ders adına göre not takibi yapar. |
| **Satranc-Tahtasi-Uygulamasi** | `string[,]` | Çok boyutlu (8x8) dizi kullanarak satranç tahtasındaki karelere koordinatla erişim sağlar. |
| **Otopark-Yonetim-Simulasyonu** | `string[][]` | Düzensiz diziler (`Jagged Arrays`) kullanarak kat ve peron bazlı araç takibi yapar. |



## 🛠️ Teknik Bilgiler
- **Indexer Nedir?**: Bir sınıfın nesnesini `nesne[indeks]` şeklinde kullanmamızı sağlayan özel bir mülkiyettir (`this`).
- **Hata Yönetimi**: Örneklerde `IndexOutOfRangeException` ve `KeyNotFoundException` gibi hata yakalama (Try-Catch) mekanizmaları işlenmiştir.
- **Aşırı Yükleme (Overloading)**: İndeksleyiciler hem `int` hem de `string` gibi farklı veri tipleriyle tanımlanabilir.

## 🚀 Çalıştırma
İlgili projenin klasörüne girip `dotnet run` komutuyla konsol çıktılarını ve hata yönetim senaryolarını test edebilirsiniz.
