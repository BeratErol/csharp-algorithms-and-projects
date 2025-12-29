namespace _FlappyBird
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
            this.bird = new System.Windows.Forms.PictureBox();
            this.pipeUp = new System.Windows.Forms.PictureBox();
            this.ground = new System.Windows.Forms.PictureBox();
            this.pipeDown = new System.Windows.Forms.PictureBox();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pipeDown2 = new System.Windows.Forms.PictureBox();
            this.pipeUp2 = new System.Windows.Forms.PictureBox();
            this.pipeUp3 = new System.Windows.Forms.PictureBox();
            this.pipeDown3 = new System.Windows.Forms.PictureBox();
            this.pipeDown4 = new System.Windows.Forms.PictureBox();
            this.pipeUp4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp4)).BeginInit();
            this.SuspendLayout();
            // 
            // bird
            // 
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.Location = new System.Drawing.Point(59, 148);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(95, 69);
            this.bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bird.TabIndex = 0;
            this.bird.TabStop = false;
            // 
            // pipeUp
            // 
            this.pipeUp.Image = ((System.Drawing.Image)(resources.GetObject("pipeUp.Image")));
            this.pipeUp.Location = new System.Drawing.Point(447, 0);
            this.pipeUp.Name = "pipeUp";
            this.pipeUp.Size = new System.Drawing.Size(100, 137);
            this.pipeUp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeUp.TabIndex = 1;
            this.pipeUp.TabStop = false;
            // 
            // ground
            // 
            this.ground.Image = ((System.Drawing.Image)(resources.GetObject("ground.Image")));
            this.ground.Location = new System.Drawing.Point(0, 522);
            this.ground.Name = "ground";
            this.ground.Size = new System.Drawing.Size(1256, 122);
            this.ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ground.TabIndex = 2;
            this.ground.TabStop = false;
            // 
            // pipeDown
            // 
            this.pipeDown.Image = ((System.Drawing.Image)(resources.GetObject("pipeDown.Image")));
            this.pipeDown.Location = new System.Drawing.Point(447, 377);
            this.pipeDown.Name = "pipeDown";
            this.pipeDown.Size = new System.Drawing.Size(100, 147);
            this.pipeDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown.TabIndex = 3;
            this.pipeDown.TabStop = false;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.BackColor = System.Drawing.Color.GhostWhite;
            this.scoreLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.scoreLabel.Location = new System.Drawing.Point(59, 580);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(156, 40);
            this.scoreLabel.TabIndex = 4;
            this.scoreLabel.Text = "SKOR: 0";
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // pipeDown2
            // 
            this.pipeDown2.Image = ((System.Drawing.Image)(resources.GetObject("pipeDown2.Image")));
            this.pipeDown2.Location = new System.Drawing.Point(685, 418);
            this.pipeDown2.Name = "pipeDown2";
            this.pipeDown2.Size = new System.Drawing.Size(100, 106);
            this.pipeDown2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown2.TabIndex = 5;
            this.pipeDown2.TabStop = false;
            // 
            // pipeUp2
            // 
            this.pipeUp2.Image = ((System.Drawing.Image)(resources.GetObject("pipeUp2.Image")));
            this.pipeUp2.Location = new System.Drawing.Point(685, 0);
            this.pipeUp2.Name = "pipeUp2";
            this.pipeUp2.Size = new System.Drawing.Size(100, 196);
            this.pipeUp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeUp2.TabIndex = 6;
            this.pipeUp2.TabStop = false;
            // 
            // pipeUp3
            // 
            this.pipeUp3.Image = ((System.Drawing.Image)(resources.GetObject("pipeUp3.Image")));
            this.pipeUp3.Location = new System.Drawing.Point(930, 0);
            this.pipeUp3.Name = "pipeUp3";
            this.pipeUp3.Size = new System.Drawing.Size(100, 83);
            this.pipeUp3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeUp3.TabIndex = 7;
            this.pipeUp3.TabStop = false;
            // 
            // pipeDown3
            // 
            this.pipeDown3.Image = ((System.Drawing.Image)(resources.GetObject("pipeDown3.Image")));
            this.pipeDown3.Location = new System.Drawing.Point(930, 371);
            this.pipeDown3.Name = "pipeDown3";
            this.pipeDown3.Size = new System.Drawing.Size(100, 153);
            this.pipeDown3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown3.TabIndex = 8;
            this.pipeDown3.TabStop = false;
            // 
            // pipeDown4
            // 
            this.pipeDown4.Image = ((System.Drawing.Image)(resources.GetObject("pipeDown4.Image")));
            this.pipeDown4.Location = new System.Drawing.Point(1156, 404);
            this.pipeDown4.Name = "pipeDown4";
            this.pipeDown4.Size = new System.Drawing.Size(100, 120);
            this.pipeDown4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeDown4.TabIndex = 9;
            this.pipeDown4.TabStop = false;
            // 
            // pipeUp4
            // 
            this.pipeUp4.Image = ((System.Drawing.Image)(resources.GetObject("pipeUp4.Image")));
            this.pipeUp4.Location = new System.Drawing.Point(1156, 0);
            this.pipeUp4.Name = "pipeUp4";
            this.pipeUp4.Size = new System.Drawing.Size(100, 105);
            this.pipeUp4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pipeUp4.TabIndex = 10;
            this.pipeUp4.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1256, 643);
            this.Controls.Add(this.pipeUp4);
            this.Controls.Add(this.pipeDown4);
            this.Controls.Add(this.pipeDown3);
            this.Controls.Add(this.pipeUp3);
            this.Controls.Add(this.pipeUp2);
            this.Controls.Add(this.pipeDown2);
            this.Controls.Add(this.bird);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.pipeDown);
            this.Controls.Add(this.ground);
            this.Controls.Add(this.pipeUp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FLAPPY BIRD";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gamekeyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gamekeyisup);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeDown4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pipeUp4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox pipeUp;
        private System.Windows.Forms.PictureBox ground;
        private System.Windows.Forms.PictureBox pipeDown;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pipeDown2;
        private System.Windows.Forms.PictureBox pipeUp2;
        private System.Windows.Forms.PictureBox pipeUp3;
        private System.Windows.Forms.PictureBox pipeDown3;
        private System.Windows.Forms.PictureBox pipeDown4;
        private System.Windows.Forms.PictureBox pipeUp4;
    }
}

