# ⭕❌ Tic-Tac-Toe Oyunu (C# Form App)

Bu proje, klasik "X-O-X" (Tic-Tac-Toe) oyununun C# Windows Forms kullanılarak geliştirilmiş, mantıksal kontrol ve kazanma algoritmaları odaklı bir versiyonudur.



## 🎮 Oyunun Kuralları ve Mekanikleri

- **Sıra Takibi:** Oyun her zaman "X" oyuncusu ile başlar. Her tıklamada sıranın kimde olduğu `label2` üzerinden görsel olarak bildirilir.
- **Hamle Yapma:** Oyuncular 3x3'lük bir grid üzerinde boş hücrelere tıklar. Tıklanan hücre kilitlenir (`Enabled = false`) ve oyuncunun harfi yazılır.
- **Kazanma:** Yatay, dikey veya çapraz olarak 3 aynı harfi yan yana getiren ilk oyuncu oyunu kazanır.
- **Beraberlik:** 9 hamle sonunda kazanan çıkmazsa oyun beraberlikle sonuçlanır.

## 🛠️ Teknik Detaylar ve Algoritmalar

### 1. Dinamik Kazanma Kontrolü
Kazanma durumları, bir dizi içerisinde (Array of Arrays) tüm olasılıklar tanımlanarak kontrol edilir. Her hamleden sonra bu kombinasyonlar taranır:

```csharp
int[][] kazananKombinasyonlar = new int[][]
{
    new int[] { 1, 2, 3 }, // Yatay
    new int[] { 1, 4, 7 }, // Dikey
    new int[] { 1, 5, 9 }, // Çapraz
    // ... diğer kombinasyonlar
};
