# 🐾 Evcil Hayvan Yönetim Sistemi (UML Modelleme)

Bu proje, bir evcil hayvan takip sisteminin Nesne Tabanlı Programlama (OOP) prensipleri kullanılarak C# dili ile modellenmiş bir UML tasarım uygulamasıdır. Sistem; hayvan türleri, evcil hayvan özellikleri, aşı takibi ve sahiplik ilişkilerini kapsar.



## 🛠️ Uygulanan Yazılım Prensipleri ve OOP Kavramları

Uygulama, esnek ve genişletilebilir bir yapı sunmak için şu teknikleri kullanır:

### 1. Arayüzler (Interfaces)
Sistemde nesnelere belirli yetenekler kazandırmak için arayüzler kullanılmıştır:
- **IKimlikli:** Her evcil hayvana benzersiz bir `Guid` (Global Unique Identifier) atanmasını zorunlu kılar.
- **IDeneyimli:** Sahip (Owner) gibi tecrübe paylaşımı yapabilen nesneler için `TecrubePaylas()` metodunu tanımlar.

### 2. Miras ve Kurucu Zinciri (Inheritance & Constructor Chaining)
- **EvcilHayvan** sınıfı, **Hayvan** sınıfından türetilmiştir. `base()` anahtar kelimesi kullanılarak, hayvanın türü, ırkı ve beslenme şekli gibi temel bilgiler üst sınıfa aktarılır ve orada yönetilir.



### 3. Bileşim (Composition)
- `EvcilHayvan` sınıfı, doğrudan büyük bir yapı olmak yerine `EvcilHayvanBilgisi` nesnesini içinde barındırır. Bu nesne; aşıları (`List<Asi>`) ve hayvan özelliklerini (`List<string>`) yönetir. Bu yaklaşım (Has-a ilişkisi), kodun daha modüler olmasını sağlar.

### 4. Kapsülleme ve Salt Okunur Listeler
- Veri güvenliği için `IReadOnlyList` kullanılmıştır. Bu sayede, evcil hayvanın aşıları dışarıdan okunabilir ancak listenin yapısı doğrudan dışarıdan (add/remove ile) bozulamaz.

## 💻 Sistem Yetenekleri

- **Dinamik Besleme Mantığı:** Hayvanın etçil mi yoksa otçul mu olduğu bilgisini (`Etcil` boolean değeri) kullanarak otomatik besleme mesajı üretir.
- **Aşı ve Özellik Takibi:** Bir hayvana sınırsız sayıda özellik ve aşı eklenebilir.
- **Tecrube Paylaşımı:** Sahip nesnesi, evcil hayvan bakımı konusundaki metotları tetikleyebilir.

## 📂 Dosya Yapısı
- **Program.cs:** Sistemin tüm sınıflarını (Asi, Hayvan, Sahip, EvcilHayvan) ve örnek bir Golden Retriever (Kontes) üzerinde yapılan test senaryosunu içerir.

## 🚀 Nasıl Çalıştırılır?
1. Visual Studio ile projeyi açın.
2. `Program.cs` dosyasını derleyip çalıştırın.
3. Konsol ekranında evcil hayvanın kimlik bilgilerini, aşı listesini ve beslenme davranışını gözlemleyin.
