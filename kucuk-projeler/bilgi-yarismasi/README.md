# 📝 Bilgi Yarışması Uygulaması

Bu proje, **C# Windows Forms** ortamında geliştirilmiş, soru–cevap mantığı üzerine kurulu interaktif bir **bilgi yarışması uygulamasıdır**. Uygulama; koşullu ifadeler, sayaçlar, olay yönetimi (event handling) ve kullanıcı etkileşimini bütüncül bir yapı içerisinde sunar.

---

## 🚀 Öne Çıkan Özellikler

* **Dinamik Soru Akışı:** `soruNo` sayacı sayesinde her adımda soru metni, cevap şıkları ve doğru cevap otomatik olarak güncellenir.
* **Görsel Geri Bildirim:**

  * Doğru cevapta ✅ yeşil onay simgesi
  * Yanlış cevapta ❌ kırmızı çarpı simgesi
    (`PictureBox` bileşenleri ile anlık gösterim)
* **Puanlama Sistemi:** Doğru (`dogru`) ve yanlış (`yanlis`) cevap sayıları eş zamanlı olarak hesaplanır ve arayüzde gösterilir.
* **Kontrollü Arayüz:** Bir cevap seçildiği anda tüm şık butonları pasif hale getirilerek tekrar cevap verme engellenir.

---

## 🛠️ Teknik Analiz

Uygulamanın temel işleyişi aşağıdaki programlama yapılarına dayanmaktadır.

### 1. Soru ve Cevap Yönetimi

Her soru geçişinde:

* Soru metni (`RichTextBox`)
* Şık metinleri (`Button`)
* Doğru cevap (`dogruCevap` değişkeni)

senkronize şekilde güncellenir. `BtnSonraki` butonuna basıldığında yeni soru yüklenir ve butonlar tekrar aktif edilir.

```csharp
if (soruNo == 1)
{
    richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir ?";
    BtnD.Text = "1923";
    dogruCevap = "1923";
}
```

---

### 2. Doğruluk Kontrolü

Kullanıcının seçtiği cevap (`secilenCevap`), sistemde tutulan `dogruCevap` ile karşılaştırılır. Sonuca göre sayaçlar ve görsel geri bildirimler tetiklenir.

```csharp
secilenCevap = BtnA.Text;
if (dogruCevap == secilenCevap)
{
    dogru++;
    pictureBox1.Visible = true;
}
```

---

## 📂 Dosya Yapısı

* **Form1.cs**
  Soru listesi, cevap doğrulama algoritmaları, sayaç yönetimi ve olay kontrol mantığını içeren ana dosya.

* **UI Bileşenleri**

  * `RichTextBox` → Soru metni
  * `Button` → Cevap şıkları
  * `PictureBox` → Doğru / yanlış görsel geri bildirimleri

---

## ▶️ Çalıştırma Talimatları

1. Proje klasörünü açın.
2. `.sln` dosyasını **Visual Studio** ile çalıştırın.
3. Uygulamayı **F5** ile başlatın.
4. Soruları cevaplayarak skorunuzu takip edin.

---

## 📌 Notlar

* Uygulama tek form üzerinden çalışmaktadır.
* Yeni sorular eklemek için `soruNo` kontrol bloğu genişletilebilir.
* Arayüz ve soru havuzu geliştirilmeye açıktır.

---

🎯 **Basit, kontrollü ve genişletilebilir bir bilgi yarışması uygulaması örneği**
