# 🔠 Adam Asmaca: Şehir Tahmin Oyunu

Bu proje, C# Windows Forms ortamında geliştirilmiş, Türkiye'nin 81 ilini temel alan interaktif bir kelime tahmin oyunudur. Diziler (Arrays), rastgele seçim (Random) ve string manipülasyonu kavramlarını uygulamalı olarak gösterir.

## 🕹️ Oyun Mekanikleri

- **Veri Havuzu:** 81 ilin bulunduğu bir `string[]` dizisi üzerinden `Random` sınıfı ile şehir seçilir.
- **Dinamik Ekran:** Seçilen şehrin harf sayısı kadar `_ ` karakteri çalışma zamanında oluşturulur.
- **Hata Sınırı:** Kullanıcının toplam 10 hata yapma hakkı vardır. Her yanlış tahminde hak azalır.

## 🛠️ Teknik Analiz ve Mimari

### 1. String Güncelleme Mantığı
Doğru tahmin edilen harfin, arayüzdeki `_ _ _` dizisi içinde doğru yere yerleştirilmesi için dize indeksi hesaplaması kullanılır. Her harf arasında bir boşluk olduğu için dize indeksi `i * 2` şeklinde hesaplanır:
```csharp
lbltahmin.Text = lbltahmin.Text.Remove(i * 2, 1).Insert(i * 2, harf.ToString());
