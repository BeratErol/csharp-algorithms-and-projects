# 🏗️ C# Structs (Yapılar)

Bu klasör, C# programlama dilinde sınıflara (`class`) benzeyen ancak **Değer Tipi (Value Type)** olarak çalışan `struct` yapılarının kullanım örneklerini barındırır. Struct'lar, özellikle küçük veri grupları ve yüksek performans gerektiren matematiksel modeller için idealdir.

## 📂 Uygulama Senaryoları

| Proje Adı | İşlenen Kavram | Açıklama |
| :--- | :--- | :--- |
| **Zaman-Hesaplama-Sistemi** | Encapsulation & Logic | Saat/dakika verilerini kapsülleyerek toplam dakika ve zaman farkı hesabı yapar. |
| **Karmasik-Sayi-Matematigi** | Operator Overloading | Karmaşık sayılarda toplama (`+`) ve çıkarma (`-`) operatörlerini aşırı yükleyerek matematiksel işlem yapar. |
| **GPS-Mesafe-Hesaplayici** | Mathematical Modeling | Haversine formülünü kullanarak iki coğrafi koordinat (Enlem/Boylam) arasındaki mesafeyi hesaplar. |



## 💡 Neden Struct Kullanırız?
- **Performans:** Belleğin *Stack* bölgesinde tutuldukları için hızlı erişim sağlarlar.
- **Kopyalama Davranışı:** Bir struct başka bir değişkene atandığında değeri kopyalanır (Reference değil, Value kopyalaması).
- **Hafif Veri Yapıları:** Koordinat sistemleri, zaman dilimleri veya karmaşık sayılar gibi az sayıda veri tutan yapılar için en doğru tercihtir.

## 🚀 Teknik Detaylar
- **Zaman Sistemi:** Veri doğrulama (0-23 saat, 0-59 dakika kontrolü).
- **Karmaşık Sayılar:** `ToString()` metodunun ezilmesi (`override`) ve özel formatta veri döndürme.
- **GPS Sistemi:** Statik metotlar ve radyan dönüşümleri ile ileri seviye matematiksel işlemler.
