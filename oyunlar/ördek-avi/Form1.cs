using System;
using System.Drawing;
using System.Windows.Forms;

namespace AimLabOrdek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random rnd = new Random(); // Ördeğin konumu için rastgele sayı üretir.
        int sure = 15; // Oyun süresi
        int toplamTik = 0; // Form üzerine ve ördeğe yapılan tıklama sayısı.
        int isabetliTik = 0; // Ördeğe yapılan tıklama sayısı.
        int puan = 0; // Alınan puanın tutulacağı alan.

        private void Form1_Load_1(object sender, EventArgs e)
        {
            pnlstart.Dock = DockStyle.Fill; // Başlangıç paneli form boyutunu alır.
            lblsure.Visible = false;
            pnlsonuc.Hide(); // Sonuç panelini gizler.
        }

        // Oyunu başlatan buton (groupControl1 içindeki buton)
        private void btnstart_Click(object sender, EventArgs e)
        {
            pnlstart.Hide(); // Başlangıç panelini gizler.
            lblsure.Visible = true;

            timersure.Interval = 1000; // timersure_tick fonksiyonu 1 saniyede bir tekrarlanır.
            timersure.Start(); // Timer çalışmaya başlar.

            timerLoc.Start(); // Ördeğin rastgele konumlara gitmesini sağlayan timer'ı başlatır.

            // groupControl1 içindeki radyo butonlarını kontrol et
            if (groupControl1.Controls.Contains(rbtnkolay) && rbtnkolay.Checked)
            {
                timerLoc.Interval = 700; // Kolay seviyesindeki timer çalışma hızı.
            }
            else if (groupControl1.Controls.Contains(rbtnorta) && rbtnorta.Checked)
            {
                timerLoc.Interval = 600; // Orta seviyesindeki timer çalışma hızı.
            }
            else if (groupControl1.Controls.Contains(rbtnzor) && rbtnzor.Checked)
            {
                timerLoc.Interval = 500; // Zor seviyesindeki timer çalışma hızı.
            }
        }

        // Geri sayım fonksiyonunun gerçekleştiği alan (timer)
        private void timersure_Tick_1(object sender, EventArgs e)
        {
            lblsure.Text = "Süre : " + sure;

            if (sure == 0) // Süre bittiği zaman gerçekleşen fonksiyonlar.
            {
                timersure.Stop();
                timerLoc.Stop();

                pnlsonuc.Dock = DockStyle.Fill;
                pnlsonuc.Show();
                lblsure.Visible = false;

                toplamTik += isabetliTik;

                lbltoplamtik.Text = "Toplam Tıklama : " + toplamTik;
                lblisabetlitik.Text = "İsabetli Tıklama : " + isabetliTik;
                lblpuan.Text = "Puan : " + puan;
            }
            sure--;
        }

        // Ördeğin (picturebox) form içerisinde rastgele konumlandığı alan
        private void timerLoc_Tick_1(object sender, EventArgs e)
        {
            ordek.Location = new Point(rnd.Next(10, 800), rnd.Next(10, 300));
        }

        // Ördeğe tıklandığında gerçekleşecek işlemler.
        private void ordek_Click_1(object sender, EventArgs e)
        {
            isabetliTik++;
            puan += 5;
        }

        // Form üzerine yapılan tıklamaları sayan fonksiyon.
        private void Form1_MouseClick_1(object sender, MouseEventArgs e)
        {
            toplamTik++;
        }

        // Oyunu yeniden başlatan buton (groupControl1 içindeki bileşenlere göre düzenlendi)
        private void btnrestart_Click_1(object sender, EventArgs e)
        {
            sure = 10;
            toplamTik = 0;
            isabetliTik = 0;
            puan = 0;

            // Oyun yeniden başlatıldığında groupControl1 içindeki kolay butonunun seçili olması sağlanır.
            if (groupControl1.Controls.Contains(rbtnkolay))
            {
                rbtnkolay.Checked = true;
            }

            pnlsonuc.Hide();
            pnlstart.Show();

            // Ördeği başlangıç konumuna getir.
            ordek.Location = new Point(413,101);

            lblsure.Text = "Av Başlıyor...";
        }
    }
}
