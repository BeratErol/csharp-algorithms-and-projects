# 🧮 Matematik Problemleri ve Algoritmik Çözümler

Bu klasör, temel aritmetikten ileri seviye matematiksel ifade çözümlemelerine kadar çeşitli problemleri ele alan C# uygulamalarını içerir. Buradaki projeler sadece sonuç odaklı değil, aynı zamanda veri yapılarının (Stack, Queue) matematiksel modellemede nasıl kullanıldığını göstermektedir.



## 📂 Projeler ve Teknik Detaylar

| Proje Adı | Kullanılan Teknikler | Açıklama |
| :--- | :--- | :--- |
| **Asal-Sayi-Analizi** | Döngüler & Mantıksal Kontrol | Kullanıcının girdiği sayıya kadar olan tüm asal sayıları tespit eder ve toplamını hesaplar. |
| **Matematiksel-Ifade-Cozucu** | Stack, Queue, Shunting-yard | Parantezli ve operatör öncelikli karmaşık ifadeleri (Örn: `3 + 4 * 2 / (1 - 5) ^ 2`) Postfix dönüşümü yaparak çözer. |
| **Polinom-Aritmetigi** | Regex, Dizi Yönetimi | String formatında girilen iki polinomu analiz eder; katsayıları ayırarak toplama ve çıkarma işlemlerini gerçekleştirir. |

## 🚀 Öne Çıkan Algoritmalar

### 1. Shunting-Yard Algoritması
`Matematiksel-Ifade-Cozucu` içerisinde kullanılan bu algoritma, insan tarafından okunabilen **Infix** (3+4) ifadeleri, bilgisayarların daha kolay işlediği **Postfix** (3 4 +) formatına dönüştürür.

### 2. Polinom Ayrıştırma
`Polinom-Aritmetigi` projesi, kullanıcıdan alınan metin tabanlı polinomları derecelerine göre dinamik olarak dizilere aktarır ve matematiksel işlemleri bu katsayı dizileri üzerinden yürütür.

## 🛠️ Nasıl Çalıştırılır?
Her projenin klasörüne gidip `dotnet run` komutunu kullanarak veya Visual Studio üzerinden `.csproj` dosyalarını açarak uygulamaları test edebilirsiniz.
