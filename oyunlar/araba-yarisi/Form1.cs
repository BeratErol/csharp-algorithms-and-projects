using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRaceGame
{
    public partial class Form1 : Form
    {
        int yolHizi, trafikHizi; // Yol ve trafik hızları
        int oyuncuHizi = 12; // Oyuncunun hareket hızı
        int skor, arabaGorseli; // Skor ve araba görsel seçimi

        Random rnd = new Random(); // Rastgele sayı üretici
        Random arabaPozisyonu = new Random(); // Arabaların pozisyonu için rastgele sayı üretici

        bool sagaGit, solaGit; // Oyuncunun sağa ve sola hareket kontrolü

        public Form1()
        {
            InitializeComponent();
            OyunuYenileme(); // Oyunun başlangıç durumunu ayarla

            // Klavye olaylarını bağlama
            this.KeyDown += new KeyEventHandler(solOkBasildi);
            this.KeyDown += new KeyEventHandler(sagOkBasildi);
            this.KeyUp += new KeyEventHandler(solOkBirakildi);
            this.KeyUp += new KeyEventHandler(sagOkBirakildi);

            // Zamanlayıcıya olay bağlama
            oyunZamanlayicisi.Tick += new EventHandler(oyunZamanlayicisiEvent);
        }

        // Sol ok tuşuna basıldığında sola gitmek için bayrak ayarla
        private void solOkBasildi(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                solaGit = true;
            }
        }

        // Sağ ok tuşuna basıldığında sağa gitmek için bayrak ayarla
        private void sagOkBasildi(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                sagaGit = true;
            }
        }

        // Sol ok tuşu bırakıldığında sola gitmeyi durdur
        private void solOkBirakildi(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                solaGit = false;
            }
        }

        // Sağ ok tuşu bırakıldığında sağa gitmeyi durdur
        private void sagOkBirakildi(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                sagaGit = false;
            }
        }

        // Zamanlayıcı tarafından çağrılan olay
        private void oyunZamanlayicisiEvent(object sender, EventArgs e)
        {
            txtSkor.Text = "Skor: " + skor; // Skor güncelle
            skor++; // Skoru artır

            // Oyuncunun hareketi
            if (solaGit && oyuncu.Left > 10)
            {
                oyuncu.Left -= oyuncuHizi;
            }
            if (sagaGit && oyuncu.Left < 380)
            {
                oyuncu.Left += oyuncuHizi;
            }

            // Yol animasyonu
            yol1.Top += yolHizi;
            yol2.Top += yolHizi;

            if (yol2.Top > 300)
            {
                yol2.Top = -300; // Yol döngüsü
            }
            if (yol1.Top > 300)
            {
                yol1.Top = -300; // Yol döngüsü
            }

            // Trafik hareketi
            Bot1.Top += trafikHizi;
            Bot2.Top += trafikHizi;

            // Arabaları yeniden pozisyonla
            if (Bot1.Top > 520)
            {
                BotDegistirme(Bot1);
            }

            if (Bot2.Top > 520)
            {
                BotDegistirme(Bot2);
            }

            // Çarpışma kontrolü
            if (oyuncu.Bounds.IntersectsWith(Bot1.Bounds) || oyuncu.Bounds.IntersectsWith(Bot2.Bounds))
            {
                OyunSonu(); // Çarpışma durumunda oyunu bitir
            }

            // Skora göre ödülleri ve zorluk seviyesini ayarla
            if (skor > 40 && skor < 500)
            {
                odul.Image = Properties.Resources.bronze; // Bronz ödül
            }

            if (skor > 500 && skor < 2000)
            {
                odul.Image = Properties.Resources.silver; // Gümüş ödül
                yolHizi = 20;
                trafikHizi = 22;
            }

            if (skor > 2000)
            {
                odul.Image = Properties.Resources.gold; // Altın ödül
                trafikHizi = 27;
                yolHizi = 25;
            }
        }

        // Arabaları yeniden pozisyonlamak ve rastgele görsel seçmek için kullanılan metod
        private void BotDegistirme(PictureBox tempAraba)
        {
            arabaGorseli = rnd.Next(1, 9); // Rastgele araba görseli seç

            // Görseli ayarla
            switch (arabaGorseli)
            {
                case 1:
                    tempAraba.Image = Properties.Resources.ambulance;
                    break;
                case 2:
                    tempAraba.Image = Properties.Resources.carGreen;
                    break;
                case 3:
                    tempAraba.Image = Properties.Resources.carGrey;
                    break;
                case 4:
                    tempAraba.Image = Properties.Resources.carOrange;
                    break;
                case 5:
                    tempAraba.Image = Properties.Resources.carPink;
                    break;
                case 6:
                    tempAraba.Image = Properties.Resources.CarRed;
                    break;
                case 7:
                    tempAraba.Image = Properties.Resources.carYellow;
                    break;
                case 8:
                    tempAraba.Image = Properties.Resources.TruckBlue;
                    break;
                case 9:
                    tempAraba.Image = Properties.Resources.TruckWhite;
                    break;
            }

            // Yeni pozisyon belirle
            tempAraba.Top = arabaPozisyonu.Next(100, 400) * -1;

            if ((string)tempAraba.Tag == "solAraba")
            {
                tempAraba.Left = arabaPozisyonu.Next(4, 200); // Sol şerit
            }
            if ((string)tempAraba.Tag == "sagAraba")
            {
                tempAraba.Left = arabaPozisyonu.Next(245, 360); // Sağ şerit
            }
        }

        // Oyunu yeniden başlat
        private void OyunuYenile(object sender, EventArgs e)
        {
            OyunuYenileme();
        }

        // Oyun sona erdiğinde yapılacak işlemler
        private void OyunSonu()
        {
            OyunSesi(); // Çarpışma sesi çal
            oyunZamanlayicisi.Stop(); // Zamanlayıcıyı durdur
            patlama.Visible = true; // Patlama animasyonunu göster
            oyuncu.Controls.Add(patlama); // Patlama efektini oyuncunun üzerinde göster
            patlama.Location = new Point(-8, 5);
            patlama.BackColor = Color.Transparent;

            odul.Visible = true; // Ödül göster
            odul.BringToFront(); // Ödülü öne getir

            btnBasla.Enabled = true; // Başla butonunu aktif et
        }

        // Oyunun başlangıç ayarlarını yap
        private void OyunuYenileme()
        {
            btnBasla.Enabled = false;
            patlama.Visible = false;
            odul.Visible = false;
            sagaGit = false;
            solaGit = false;
            skor = 0;
            odul.Image = Properties.Resources.bronze;

            yolHizi = 12;
            trafikHizi = 15;

            Bot1.Top = arabaPozisyonu.Next(200, 500) * -1;
            Bot1.Left = arabaPozisyonu.Next(4, 239);

            Bot2.Top = arabaPozisyonu.Next(200, 500) * -1;
            Bot2.Left = arabaPozisyonu.Next(305, 510);

            oyunZamanlayicisi.Start(); // Zamanlayıcıyı başlat
        }

        // Çarpışma sesi çal
        private void OyunSesi()
        {
            System.Media.SoundPlayer playCrash = new System.Media.SoundPlayer(Properties.Resources.hit);
            playCrash.Play();
        }
    }
}
