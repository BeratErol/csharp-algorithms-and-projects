using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _FlappyBird
{
    public partial class Form1 : Form
    {
        int pipeSpeed = 7; // Boruların hareket hızı
        int gravity = 5; // Kuşun düşme hızı (yer çekimi)
        int score = 0; // Oyuncunun skoru

        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimerEvent(object sender, EventArgs e)
        {
            bird.Top += gravity; // Kuşun düşmesini sağlıyor (yer çekimi etkisi)

            pipeDown.Left -= pipeSpeed; // Alt borunun sola hareket etmesini sağlıyor
            pipeDown2.Left -= pipeSpeed; // Alt 2. borunun sola hareket etmesini sağlıyor
            pipeDown3.Left -= pipeSpeed; // Alt 3. borunun sola hareket etmesini sağlıyor
            pipeDown4.Left -= pipeSpeed; // Alt 4. borunun sola hareket etmesini sağlıyor
            
            pipeUp.Left -= pipeSpeed; // Üst borunun sola hareket etmesini sağlıyor
            pipeUp2.Left -= pipeSpeed; // Üst 2. borunun sola hareket etmesini sağlıyor
            pipeUp3.Left -= pipeSpeed; // Üst 3. borunun sola hareket etmesini sağlıyor
            pipeUp4.Left -= pipeSpeed; // Üst 4. borunun sola hareket etmesini sağlıyor

            scoreLabel.Text = "SKOR: " + score; // Skoru ekranda güncelleme

            if (pipeDown.Left < -150) // Eğer alt boru ekrandan çıktıysa
            {
                pipeDown.Left = 600; // Alt boruyu sağdan yeniden getir
                score++; // Skoru artır
            }

            if (pipeDown2.Left < -150) // Eğer alt boru ekrandan çıktıysa
            {
                pipeDown2.Left = 600; // 2. alt boruyu sağdan yeniden getir
                score++; // Skoru artır
            }

            if (pipeDown3.Left < -150) // Eğer alt boru ekrandan çıktıysa
            {
                pipeDown3.Left = 600; // 3. alt boruyu sağdan yeniden getir
                score++; // Skoru artır
            }

            if (pipeDown4.Left < -150) // Eğer alt boru ekrandan çıktıysa
            {
                pipeDown4.Left = 600; // 4. alt boruyu sağdan yeniden getir
                score++; // Skoru artır
            }

            if (pipeUp.Left < -150) // Eğer üst boru ekrandan çıktıysa
            {
                pipeUp.Left = 600; // Üst boruyu sağdan yeniden getir
            }

            if (pipeUp2.Left < -150) // Eğer üst boru ekrandan çıktıysa
            {
                pipeUp2.Left = 600; // 2. üst boruyu sağdan yeniden getir
            }

            if (pipeUp3.Left < -150) // Eğer üst boru ekrandan çıktıysa
            {
                pipeUp3.Left = 600; // 3. üst boruyu sağdan yeniden getir
            }

            if (pipeUp4.Left < -150) // Eğer üst boru ekrandan çıktıysa
            {
                pipeUp4.Left = 600; // 4. üst boruyu sağdan yeniden getir
            }

            // Kuşun herhangi bir boruya veya zemine çarpıp çarpmadığını, ekranın üst kısmına geçip geçmediğini kontrol ediyor
            if (bird.Bounds.IntersectsWith(pipeDown.Bounds) | bird.Bounds.IntersectsWith(pipeDown2.Bounds) | bird.Bounds.IntersectsWith(pipeDown3.Bounds) | bird.Bounds.IntersectsWith(pipeDown4.Bounds) | bird.Bounds.IntersectsWith(pipeUp.Bounds) | bird.Bounds.IntersectsWith(pipeUp2.Bounds) | bird.Bounds.IntersectsWith(pipeUp3.Bounds) | bird.Bounds.IntersectsWith(pipeUp4.Bounds) | bird.Bounds.IntersectsWith(ground.Bounds) | bird.Top < -25)
            {
                endGame();
            }

            // Eğer skor 5'ten büyükse boruların hızını artır
            if (score > 5)
            {
                pipeSpeed = 10;
            }

            // Eğer skor 20'den büyükse boruların hızını daha da artır
            if (score > 20)
            {
                pipeSpeed = 13;
            }

            // Eğer skor 50'den büyükse boruların hızını daha fazla artır
            if (score > 50)
            {
                pipeSpeed = 16;
            }

            // Eğer skor 100'den büyükse boruların hızını maksimuma çıkar
            if (score > 100)
            {
                pipeSpeed = 20;
            }
        }
        
        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            // Eğer boşluk tuşuna basılırsa kuş yukarı doğru hareket eder
            if (e.KeyCode == Keys.Space)
            {
                gravity = -17; // Kuş yukarı hareket eder
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            // Eğer boşluk tuşu bırakılırsa kuş tekrar aşağı düşmeye başlar
            if (e.KeyCode == Keys.Space)
            {
                gravity = 5; // Kuş aşağı düşer
            }
        }

        private void endGame()
        {
            gameTimer.Stop(); // Oyun zamanlayıcısını durdur
            DialogResult dialogResult = MessageBox.Show(" Oyun Bitti !!! Tekrar Oynamak İster misin ?", "SKORUNUZ: " + score, MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                resetGame(); // Eğer oyuncu tekrar oynamak isterse oyunu sıfırla
            }

            else
            {
                Application.Exit(); // Eğer oyuncu hayır derse uygulamadan çık
            }
        }

        private void resetGame()
        {
            // Kuşu başlangıç pozisyonuna getiriyoruz
            bird.Top = 150;
            bird.Left = 100;

            // Boruları başlangıç pozisyonuna getiriyoruz
            pipeDown.Left = 600;
            pipeDown2.Left = 800;
            pipeDown3.Left = 1000;
            pipeDown4.Left = 1200;
            pipeUp.Left = 600;
            pipeUp2.Left = 800;
            pipeUp3.Left = 1000;
            pipeUp4.Left = 1200;

            // Skoru sıfırlıyoruz
            score = 0;
            scoreLabel.Text = "SKOR: " + score;

            // Oyun hızlarını eski haline getiriyoruz
            pipeSpeed = 7;
            gravity = 5;

            // Timer'ı tekrar başlatıyoruz
            gameTimer.Start();
        }
    }
}

