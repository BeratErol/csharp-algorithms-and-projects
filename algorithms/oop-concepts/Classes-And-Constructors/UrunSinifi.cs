using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.HaftaUygulamasi
{
    class UrunSinifi
    {
        // değişkenler tanımlama
        string Ad;
        decimal Fiyat, indirim;
        
        public decimal Indirim // get set metotlarını kullanma
        {
            get { return indirim; } // indirim değerini dışarıdan okumayı sağlar
            set
            {
                if (value > 0 & value < 50) // gelen değer 0 ile 50 arasındaysa
                {
                    indirim = value; // gelen değeri indirime atıyoruz
                }
                else throw new ArgumentException("İndirim 0-50% arasında olmalıdır !"); // 0 ile 50 arasında değilse hata mesajı
            }
        }

        // yapıcı metot
        public UrunSinifi(string ad, decimal fiyat)
        {
            Ad = ad; // gelen ad değerini atar
            Fiyat = fiyat; // gelen fiyat değerini atar
        }

        // indirimli fiyat için metot
        public decimal IndirimliFiyat()
        {
            decimal indirimliFiyat = (Fiyat * (100-indirim)) / 100; // indirimli fiyatı hesaplama
            return indirimliFiyat; // indrimli fiyatı döndürme
        }
    }
}
