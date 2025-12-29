using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TikTakToe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sayac = 0; // X ve O'ların sırası için sayac değişkeni tanımlama
        string deger = ""; // atanacak degeri tanimlama

        // Butona hangi harfin yazılacağı
        public string Yazma()
        {
            // sayac 2'ye bölünebiliyorsa 
            if (sayac % 2 == 0)
            {
                deger = "X"; // deger X'tir
                label2.Text = "O"; // Sonraki harf için label2'ye O yazarız
            }

            // 2'ye bölünemiyorsa
            else
            {
                deger = "O"; // deger O'dur
                label2.Text = "X"; // Sonraki harf için label2'ye X yazarız
            }

            return deger; // deger'i döndürme
        }
        
        // Kazanma durumları için kontrol
        public void Kontrol()
        {
            // Kazanan durumları dizi içinde tutuyoruz
            int[][] kazananKombinasyonlar = new int[][]
            {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 },
            new int[] { 1, 4, 7 },
            new int[] { 2, 5, 8 },
            new int[] { 3, 6, 9 },
            new int[] { 1, 5, 9 },
            new int[] { 3, 5, 7 }
            };

            // Kazanan kombinasyonların sırasıyla butonlarını bulup işlem yapma
            foreach (var komb in kazananKombinasyonlar)
            {
                // groupBox içindeki butonları kazanan kombinasyonlardan sırasıyla değer gelcek şekilde bulup, atama
                Button b1 = (Button)groupBox1.Controls["button" + komb[0]];
                Button b2 = (Button)groupBox1.Controls["button" + komb[1]];
                Button b3 = (Button)groupBox1.Controls["button" + komb[2]];

                // Kazanan kombinasyonların butonları birbirine eşitse ve boş değillerse
                if (b1.Text != "" && b1.Text == b2.Text && b2.Text == b3.Text)
                {
                    // Kazanan X ise
                    if(b1.Text == "X")
                        b1.BackColor = b2.BackColor = b3.BackColor = Color.Red; // Kazanan butonların rengi kırmızı olur

                    // Kazanan O ise
                    else
                        b1.BackColor = b2.BackColor = b3.BackColor = Color.Green; // Kazanan butonların rengi yeşil olur
                    
                    OyunBitir(); // Oyun bitir metodunu çağırıyoruz
                    break; // döngüyü bitir
                }
            }

            // Tüm butonlar dolduysa ama kazanan kombinasyon olmadıysa yani sayac 8 olursa
            if (sayac == 8)
            { 
                OyunBitir(); // Oyun bitir metodunu çağırıyoruz
                sayac++; // sayac -1 ile başlayacağı ve if'ten sonra else'e girmeyeceği için sayacı bir arttırma
            }

            else // Oyun devam ediyorsa
                sayac++; // sayac'ı bir arttır
        }

        // Her bir butona tek tek kod yazmamak için toplu kod yazma metodu (hepsi seçilip olaylar kısmından click'e tıklanır)
        private void Oyun(object sender, EventArgs e)
        {
            Button secilenButton = sender as Button; // Tıklanan butonu bulma
            secilenButton.Enabled = false; // Tıklanan butonu tekrar tıklanmayacak hale getirme

            secilenButton.Text = Yazma(); // Tıklanan butona Yazma metodundaki değeri atarız

            Kontrol(); // Kontrol metodunu çağırıyoruz
        }
        
        // Oyunu bitirmek ya da tekrar başlatmak için metod
        public void OyunBitir()
        {
            // Message Box ile oyunu bitti çıktısı verme ve soru sorma
            DialogResult dialogResult = MessageBox.Show("OYUN BİTTİ !!! " + "Tekrar Oynamak İster misiniz?", "TIK TAK TOE", MessageBoxButtons.YesNo);
            
            if (dialogResult == DialogResult.Yes) // Tekrar oynamak ister misiniz?' e evet derse
            {
                foreach (Control btns in groupBox1.Controls) // groupBox içindeki tüm bileşenleri döner
                {
                    if (btns is Button button) // Bileşen butonsa, döngü devam ettikçe bütün buton olanlara bu işlemi uygular
                    {
                        button.Enabled = true; // Butonun tıklanabilme özelliğini açma
                        button.BackColor = DefaultBackColor; // Butonun rengini eski haline getirme
                        button.Text = ""; // Butondaki text'i temizleme
                    }
                    
                    label2.Text = "X"; // Sonraki harf'i tekrar X'e getirme
                    sayac = -1; // Sayac'ı sıfırlama, -1'den başlatma sebebimiz Döngü içinde OyunBitir metodunu çağırıyoruz
                    // fakat döngüden çıktıktan sonra oyun bitse dahi program tekrar başladığında sayac 1 artıp ondan sonra 
                    // devam ettiği için -1'den başlamalı
                }
            }
            else // Tekrar oynamak ister misiniz?' e hayır derse
                Application.Exit(); // Programı kapat
        }
    }
}
