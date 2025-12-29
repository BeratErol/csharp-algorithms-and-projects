                             🎮 HAFTANIN PROJESI = TIK TAK TOE (TikTakToe 📁)

--------------------------------------------------------------------------------------------------------------------------------

📖 HAFTANIN SORULARI (4.HaftaUygulamasi 📁):

🔻 1) (BankaHesabiSinifi.cs 📂) =  Banka Hesabı Sınıfı
Bir BankaHesabi sınıfı oluşturun ve şu özellikleri ekleyin:
Özellikler:
HesapNumarasi (string), Bakiye (decimal)
Get/Set:
Bakiye özelliği için sadece sınıf içinden erişilebilen bir set metodu
yazın.
Yapıcı
Metot: Hesap numarasını ve ilk bakiyeyi alarak başlatan bir yapıcı metot
yazın.
Metotlar:
ParaYatir(decimal miktar) ve ParaCek(decimal miktar) metotları yazın. Para
çekme işleminde bakiye yetersizse işlem yapılmamalı.

🔻 2) (UrunSinifi.cs 📂) = Ürün Sınıfı
Bir Urun sınıfı oluşturun ve özellikleri tanımlayın:
Özellikler:
Ad (string), Fiyat (decimal), Indirim (decimal)
Get/Set:
İndirim için get/set metodları kullanın. İndirimi 0-50% arasında
sınırlandırın.
Yapıcı
Metot: Ad ve fiyat bilgilerini parametre olarak alıp başlatan bir yapıcı
metot tanımlayın.
Metot:
IndirimliFiyat() metodu, indirimli fiyatı döndürsün.

🔻 3) (AracKiralamaSinifi.cs 📂) = Araç Kiralama Sınıfı
Bir KiralikArac sınıfı oluşturun. Bu sınıfta araç kiralama işlemleri
için özellikler ve metotlar tanımlayın:
Özellikler:
Plaka (string), GunlukUcret (decimal), MusaitMi (bool)
Yapıcı
Metot: Plaka ve günlük kiralama ücretini alarak başlatan bir yapıcı metot
yazın. MusaitMi varsayılan olarak true olmalı.
Metotlar:
AraciKirala(), AraciTeslimEt() – Bu metotlar aracın uygunluk durumunu
değiştirsin.

🔻 4) (AdresDefteriSinifi.cs 📂) = Adres Defteri Sınıfı
Bir Kisi sınıfı oluşturun ve kişilerin adres defterinde kayıtlarını
tutmak için aşağıdaki özellik ve metotları ekleyin:
Özellikler:
Ad, Soyad, TelefonNumarasi (string türünde)
Yapıcı
Metot: Ad, soyad ve telefon numarasını alarak başlatan bir yapıcı metot
tanımlayın.
Metot:
KisiBilgisi() – Bu metot, kişinin tam adını ve telefon numarasını
döndürsün.

🔻 5) (KutuphaneSinifi.cs 📂) = Kütüphane Sınıfı
Bir Kutuphane sınıfı oluşturun ve bu sınıfta kitap ekleme ve listeleme
özelliklerini ekleyin:
Özellik:
Kitaplar (List<Kitap> türünde)
Yapıcı
Metot: Kitap listesi boş olarak başlatılsın.
Metotlar:
KitapEkle(Kitap yeniKitap) – Bu metot kitap eklesin ve KitaplariListele()
metodu tüm kitapları ekrana yazdırsın. this anahtar kelimesini kullanarak
eklenen kitabın kütüphaneye ait olduğunu belirtin.
