using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MineSweeper
{
    public partial class Form1 : Form
    {
        HashSet<Point> mayınlar = new HashSet<Point>(); // Mayınların konumlarını tutar
        HashSet<Point> bosAlanlar = new HashSet<Point>(); // Boş alanların konumlarını tutar
        Random rastgele = new Random(); // Rastgele sayı üreticisi
        int mayınYok = 0; // Tıklanan mayın olmayan buton sayısı
        int toplamMayın = 80; // Oyundaki toplam mayın sayısı
        int yerleştirilenMayın = 0; // Yerleştirilen mayın sayısı
        int mayınKoy = 0; // Mayın yerleştirip yerleştirmeyeceğini belirleyen değişken
        int ilkTıklama = 0; // İlk tıklamanın yapılıp yapılmadığını kontrol eder
        bool renk = true; // Butonların rengini değiştirir
        int süre = 0;  // Süreyi tutacak değişken

        public Form1()
        {
            InitializeComponent();
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick); // Timer'ın her tick'inde süreyi arttırır
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            butonlarıEkle(); // Form yüklendiğinde butonları ekler
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            süre++;  // Süreyi bir arttır
            süreLabel.Text = "Süre: " + süre.ToString() + " saniye";  // Süreyi label'da göster
        }

        public void butonlarıEkle()
        {
            for (int x = 0; x < panel1.Width; x += 25)
            {
                renk = !renk; // Her satırda renk değişir
                for (int y = 0; y < panel1.Height; y += 25)
                {
                    yeniButon(new Point(x, y), renk); // Yeni buton ekler
                    renk = !renk; // Renk değiştirir
                }
            }
            toplamMayınLabel.Text = ("Toplam Mayın: " + yerleştirilenMayın.ToString()); // Toplam mayın sayısını gösterir
        }

        public void yeniButon(Point konum, bool rengi)
        {
            Button btn = new Button(); // Yeni bir buton oluşturur
            btn.Name = "mayın" + konum.X + konum.Y;
            btn.Size = new Size(25, 25);
            btn.Location = (konum);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            if (renk) btn.BackColor = Color.DarkOrange; // Renkli buton arka planı
            else btn.BackColor = Color.Chocolate;
            btn.Cursor = Cursors.Hand; // El simgesi ekler

            mayınKoy = rastgele.Next(0, 100); // Mayın yerleştirme olasılığı
            if (yerleştirilenMayın < toplamMayın && mayınKoy < 14)
            {
                btn.Tag = true; // Butona mayın yerleştirilmişse, tag'e true koyar
                yerleştirilenMayın++; // Yerleştirilen mayın sayısını arttırır
                mayınlar.Add(btn.Location); // Mayınların konumunu kaydeder
            }
            else btn.Tag = false; // Mayın yoksa tag'e false koyar
            btn.Click += new EventHandler(btnTıkla); // Buton tıklandığında btnTıkla fonksiyonu çalışır
            btn.MouseDown += new MouseEventHandler(btnSağTıkla); // Sağ tıklandığında btnSağTıkla fonksiyonu çalışır
            panel1.Controls.Add(btn); // Butonu panel1'e ekler
        }

        void btnTıkla(object sender, EventArgs e)
        {
            mayınYok++; // Mayın olmayan bir butona tıklandığında sayacı arttırır
            kalanHamleLabel.Text = ("Kalan Hücre: " + (400 - yerleştirilenMayın - mayınYok).ToString()); // Kalan hücreyi gösterir
            if (mayınYok == 400 - yerleştirilenMayın)
            {
                MessageBox.Show("Oyunu Kazandınız", "Oyun Bitti!", MessageBoxButtons.OK, MessageBoxIcon.Information); // Kazanma mesajı
                YenidenBaslat(); // Oyunu yeniden başlatır
                return;
            }
            Button btn = (sender as Button);
            if (ilkTıklama == 0)
            {
                if ((bool)btn.Tag) // İlk tıklamada mayına tıklanırsa, mayın yerleştirilir
                {
                    yerleştirilenMayın--;
                    toplamMayınLabel.Text = ("Toplam Mayın: " + yerleştirilenMayın.ToString());
                    btn.Tag = false;
                }
            }
            if ((bool)btn.Tag) // Mayına tıklandığında oyunu kaybettirir
            {
                MayınlarıGöster(); // Mayınları gösterir
                MessageBox.Show("Oyunu Kaybettiniz", "Oyun Bitti!", MessageBoxButtons.OK, MessageBoxIcon.Warning); // Kaybetme mesajı
                YenidenBaslat(); // Oyunu yeniden başlatır
            }
            else
            {
                btn.BackColor = Color.FromArgb(180, 180, 180); // Mayın olmayan butonun rengini değiştirir
                int etrafMayınSayısı = etrafındakiMayınlar(btn.Location); // Etrafındaki mayınları sayar
                if (etrafMayınSayısı != 0) btn.Text = etrafMayınSayısı.ToString(); // Etrafında mayın varsa sayıyı yazar
                btn.Enabled = false; // Butonu devre dışı bırakır
            }
        }

        void btnSağTıkla(object sender, MouseEventArgs e)
        {
            Button btn = (sender as Button);

            if (e.Button == MouseButtons.Right) // Sağ tıklama olursa, butonun üzerine 'X' ekler veya kaldırır
            {
                if (btn.Text.Equals("X")) btn.Text = "";
                else btn.Text = "X";
            }
        }

        void MayınlarıGöster()
        {
            foreach (Point konum in mayınlar) // Mayınların bulunduğu butonları 'X' ile gösterir
            {
                Button btn = panel1.Controls.OfType<Button>().FirstOrDefault(b => b.Location == konum);
                btn.Text = "X";
            }
        }

        public int etrafındakiMayınlar(Point konum)
        {
            if (bosAlanlar.Contains(konum)) return 0; // Zaten kontrol edilmişse 0 döner

            bosAlanlar.Add(konum); // Alanı kontrol edilmiş olarak işaretler

            int etraftakiMayın = 0;

            int[] komsuX = { -25, 0, 25 }; // X yönündeki komşular
            int[] komsuY = { -25, 0, 25 }; // Y yönündeki komşular

            foreach (int komsununX in komsuX)
            {
                foreach (int komsununY in komsuY)
                {
                    if (komsununX == 0 && komsununY == 0) continue; // Kendisine bakmasın

                    Point komsuKonum = new Point(konum.X + komsununX, konum.Y + komsununY); // Komşu noktayı hesaplar

                    Button komsuButon = panel1.Controls.OfType<Button>().FirstOrDefault(b => b.Location == komsuKonum); // Komşu butonu bulur

                    if (komsuButon != null && (bool)komsuButon.Tag) etraftakiMayın++; // Komşuda mayın varsa sayıyı arttırır
                }
            }
            if (etraftakiMayın == 0) // Etrafında mayın yoksa, komşuları tıklatır
            {
                ilkTıklama++;
                foreach (int komsununX in komsuX)
                {
                    foreach (int komsununY in komsuY)
                    {
                        if (komsununX == 0 && komsununY == 0) continue;

                        Point komsuKonum = new Point(konum.X + komsununX, konum.Y + komsununY);

                        Button komsuButon = panel1.Controls.OfType<Button>().FirstOrDefault(b => b.Location == komsuKonum);

                        if (komsuButon != null && !bosAlanlar.Contains(komsuKonum)) komsuButon.PerformClick(); // Komşu butonları otomatik tıklar
                    }
                }
            }
            return etraftakiMayın; // Etrafındaki mayın sayısını döner
        }

        public void YenidenBaslat()
        {
            mayınYok = 0; // Mayın olmayan buton sayısını sıfırlar
            yerleştirilenMayın = 0; // Yerleştirilen mayın sayısını sıfırlar
            ilkTıklama = 0; // İlk tıklamayı sıfırlar
            süre = 0;  // Süreyi sıfırlar
            mayınlar.Clear(); // Mayınlar listesini temizler
            bosAlanlar.Clear(); // Boş alanlar listesini temizler
            panel1.Controls.Clear(); // Paneldeki tüm kontrolleri temizler
            butonlarıEkle(); // Yeni butonları ekler
            kalanHamleLabel.Text = ("Kalan Hücre: " + (400 - yerleştirilenMayın - mayınYok).ToString()); // Kalan hücreyi günceller
            süreLabel.Text = "Süre: 0 saniye";  // Süreyi sıfırlar
        }
    }
}