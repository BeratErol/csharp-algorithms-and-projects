namespace CarRaceGame
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.patlama = new System.Windows.Forms.PictureBox();
            this.odul = new System.Windows.Forms.PictureBox();
            this.Bot2 = new System.Windows.Forms.PictureBox();
            this.Bot1 = new System.Windows.Forms.PictureBox();
            this.oyuncu = new System.Windows.Forms.PictureBox();
            this.yol2 = new System.Windows.Forms.PictureBox();
            this.yol1 = new System.Windows.Forms.PictureBox();
            this.txtSkor = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBasla = new System.Windows.Forms.Button();
            this.oyunZamanlayicisi = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patlama)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.odul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyuncu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.patlama);
            this.panel1.Controls.Add(this.odul);
            this.panel1.Controls.Add(this.Bot2);
            this.panel1.Controls.Add(this.Bot1);
            this.panel1.Controls.Add(this.oyuncu);
            this.panel1.Controls.Add(this.yol2);
            this.panel1.Controls.Add(this.yol1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 566);
            this.panel1.TabIndex = 0;
            // 
            // patlama
            // 
            this.patlama.BackColor = System.Drawing.Color.Black;
            this.patlama.Image = global::CarRaceGame.Properties.Resources.explosion;
            this.patlama.Location = new System.Drawing.Point(110, 422);
            this.patlama.Name = "patlama";
            this.patlama.Size = new System.Drawing.Size(64, 64);
            this.patlama.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.patlama.TabIndex = 9;
            this.patlama.TabStop = false;
            // 
            // odul
            // 
            this.odul.BackColor = System.Drawing.Color.Black;
            this.odul.Image = global::CarRaceGame.Properties.Resources.bronze;
            this.odul.Location = new System.Drawing.Point(136, 127);
            this.odul.Name = "odul";
            this.odul.Size = new System.Drawing.Size(250, 100);
            this.odul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.odul.TabIndex = 8;
            this.odul.TabStop = false;
            // 
            // Bot2
            // 
            this.Bot2.BackColor = System.Drawing.Color.Black;
            this.Bot2.Image = global::CarRaceGame.Properties.Resources.carOrange;
            this.Bot2.Location = new System.Drawing.Point(520, 115);
            this.Bot2.Name = "Bot2";
            this.Bot2.Size = new System.Drawing.Size(50, 100);
            this.Bot2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Bot2.TabIndex = 7;
            this.Bot2.TabStop = false;
            this.Bot2.Tag = "sagAraba";
            // 
            // Bot1
            // 
            this.Bot1.BackColor = System.Drawing.Color.Black;
            this.Bot1.Image = global::CarRaceGame.Properties.Resources.ambulance;
            this.Bot1.Location = new System.Drawing.Point(66, 115);
            this.Bot1.Name = "Bot1";
            this.Bot1.Size = new System.Drawing.Size(50, 100);
            this.Bot1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Bot1.TabIndex = 6;
            this.Bot1.TabStop = false;
            this.Bot1.Tag = "solAraba";
            // 
            // oyuncu
            // 
            this.oyuncu.BackColor = System.Drawing.Color.Black;
            this.oyuncu.Image = global::CarRaceGame.Properties.Resources.carPink;
            this.oyuncu.Location = new System.Drawing.Point(271, 422);
            this.oyuncu.Name = "oyuncu";
            this.oyuncu.Size = new System.Drawing.Size(50, 100);
            this.oyuncu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.oyuncu.TabIndex = 5;
            this.oyuncu.TabStop = false;
            // 
            // yol2
            // 
            this.yol2.Image = global::CarRaceGame.Properties.Resources.roadTrack;
            this.yol2.Location = new System.Drawing.Point(0, 566);
            this.yol2.Name = "yol2";
            this.yol2.Size = new System.Drawing.Size(573, 566);
            this.yol2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yol2.TabIndex = 4;
            this.yol2.TabStop = false;
            // 
            // yol1
            // 
            this.yol1.Image = global::CarRaceGame.Properties.Resources.roadTrack;
            this.yol1.Location = new System.Drawing.Point(0, -566);
            this.yol1.Name = "yol1";
            this.yol1.Size = new System.Drawing.Size(573, 566);
            this.yol1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yol1.TabIndex = 0;
            this.yol1.TabStop = false;
            // 
            // txtSkor
            // 
            this.txtSkor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSkor.Location = new System.Drawing.Point(8, 581);
            this.txtSkor.Name = "txtSkor";
            this.txtSkor.Size = new System.Drawing.Size(577, 37);
            this.txtSkor.TabIndex = 1;
            this.txtSkor.Text = "Skor: 0";
            this.txtSkor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 677);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(573, 99);
            this.label2.TabIndex = 2;
            this.label2.Text = "Arabayı hareket ettirmek için sağ veya sol yön tuşlarına\r\n basın.\r\n\r\nHiçbir araba" +
    "ya çarpamadan hayatta kalmaya çalış !\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBasla
            // 
            this.btnBasla.BackColor = System.Drawing.Color.LawnGreen;
            this.btnBasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBasla.Location = new System.Drawing.Point(148, 621);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(298, 35);
            this.btnBasla.TabIndex = 3;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = false;
            this.btnBasla.Click += new System.EventHandler(this.OyunuYenile);
            // 
            // oyunZamanlayicisi
            // 
            this.oyunZamanlayicisi.Interval = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(594, 785);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSkor);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ARABA YARIŞI";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.solOkBasildi);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.sagOkBasildi);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patlama)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.odul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyuncu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yol1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox yol1;
        private System.Windows.Forms.Label txtSkor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.PictureBox patlama;
        private System.Windows.Forms.PictureBox odul;
        private System.Windows.Forms.PictureBox Bot2;
        private System.Windows.Forms.PictureBox Bot1;
        private System.Windows.Forms.PictureBox oyuncu;
        private System.Windows.Forms.Timer oyunZamanlayicisi;
        private System.Windows.Forms.PictureBox yol2;
    }
}

