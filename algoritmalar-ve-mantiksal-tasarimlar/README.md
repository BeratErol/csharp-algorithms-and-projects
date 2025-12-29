# 🧠 Algoritmalar ve Mantıksal Tasarımlar

Bu bölüm, C# dilini kullanarak geliştirilen karmaşık problemlerin çözüm stratejilerini, matematiksel modelleri ve yazılım mimarilerini bir araya getirir. Buradaki her bir alt klasör, sadece kod yazmayı değil, bir problemin mantıksal olarak nasıl tasarlanacağını temsil eden birer "vaka çalışması" (case study) niteliğindedir.

## 📂 Kod ve Mantık Katmanları

| Tasarım Kategorisi | Açıklama |
| :--- | :--- |
| **[matematiksel-algoritmalar](./matematiksel-algoritmalar/)** | Sayısal analizler, ileri matematiksel işlemler ve operatör öncelikli motorlar. |
| **[diziler-ve-matrisler](./diziler-ve-matrisler/)** | Çok boyutlu veri yapıları üzerinde navigasyon ve veri manipülasyonu. |
| **[karmasik-algoritma-senaryolari](./karmasik-algoritma-senaryolari/)** | Oyunlaştırılmış hikayeler üzerinden BFS, DFS, Backtracking ve Dinamik Programlama uygulamaları. |
| **[nesne-tabanli-programlama-oop](./nesne-tabanli-programlama-oop/)** | Gerçek dünya nesnelerinin sınıflar, kalıtım ve polimorfizm ile modellenmesi. |



## 🏗️ Tasarım Prensipleri

Bu kütüphane oluşturulurken üç temel ilke benimsenmiştir:

1. **Algoritmik Strateji:** Her problem için en verimli (zaman ve bellek odaklı) yaklaşım seçilmiştir. (Örn: En kısa yol için **BFS**, enerji optimizasyonu için **Dinamik Programlama**).
2. **Mimari Düzen:** Kodlar, okunabilirliği artırmak ve modülerliği sağlamak adına belirli bir hiyerarşi ile düzenlenmiştir.
3. **Problem Çözme Sanatı:** Sadece çıktıya odaklanmak yerine, problemin "Neden bu şekilde çözüldüğü" yorum satırları ve dokümantasyonla açıklanmıştır.

## 🚀 Başlangıç

Klasör içerisindeki herhangi bir projeyi incelemek için ilgili dizine giderek:
```bash
dotnet run
