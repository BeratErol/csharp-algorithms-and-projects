# 🔠 Adam Asmaca: Şehir Tahmin Oyunu (Hangman)

Bu proje, **C# Windows Forms** kullanılarak geliştirilmiş, Türkiye'nin **81 ilini** temel alan eğitsel ve etkileşimli bir kelime tahmin oyunudur. Oyun; **diziler (Arrays)**, **rastgele seçim (Random)**, **string manipülasyonu** ve **event-driven programlama** kavramlarını uygulamalı olarak göstermeyi amaçlar.

---

## 🎯 Oyunun Amacı

Oyuncunun amacı, rastgele seçilen şehir adını **10 hata hakkı** dolmadan doğru harfleri tahmin ederek bulmaktır. Her doğru tahmin kelimenin ilgili konumuna yerleştirilir, yanlış tahminlerde ise kalan hak azalır.

---

## 🕹️ Oyun Mekanikleri

* **Veri Havuzu:** Türkiye'nin 81 ilinden oluşan `string[] sehirler` dizisi
* **Rastgele Seçim:** `Random` sınıfı ile oyun başında ve her yeni turda şehir seçilir
* **Dinamik Arayüz:** Seçilen şehrin harf sayısı kadar `_ ` karakteri çalışma zamanında oluşturulur
* **Hata Sistemi:** Oyuncunun toplam 10 yanlış tahmin hakkı vardır
* **Klavye Simülasyonu:** Harfler butonlar üzerinden seçilir ve tekrar seçilmesi engellenir

---

## 🛠️ Teknik Mimari ve Algoritmik Yapı

### 1️⃣ Rastgele Şehir Seçimi

Oyun her başladığında veya yeniden başlatıldığında şehir dizisinden rastgele bir eleman seçilir:

```csharp
int rndmIndex = rndm.Next(sehirler.Length);
secilenSehir = sehirler[rndmIndex];
```

---

### 2️⃣ Dinamik Gizli Kelime Oluşturma

Seçilen şehrin uzunluğu kadar `_ ` karakteri ekrana yazdırılır:

```csharp
for (int i = 0; i < secilenSehir.Length; i++) {
    lbltahmin.Text += "_ ";
}
```

Bu yapı sayesinde kelime uzunluğuna bağlı dinamik bir oyun alanı oluşturulur.

---

### 3️⃣ Harf Tahmin ve String Güncelleme Mantığı

Doğru tahmin edilen harfin, `_ _ _` yapısı içinde doğru konuma yerleştirilmesi için **string index hesaplaması** yapılır.

Her harften sonra bir boşluk bulunduğu için gerçek indeks `i * 2` olarak hesaplanır:

```csharp
lbltahmin.Text = lbltahmin.Text.Remove(i * 2, 1)
                               .Insert(i * 2, harf.ToString());
```

Bu yöntem, **string manipülasyonu** ve **indeks kontrolü** açısından öğretici bir örnektir.

---

### 4️⃣ Hata Sayacı ve Hak Kontrolü

Yanlış tahminlerde hata sayacı artırılır ve kalan hak güncellenir:

```csharp
hataSayaci++;
label5.Text = (10 - hataSayaci).ToString();
```

Hak 0 olduğunda oyun sona erer ve kullanıcıya tekrar oynama seçeneği sunulur.

---

### 5️⃣ Kazanma Durumu Kontrolü

Boşluklar temizlenerek tahmin edilen kelime ile gerçek kelime karşılaştırılır:

```csharp
if (lbltahmin.Text.Replace(" ", "") == secilenSehir)
```

Bu kontrol sayesinde oyuncunun tüm harfleri doğru tahmin edip etmediği belirlenir.

---

## 🔁 Oyun Yeniden Başlatma Mantığı

* Tüm harf butonları tekrar aktif edilir
* Hata sayacı sıfırlanır
* Yeni bir şehir seçilir
* Gizli kelime yeniden oluşturulur

Bu yapı, **state reset (oyun durumu sıfırlama)** mantığını açıkça göstermektedir.

---

## 📂 Dosya Yapısı

* **Form1.cs** → Oyun mantığı, olaylar, kontrol mekanizmaları
* **Form1.Designer.cs** → Arayüz bileşenleri (butonlar, label’lar)
* **Resources** → (Varsa) görsel veya ek medya dosyaları

---

## 🚀 Nasıl Çalıştırılır?

1. Projeyi Visual Studio ile açın
2. `Adam_Asmaca.sln` dosyasını yükleyin
3. Derleyip çalıştırmak için **F5** tuşuna basın
4. Harf butonlarını kullanarak şehir tahminine başlayın

---

## 📚 Eğitimsel Kazanımlar

Bu proje sayesinde:

* ✔️ Diziler (Arrays)
* ✔️ Random sınıfı kullanımı
* ✔️ String parçalama ve güncelleme
* ✔️ Event-driven WinForms yapısı
* ✔️ Oyun durumu (state) yönetimi

konularında pratik yapılabilir.

---
