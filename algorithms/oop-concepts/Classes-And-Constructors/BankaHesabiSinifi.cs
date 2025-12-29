using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.HaftaUygulamasi
{
    class BankaHesabiSinifi
    {
        // değişkenler tanımlama
        string hesapNumarasi;
        decimal bakiye;

        public decimal Bakiye // bakiye değişkeni private iken erişilebilmesini sağlıyoruz
        {
            get { return bakiye; } // bakiye değerini dışarıdan okumayı sağlar
            private set // sadece sınıf içerisinde değiştirilebilir
            {
                bakiye = value; // gelen değer bakiyeye atanır
            }
        }

        // yapıcı metot
        public BankaHesabiSinifi(string hesapNumarasi, decimal ilkBakiye)
        {
            this.hesapNumarasi = hesapNumarasi; // gelen hesap numarası değerini atar
            bakiye = ilkBakiye; // gelen ilk bakiye değerini atar
        }

        // para yatırma işlemi için metot
        public void ParaYatir(decimal yatirilacakTutar)
        {
            bakiye += yatirilacakTutar; // bakiye arttırma
            //Console.WriteLine(bakiye);
        }

        // para çekme işlemi için metot
        public void ParaCek(decimal cekilecekTutar)
        {
            if (cekilecekTutar > bakiye) // çekilecek tutar bakiyeden fazlaysa
                Console.WriteLine("Yetersiz bakiye, İşlem Yapılamadı !"); // Uyarı

            else // çekilecek tutar bakiyeden fazla değilse
            { 
            bakiye -= cekilecekTutar; // bakiye azaltma
            Console.WriteLine(bakiye);
            }
        }
    }
}
