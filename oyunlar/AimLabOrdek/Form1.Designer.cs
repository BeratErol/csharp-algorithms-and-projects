namespace AimLabOrdek
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
            this.pnlstart = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnstart = new System.Windows.Forms.Button();
            this.rbtnkolay = new System.Windows.Forms.RadioButton();
            this.rbtnorta = new System.Windows.Forms.RadioButton();
            this.rbtnzor = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlsonuc = new System.Windows.Forms.Panel();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.lbltoplamtik = new System.Windows.Forms.Label();
            this.btnrestart = new System.Windows.Forms.Button();
            this.lblisabetlitik = new System.Windows.Forms.Label();
            this.lblpuan = new System.Windows.Forms.Label();
            this.timersure = new System.Windows.Forms.Timer(this.components);
            this.timerLoc = new System.Windows.Forms.Timer(this.components);
            this.lblsure = new System.Windows.Forms.Label();
            this.ordek = new System.Windows.Forms.PictureBox();
            this.pnlstart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.pnlsonuc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordek)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlstart
            // 
            this.pnlstart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlstart.Controls.Add(this.pictureBox2);
            this.pnlstart.Controls.Add(this.pictureBox1);
            this.pnlstart.Controls.Add(this.groupControl1);
            this.pnlstart.Controls.Add(this.label1);
            this.pnlstart.Location = new System.Drawing.Point(0, 2);
            this.pnlstart.Margin = new System.Windows.Forms.Padding(4);
            this.pnlstart.Name = "pnlstart";
            this.pnlstart.Size = new System.Drawing.Size(62, 451);
            this.pnlstart.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(819, 52);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(82, 74);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(139, 137);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.Appearance.Options.UseFont = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.btnstart);
            this.groupControl1.Controls.Add(this.rbtnkolay);
            this.groupControl1.Controls.Add(this.rbtnorta);
            this.groupControl1.Controls.Add(this.rbtnzor);
            this.groupControl1.Location = new System.Drawing.Point(114, 184);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(756, 224);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Zorluk Seçimi";
            // 
            // btnstart
            // 
            this.btnstart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnstart.ForeColor = System.Drawing.Color.Black;
            this.btnstart.Location = new System.Drawing.Point(281, 131);
            this.btnstart.Margin = new System.Windows.Forms.Padding(4);
            this.btnstart.Name = "btnstart";
            this.btnstart.Size = new System.Drawing.Size(234, 52);
            this.btnstart.TabIndex = 7;
            this.btnstart.Text = "Oyuna Başla";
            this.btnstart.UseVisualStyleBackColor = true;
            this.btnstart.Click += new System.EventHandler(this.btnstart_Click);
            // 
            // rbtnkolay
            // 
            this.rbtnkolay.AutoSize = true;
            this.rbtnkolay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnkolay.ForeColor = System.Drawing.Color.Black;
            this.rbtnkolay.Location = new System.Drawing.Point(240, 74);
            this.rbtnkolay.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnkolay.Name = "rbtnkolay";
            this.rbtnkolay.Size = new System.Drawing.Size(88, 29);
            this.rbtnkolay.TabIndex = 4;
            this.rbtnkolay.TabStop = true;
            this.rbtnkolay.Text = "Kolay";
            this.rbtnkolay.UseVisualStyleBackColor = true;
            // 
            // rbtnorta
            // 
            this.rbtnorta.AutoSize = true;
            this.rbtnorta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnorta.ForeColor = System.Drawing.Color.Black;
            this.rbtnorta.Location = new System.Drawing.Point(365, 74);
            this.rbtnorta.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnorta.Name = "rbtnorta";
            this.rbtnorta.Size = new System.Drawing.Size(75, 29);
            this.rbtnorta.TabIndex = 5;
            this.rbtnorta.TabStop = true;
            this.rbtnorta.Text = "Orta";
            this.rbtnorta.UseVisualStyleBackColor = true;
            // 
            // rbtnzor
            // 
            this.rbtnzor.AutoSize = true;
            this.rbtnzor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbtnzor.ForeColor = System.Drawing.Color.Black;
            this.rbtnzor.Location = new System.Drawing.Point(488, 74);
            this.rbtnzor.Margin = new System.Windows.Forms.Padding(4);
            this.rbtnzor.Name = "rbtnzor";
            this.rbtnzor.Size = new System.Drawing.Size(65, 29);
            this.rbtnzor.TabIndex = 6;
            this.rbtnzor.TabStop = true;
            this.rbtnzor.Text = "Zor";
            this.rbtnzor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 24F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(659, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "Aim Lab Ördek Version";
            // 
            // pnlsonuc
            // 
            this.pnlsonuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlsonuc.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlsonuc.BackgroundImage")));
            this.pnlsonuc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlsonuc.Controls.Add(this.groupControl2);
            this.pnlsonuc.Location = new System.Drawing.Point(908, 2);
            this.pnlsonuc.Margin = new System.Windows.Forms.Padding(4);
            this.pnlsonuc.Name = "pnlsonuc";
            this.pnlsonuc.Size = new System.Drawing.Size(53, 451);
            this.pnlsonuc.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.Controls.Add(this.lbltoplamtik);
            this.groupControl2.Controls.Add(this.btnrestart);
            this.groupControl2.Controls.Add(this.lblisabetlitik);
            this.groupControl2.Controls.Add(this.lblpuan);
            this.groupControl2.Location = new System.Drawing.Point(244, 34);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(490, 390);
            this.groupControl2.TabIndex = 7;
            this.groupControl2.Text = "SONUÇLAR";
            // 
            // lbltoplamtik
            // 
            this.lbltoplamtik.AutoSize = true;
            this.lbltoplamtik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltoplamtik.Location = new System.Drawing.Point(162, 80);
            this.lbltoplamtik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltoplamtik.Name = "lbltoplamtik";
            this.lbltoplamtik.Size = new System.Drawing.Size(79, 29);
            this.lbltoplamtik.TabIndex = 0;
            this.lbltoplamtik.Text = "label1";
            // 
            // btnrestart
            // 
            this.btnrestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnrestart.Location = new System.Drawing.Point(107, 304);
            this.btnrestart.Margin = new System.Windows.Forms.Padding(4);
            this.btnrestart.Name = "btnrestart";
            this.btnrestart.Size = new System.Drawing.Size(252, 56);
            this.btnrestart.TabIndex = 6;
            this.btnrestart.Text = "Yeniden Oyna";
            this.btnrestart.UseVisualStyleBackColor = true;
            this.btnrestart.Click += new System.EventHandler(this.btnrestart_Click_1);
            // 
            // lblisabetlitik
            // 
            this.lblisabetlitik.AutoSize = true;
            this.lblisabetlitik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblisabetlitik.Location = new System.Drawing.Point(171, 163);
            this.lblisabetlitik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblisabetlitik.Name = "lblisabetlitik";
            this.lblisabetlitik.Size = new System.Drawing.Size(79, 29);
            this.lblisabetlitik.TabIndex = 1;
            this.lblisabetlitik.Text = "label2";
            // 
            // lblpuan
            // 
            this.lblpuan.AutoSize = true;
            this.lblpuan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblpuan.Location = new System.Drawing.Point(198, 236);
            this.lblpuan.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblpuan.Name = "lblpuan";
            this.lblpuan.Size = new System.Drawing.Size(79, 29);
            this.lblpuan.TabIndex = 2;
            this.lblpuan.Text = "label3";
            // 
            // timersure
            // 
            this.timersure.Tick += new System.EventHandler(this.timersure_Tick_1);
            // 
            // timerLoc
            // 
            this.timerLoc.Tick += new System.EventHandler(this.timerLoc_Tick_1);
            // 
            // lblsure
            // 
            this.lblsure.AutoSize = true;
            this.lblsure.BackColor = System.Drawing.Color.Transparent;
            this.lblsure.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsure.Location = new System.Drawing.Point(397, 413);
            this.lblsure.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsure.Name = "lblsure";
            this.lblsure.Size = new System.Drawing.Size(249, 42);
            this.lblsure.TabIndex = 2;
            this.lblsure.Text = "Av Başlıyor...";
            // 
            // ordek
            // 
            this.ordek.BackColor = System.Drawing.Color.Transparent;
            this.ordek.Image = ((System.Drawing.Image)(resources.GetObject("ordek.Image")));
            this.ordek.Location = new System.Drawing.Point(420, 317);
            this.ordek.Margin = new System.Windows.Forms.Padding(4);
            this.ordek.Name = "ordek";
            this.ordek.Size = new System.Drawing.Size(121, 77);
            this.ordek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ordek.TabIndex = 3;
            this.ordek.TabStop = false;
            this.ordek.Click += new System.EventHandler(this.ordek_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(962, 455);
            this.Controls.Add(this.lblsure);
            this.Controls.Add(this.pnlsonuc);
            this.Controls.Add(this.pnlstart);
            this.Controls.Add(this.ordek);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ördek Oyunu";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick_1);
            this.pnlstart.ResumeLayout(false);
            this.pnlstart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.pnlsonuc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordek)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlstart;
        private System.Windows.Forms.Panel pnlsonuc;
        private System.Windows.Forms.Timer timersure;
        private System.Windows.Forms.Timer timerLoc;
        private System.Windows.Forms.Label lblsure;
        private System.Windows.Forms.PictureBox ordek;
        private System.Windows.Forms.Label lblpuan;
        private System.Windows.Forms.Label lblisabetlitik;
        private System.Windows.Forms.Label lbltoplamtik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnrestart;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button btnstart;
        private System.Windows.Forms.RadioButton rbtnkolay;
        private System.Windows.Forms.RadioButton rbtnorta;
        private System.Windows.Forms.RadioButton rbtnzor;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

