# 🎬 Sinema Büfe Satış Sistemi

## 📌 Proje Tanımı

**Sinema Büfe Satış Sistemi**, sinema salonlarında yapılan büfe satışlarını hızlı ve pratik bir şekilde hesaplamak için geliştirilmiş bir **C# Windows Forms** uygulamasıdır. Sistem; mısır, bilet, su ve çay satışlarını adet bazında alır, toplam tutarı hesaplar ve kasa bakiyesini dinamik olarak günceller.

Bu proje, **event-driven (olay tabanlı)** programlama mantığını, temel kullanıcı arayüzü (UI) bileşenlerini ve değişken yönetimini örnekleyen sade ama işlevsel bir masaüstü uygulamasıdır.

---

## 🧱 Kullanılan Teknolojiler

* **Dil:** C#
* **Platform:** .NET Framework
* **Arayüz:** Windows Forms (WinForms)
* **Mimari:** Event-Driven UI Logic

---

## ⚙️ Sistem Mantığı

### Ürünler ve Birim Fiyatları

| Ürün  | Birim Fiyat (TL) |
| ----- | ---------------- |
| Mısır | 70               |
| Bilet | 100              |
| Su    | 15               |
| Çay   | 25               |

### Çalışma Akışı

1. Kullanıcı her ürün için adet bilgisini girer
2. **Hesapla** butonuna basıldığında:

   * Toplam satış tutarı hesaplanır
   * Anlık toplam ekranda gösterilir
   * Kasa tutarı güncellenir
3. **Temizle** butonu ile giriş alanları sıfırlanır ve yeni satış için hazır hale getirilir

---

## 🧮 Hesaplama Formülü

```
Toplam Tutar = 
(Mısır Adedi × 70) + 
(Bilet Adedi × 100) + 
(Su Adedi × 15) + 
(Çay Adedi × 25)
```

Kasa tutarı her işlem sonrası birikimli olarak artırılır.

---

## 🖥️ Kullanıcı Arayüzü Bileşenleri

* **TextBox**: Ürün adet girişleri
* **Label**: Toplam tutar ve kasa bilgisi
* **Button**:

  * Satış Hesapla
  * Alanları Temizle

---

## 🎯 Projenin Sağladığı Kazanımlar

* Windows Forms temel bileşen kullanımı
* Event handler (Click) mantığı
* Sayısal veri dönüşümleri (`Convert.ToInt16`)
* Değişkenler ile durum (state) yönetimi
* Basit ticari senaryo modelleme

---
