# ✈️ Uçuş Rezervasyon Sistemi

Bu proje, C# Windows Forms kullanılarak geliştirilmiş basit ve işlevsel bir **uçuş rezervasyon yönetim uygulamasıdır**. Kullanıcıdan alınan uçuş ve yolcu bilgileri tek bir kayıt halinde listelenir ve rota bilgileri dinamik olarak değiştirilebilir.

## 🚀 Özellikler

* **Rota Seçimi:** Kalkış ve varış şehirleri `ComboBox` bileşenleri üzerinden seçilir.
* **Tarih ve Saat Yönetimi:** Uçuş tarihi `DateTimePicker`, uçuş saati ise `MaskedTextBox` ile alınır.
* **Yolcu Bilgileri Kaydı:** Ad-soyad, T.C. kimlik numarası ve telefon bilgileri maske kontrollü alanlarla girilir.
* **Kayıt Listeleme:** Girilen tüm bilgiler tek bir metin halinde `ListBox` üzerinde saklanır.
* **Rota Değiştirme:** Tek buton ile kalkış ve varış noktaları yer değiştirilebilir.

## 🛠️ Teknik Yapı ve Mantık

### 1. Rezervasyon Oluşturma

`button1_Click` olayı tetiklendiğinde, arayüzden alınan tüm bilgiler birleştirilerek `ListBox` içine eklenir:

```csharp
listBox1.Items.Add("Rota: " + comboBox1.Text + " - " + comboBox2.Text + " Tarih: " + dateTimePicker1.Text + " Saat: " + maskedTextBox1.Text + " Yolcu Bilgileri ~ Ad: " + textBox1.Text + " TC: " + maskedTextBox2.Text + " Telefon: " + maskedTextBox3.Text);
```

İşlem tamamlandığında kullanıcıya bir bilgilendirme mesajı gösterilir.

### 2. Rota Değiştirme (Swap)

Kalkış ve varış şehirlerini yer değiştirmek için geçici bir değişken (`temp`) kullanılır:

```csharp
temp = comboBox2.Text;
comboBox2.Text = comboBox1.Text;
comboBox1.Text = temp;
```

Bu yaklaşım, veri kaybı olmadan iki değerin güvenli şekilde yer değiştirilmesini sağlar.

## 📂 Proje Yapısı

* **Form1.cs**
  Uçuş bilgileri, yolcu kayıt işlemleri ve rota değiştirme mantığını içeren ana form dosyasıdır.

* **UI Bileşenleri**

  * ComboBox: Kalkış / Varış şehirleri
  * DateTimePicker: Uçuş tarihi
  * MaskedTextBox: Saat, T.C. kimlik, telefon
  * ListBox: Rezervasyon kayıtları

## 📌 Genel Değerlendirme

Bu uygulama; olay tabanlı programlama, kullanıcı girdisi yönetimi ve temel veri birleştirme mantığını içeren, masaüstü rezervasyon sistemlerinin temel çalışma prensiplerini yansıtan sade bir çözümdür.
