using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adam_Asmaca
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Hata sayaci tanimlama
        int hataSayaci = 0;

        // Butun sehirleri dizi icinde tutma
        string[] sehirler = {"ADANA", "ADIYAMAN", "AFYONKARAHİSAR", "AĞRI", "AKSARAY", "AMASYA", "ANKARA", "ANTALYA", "ARDAHAN", "ARTVİN", "AYDIN", "BALIKESİR", "BARTIN", "BATMAN", "BAYBURT", "BİLECİK", "BİNGÖL", "BİTLİS", "BOLU", "BURDUR", "BURSA", "ÇANAKKALE", "ÇANKIRI", "ÇORUM", "DENİZLİ", "DİYARBAKIR", "DÜZCE", "EDİRNE", "ELAZIĞ", "ERZİNCAN", "ERZURUM", "ESKİŞEHİR", "GAZİANTEP", "GİRESUN", "GÜMÜŞHANE", "HAKKARİ", "HATAY", "IĞDIR", "ISPARTA", "İSTANBUL", "İZMİR", "KAHRAMANMARAŞ", "KARABÜK", "KARAMAN", "KARS", "KASTAMONU", "KAYSERİ", "KIRIKKALE", "KIRKLARELİ", "KIRŞEHİR", "KİLİS", "KOCAELİ","KONYA", "KÜTAHYA", "MALATYA", "MANİSA", "MARDİN", "MERSİN", "MUĞLA", "MUŞ", "NEVŞEHİR", "NİĞDE", "ORDU", "OSMANİYE", "RİZE", "SAKARYA", "SAMSUN", "SİİRT", "SİNOP", "SİVAS", "ŞANLIURFA", "ŞIRNAK", "TEKİRDAĞ", "TOKAT", "TRABZON", "TUNCELİ", "UŞAK", "VAN", "YALOVA", "YOZGAT", "ZONGULDAK"};
        Random rndm = new Random(); 
        string secilenSehir = "";
        
        private void Form1_Load(object sender, EventArgs e)
        {
            // Sehirler dizisinden random sehir sectirtme
            int rndmIndex = rndm.Next(sehirler.Length);
            secilenSehir = sehirler[rndmIndex];
            
            // Secilen sehirin uzunlugu kadar "_" yazdirma 
            for (int i = 0; i < secilenSehir.Length; i++) {
                lbltahmin.Text = lbltahmin.Text + "_ ";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Cikis butonuna tiklanirsa programi kapatma
            Application.Exit();
        }

        private void lbltahmin_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        
        private void Klavye(object sender, EventArgs e)
        { 
            Button secilenHarf = sender as Button; // Tiklanan butonu alir ve Button tipine dönüştürür.
            secilenHarf.Enabled = false; // Tiklanan butonun (harfin) tekrar kullanilmasini engeller.

            char harf = secilenHarf.Text[0]; // Tiklanan butondaki harfi alır.(text olarak ilk karakteri)

            // Kullanicinin secilen sehir icindeki harflerden birini sectiginin kontrolu
            if (secilenSehir.Contains(harf))
            {
                // Kullanici tarafindan bilenen harfin kelimede kacinci sirada oldugunun bulunmasi
                for (int i = 0; i < secilenSehir.Length; i++)
                {
                    if (secilenSehir[i] == harf)
                    {
                        // Kelimedeki bulunan harf icin "_" yerine harfin yazilmasi
                        lbltahmin.Text = lbltahmin.Text.Remove(i * 2, 1).Insert(i * 2, harf.ToString());
                    }
                }
            }
            else
            {
                // Kelimede bulunan bir harf secilmezse hatayi arttirma ve kalan hakki azaltma
                hataSayaci++;
                label5.Text = (10 - hataSayaci).ToString();
            }

            if (label5.Text == "0")
            {
                // Oyun hakki 0 olunca oyunu sonlandirma ve tekrar oynamak istedigini sorma
                DialogResult dialogResult = MessageBox.Show("KAYBETTİNİZ !!!  Kelime: " + secilenSehir
                    + "  Tekrar Oynamak İster misiniz?" , "ADAM ASMACA" ,MessageBoxButtons.YesNo);


                if (dialogResult == DialogResult.Yes)
                {
                    // Kullanici evet derse butonlari tekrar aktif etme
                    foreach (Control btns in this.Controls)
                        if (btns is Button)
                            ((Button)btns).Enabled = true;
                   
                    lbltahmin.Text = ""; // Tahmin edilen harfleri sifirlama
                    hataSayaci = 0;  // Hata sayacini sifirlama

                    int rndmIndex = rndm.Next(sehirler.Length); // Yeni bir sehir secme
                    secilenSehir = sehirler[rndmIndex];
                    
                    // Secilen yeni kelime uzunlugu kadar tekrar "_" yazdirma
                    for (int i = 0; i < secilenSehir.Length; i++)
                    {
                        lbltahmin.Text = lbltahmin.Text + "_ ";
                    }
                    label5.Text = "10"; // Hak sayisini tekrar 10'a cekme
                }

                else {
                    // Eger kullanici hayir derse oyundan cikis
                    Application.Exit();
                }

            }
            
            if (lbltahmin.Text.Replace(" ", "") == secilenSehir)
            {
                // Kullanici sehri dogru bulursa oyunu sonlandirma ve tekrar oynamak istedigini sorma
                DialogResult dialogResult = MessageBox.Show("KAZANDINIZ !!!  Kelime: " + secilenSehir
                    + "  Tekrar Oynamak İster misiniz?", "ADAM ASMACA", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    // Kullanici evet derse butonlari tekrar aktif etme
                    foreach (Control btns in this.Controls)
                        if (btns is Button)
                            ((Button)btns).Enabled = true;

                    lbltahmin.Text = ""; // Tahmin edilen harfleri sifirlama
                    hataSayaci = 0; // Hata sayacini sifirlama

                    int rndmIndex = rndm.Next(sehirler.Length); // Yeni bir sehir secme
                    secilenSehir = sehirler[rndmIndex];

                    // Secilen yeni kelime uzunlugu kadar tekrar "_" yazdirma
                    for (int i = 0; i < secilenSehir.Length; i++)
                    {
                        lbltahmin.Text = lbltahmin.Text + "_ ";
                    }
                    label5.Text = "10";
                }

                else {
                    // Eger kullanici hayir derse oyundan cikis
                    Application.Exit();
                }
            }
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
