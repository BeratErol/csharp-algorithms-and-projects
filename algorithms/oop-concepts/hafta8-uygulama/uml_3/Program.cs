using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uml_3
{
    // Identifiable Interface: Kimlikli arayüzü, bir nesnenin benzersiz kimliğini temsil etmek için kullanılır.
    public interface IKimlikli
    {
        Guid Id { get; }  // Her nesne bir benzersiz GUID kimliğine sahip olmalı.
    }

    // Experienced Interface: Deneyimli arayüzü, deneyimli kişilerin tecrübe paylaşmasını sağlamak için kullanılır.
    public interface IDeneyimli
    {
        void TecrubePaylas(); // Deneyimli nesneler için bir metot tanımlanır.
    }

    // Vaccine (Asi) Sınıfı: Bir aşıyı temsil eder. Aşı ismi ve türü içerir.
    public class Asi
    {
        private string _isim;
        private string _tur;

        public string Isim
        {
            get { return _isim; }  // Aşı ismi özelliği
        }

        public string Tur
        {
            get { return _tur; }  // Aşı türü özelliği
        }

        public Asi(string isim, string tur)
        {
            _isim = isim;
            _tur = tur;
        }
    }

    // PetInformation (EvcilHayvanBilgisi) Sınıfı: Evcil hayvanın özelliklerini ve aşı bilgilerini tutar.
    public class EvcilHayvanBilgisi
    {
        private List<string> _ozellikler = new List<string>();  // Evcil hayvanın özellikleri
        private List<Asi> _asilar = new List<Asi>();  // Evcil hayvanın aldığı aşılar

        public IReadOnlyList<string> Ozellikler
        {
            get { return _ozellikler; }  // Özellikler listesinin okunabilir hali
        }

        public IReadOnlyList<Asi> Asilar
        {
            get { return _asilar; }  // Aşılar listesinin okunabilir hali
        }

        // Aşı eklemek için kullanılan metot
        public void AsiEkle(Asi asi)
        {
            _asilar.Add(asi);
        }

        // Özellik eklemek için kullanılan metot
        public void OzellikEkle(string ozellik)
        {
            _ozellikler.Add(ozellik);
        }
    }

    // Animal (Hayvan) Sınıfı: Hayvanları temsil eder. Her hayvanın türü, ırkı ve etçil olup olmadığı bilgileri vardır.
    public class Hayvan
    {
        private string _tur;
        private string _irk;
        private bool _etcil;

        public string Tur
        {
            get { return _tur; }  // Hayvan türü özelliği
        }

        public string Irk
        {
            get { return _irk; }  // Hayvan ırkı özelliği
        }

        public bool Etcil
        {
            get { return _etcil; }  // Etçil olup olmadığı özelliği
        }

        // Hayvan sınıfının yapıcı metodu, tür, ırk ve etçil olup olmadığını alır.
        public Hayvan(string tur, string irk, bool etcil)
        {
            _tur = tur;
            _irk = irk;
            _etcil = etcil;
        }
    }

    // Owner (Sahip) Sınıfı: Evcil hayvan sahibini temsil eder. Ayrıca deneyim paylaşma özelliği de vardır.
    public class Sahip : IDeneyimli
    {
        private string _isim;

        public string Isim
        {
            get { return _isim; }  // Sahip ismi özelliği
        }

        // Sahip sınıfının yapıcı metodu, sahip ismini alır.
        public Sahip(string isim)
        {
            _isim = isim;
        }

        // Deneyim paylaşma metodu, Sahip nesnesi için deneyim paylaşımını simüle eder.
        public void TecrubePaylas()
        {
            Console.WriteLine($"{_isim}, evcil hayvan bakımı konusunda tecrübelerini paylaşıyor.");
        }
    }

    // Pet (EvcilHayvan) Sınıfı: Evcil hayvanları temsil eder. Hem Hayvan sınıfından türetilir hem de IKimlikli arayüzünü uygular.
    public class EvcilHayvan : Hayvan, IKimlikli
    {
        private Guid _id = Guid.NewGuid();  // Evcil hayvanın benzersiz kimliği
        private string _isim;
        private int _yas;
        private Sahip _sahibi;  // Evcil hayvanın sahibi
        private EvcilHayvanBilgisi _hayvanBilgisi;  // Evcil hayvan bilgisi (özellikler ve aşılar)

        public Guid Id
        {
            get { return _id; }  // Evcil hayvanın benzersiz kimliği
        }

        public string Isim
        {
            get { return _isim; }  // Evcil hayvanın ismi
        }

        public int Yas
        {
            get { return _yas; }  // Evcil hayvanın yaşı
        }

        public Sahip Sahibi
        {
            get { return _sahibi; }  // Evcil hayvanın sahibi
        }

        public EvcilHayvanBilgisi HayvanBilgisi
        {
            get { return _hayvanBilgisi; }  // Evcil hayvanın bilgisi (özellikler, aşılar)
        }

        // EvcilHayvan sınıfının yapıcı metodu
        public EvcilHayvan(
            string isim,
            int yas,
            Sahip sahibi,
            string tur,    // Hayvan'dan gelen özellikler
            string irk,    // Hayvan'dan gelen özellikler
            bool etcil,    // Hayvan'dan gelen özellikler
            EvcilHayvanBilgisi hayvanBilgisi)  // EvcilHayvanBilgisi bilgisi
            : base(tur, irk, etcil)  // Hayvan sınıfının kurucusuna değerler aktarılır
        {
            _isim = isim;
            _yas = yas;
            _sahibi = sahibi;
            _hayvanBilgisi = hayvanBilgisi;
        }

        // Otcul olup olmadığını kontrol eden metot (Etçil değilse otculdur)
        private bool OtculMu()
        {
            return !Etcil;  // Etcil özelliğini kontrol eder
        }

        // Evcil hayvanı besleme işlemi
        public void Besle()
        {
            if (OtculMu())  // Eğer otculsa
            {
                Console.WriteLine($"{_isim} otla besleniyor.");
            }
            else  // Eğer etçilse
            {
                Console.WriteLine($"{_isim} etle besleniyor.");
            }
        }
    }

    // Test Programı

    class Program
    {
        static void Main(string[] args)
        {
            // Sahip oluşturma (Berat EROL)
            Sahip sahip = new Sahip("Berat EROL");

            // Hayvan türü oluşturma (Köpek, Golden, Etçil)
            Hayvan kopek = new Hayvan("Köpek", "Golden", true);

            // Evcil hayvan bilgisi oluşturma (Sadık özelliği ve Kuduz aşısı)
            EvcilHayvanBilgisi bilgi = new EvcilHayvanBilgisi();
            bilgi.OzellikEkle("Sadık");
            bilgi.AsiEkle(new Asi("Kuduz Aşısı", "Koruyucu"));

            // Evcil hayvan oluşturma (Kontes ismiyle)
            EvcilHayvan evcilHayvan = new EvcilHayvan("Kontes", 3, sahip, kopek.Tur, kopek.Irk, kopek.Etcil, bilgi);

            // Evcil hayvanın özelliklerini yazdırma
            Console.WriteLine($"Evcil Hayvanın İsmi: {evcilHayvan.Isim}");
            Console.WriteLine($"Evcil Hayvanın Yaşı: {evcilHayvan.Yas}");
            Console.WriteLine($"Evcil Hayvanın Türü: {evcilHayvan.Tur}");
            Console.WriteLine($"Evcil Hayvanın Irkı: {evcilHayvan.Irk}");
            Console.WriteLine($"Evcil Hayvan Etçil mi?: {(evcilHayvan.Etcil ? "Evet" : "Hayır")}");

            // Evcil hayvanın özelliklerini yazdırma
            Console.WriteLine("\nEvcil Hayvan Özellikleri:");
            foreach (var ozellik in evcilHayvan.HayvanBilgisi.Ozellikler)
            {
                Console.WriteLine($"- {ozellik}");
            }

            // Evcil hayvanın aşılarını yazdırma
            Console.WriteLine("\nEvcil Hayvan Aşıları:");
            foreach (var asi in evcilHayvan.HayvanBilgisi.Asilar)
            {
                Console.WriteLine($"- Aşı İsmi: {asi.Isim}, Aşı Türü: {asi.Tur}");
            }

            // Evcil hayvanı besleme işlemi
            evcilHayvan.Besle();

            // Sahip tecrübe paylaşımı
            sahip.TecrubePaylas();

            Console.ReadLine();
        }
    }
}
