# ⭕❌ Tic-Tac-Toe Oyunu (C# Windows Forms)

Bu proje, klasik **X-O-X (Tic-Tac-Toe)** oyununun **C# Windows Forms** kullanılarak geliştirilmiş bir masaüstü uygulamasıdır. Proje; **olay yönetimi (event handling)**, **durum takibi (state management)** ve **kazanma algoritmaları** üzerine odaklanır.

---

## 🎮 Oyunun Kuralları ve Mekanikleri

* **Sıra Takibi:** Oyun her zaman **X** oyuncusu ile başlar. Her hamlede sıranın kimde olduğu `label2` üzerinden görsel olarak gösterilir.
* **Hamle Yapma:** Oyuncular 3x3'lük grid üzerindeki boş hücrelere tıklar. Tıklanan hücre:

  * Oyuncunun harfi ile doldurulur
  * Tekrar tıklanmayı önlemek için `Enabled = false` yapılır
* **Kazanma:**

  * Yatay, dikey veya çapraz olarak 3 aynı harfi yan yana getiren ilk oyuncu oyunu kazanır.
* **Beraberlik:**

  * Toplam **9 hamle** sonunda kazanan çıkmazsa oyun **beraberlik** ile sonuçlanır.

---

## 🛠️ Teknik Detaylar ve Algoritmalar

### 1️⃣ Dinamik Kazanma Kontrolü

Kazanma durumları, tüm olası kombinasyonların tutulduğu **dizi dizisi (array of arrays)** yapısı ile kontrol edilir. Her hamleden sonra bu kombinasyonlar taranır:

```csharp
int[][] kazananKombinasyonlar = new int[][]
{
    new int[] { 1, 2, 3 }, // Yatay
    new int[] { 4, 5, 6 }, // Yatay
    new int[] { 7, 8, 9 }, // Yatay
    new int[] { 1, 4, 7 }, // Dikey
    new int[] { 2, 5, 8 }, // Dikey
    new int[] { 3, 6, 9 }, // Dikey
    new int[] { 1, 5, 9 }, // Çapraz
    new int[] { 3, 5, 7 }  // Çapraz
};
```

Bu yaklaşım sayesinde kazanma kontrolü **ölçeklenebilir**, **okunabilir** ve **bakımı kolay** bir yapıya kavuşur.

---

### 2️⃣ Grup Olay Yönetimi (Sender Pattern)

9 farklı buton için ayrı ayrı `Click` olayı yazmak yerine, tüm butonlar **tek bir EventHandler** metoduna bağlanmıştır.

`sender` parametresi kullanılarak hangi butona tıklandığı dinamik olarak tespit edilir:

```csharp
Button secilenButton = sender as Button;
secilenButton.Text = Yazma();
```

Bu yöntem:

* Kod tekrarını azaltır
* Bakımı kolaylaştırır
* Profesyonel WinForms geliştirme yaklaşımını yansıtır

---

### 3️⃣ Durum Yönetimi ve Oyun Sıfırlama

Oyun sona erdiğinde (`kazanma` veya `beraberlik`):

* Oyuncuya `DialogResult` ile **yeniden başlama** seçeneği sunulur
* **Evet** seçilirse:

  * `groupBox1.Controls` koleksiyonu dolaşılır
  * Tüm butonlar tek bir döngü ile başlangıç durumuna getirilir:

    * `Text = ""`
    * `Enabled = true`
    * Varsayılan renkler geri yüklenir

Bu yapı sayesinde temiz ve merkezi bir **reset mekanizması** sağlanır.

---

## 🎨 Görsel Geri Bildirimler

* **X oyuncusu:** Kırmızı renk
* **O oyuncusu:** Yeşil renk

Bu renkler sayesinde oyuncular oyunu daha rahat takip edebilir.

---

## 📂 Dosya Yapısı

* **Form1.cs**

  * Hamle sırası yönetimi
  * Kazanma kombinasyonlarının kontrolü
  * Oyun sıfırlama ve durum yönetimi

* **UI Tasarımı**

  * `GroupBox` içinde 9 adet `Button`
  * Sıradaki oyuncuyu gösteren `Label`

---

## 🚀 Nasıl Çalıştırılır?

1. Visual Studio ile `TikTakToe.csproj` dosyasını açın
2. Projeyi derleyin (**Build**)
3. Uygulamayı çalıştırın (**Run**)
4. Kazanan oyuncuya göre değişen renk efektlerini gözlemleyin 🎉

---

## 📌 Amaç

Bu proje;

* C# WinForms olay yönetimini
* Algoritmik düşünmeyi
* Temiz ve okunabilir kod yazımını

öğrenmek ve pekiştirmek amacıyla geliştirilmiştir.

---

**İyi oyunlar! 🎮**
