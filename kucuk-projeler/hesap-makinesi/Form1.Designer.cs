namespace Hesap_Makinesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ekran_label = new System.Windows.Forms.Label();
            this.sayı1_button = new System.Windows.Forms.Button();
            this.sayı2_button = new System.Windows.Forms.Button();
            this.sayı3_button = new System.Windows.Forms.Button();
            this.sayı4_button = new System.Windows.Forms.Button();
            this.sayı5_button = new System.Windows.Forms.Button();
            this.sayı6_button = new System.Windows.Forms.Button();
            this.sayı7_button = new System.Windows.Forms.Button();
            this.sayı8_button = new System.Windows.Forms.Button();
            this.sayı9_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.sayı0_button = new System.Windows.Forms.Button();
            this.sonuc_button = new System.Windows.Forms.Button();
            this.bolme_button = new System.Windows.Forms.Button();
            this.carpma_button = new System.Windows.Forms.Button();
            this.cikarma_button = new System.Windows.Forms.Button();
            this.toplama_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ekran_label
            // 
            this.ekran_label.BackColor = System.Drawing.Color.White;
            this.ekran_label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ekran_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ekran_label.Location = new System.Drawing.Point(23, 34);
            this.ekran_label.Name = "ekran_label";
            this.ekran_label.Size = new System.Drawing.Size(392, 60);
            this.ekran_label.TabIndex = 0;
            this.ekran_label.Text = "0";
            this.ekran_label.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // sayı1_button
            // 
            this.sayı1_button.BackColor = System.Drawing.Color.PaleGreen;
            this.sayı1_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayı1_button.Location = new System.Drawing.Point(23, 136);
            this.sayı1_button.Name = "sayı1_button";
            this.sayı1_button.Size = new System.Drawing.Size(86, 66);
            this.sayı1_button.TabIndex = 1;
            this.sayı1_button.Text = "1";
            this.sayı1_button.UseVisualStyleBackColor = false;
            this.sayı1_button.Click += new System.EventHandler(this.sayı1_button_Click);
            // 
            // sayı2_button
            // 
            this.sayı2_button.BackColor = System.Drawing.Color.PaleGreen;
            this.sayı2_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayı2_button.Location = new System.Drawing.Point(126, 136);
            this.sayı2_button.Name = "sayı2_button";
            this.sayı2_button.Size = new System.Drawing.Size(86, 66);
            this.sayı2_button.TabIndex = 2;
            this.sayı2_button.Text = "2";
            this.sayı2_button.UseVisualStyleBackColor = false;
            this.sayı2_button.Click += new System.EventHandler(this.sayı2_button_Click);
            // 
            // sayı3_button
            // 
            this.sayı3_button.BackColor = System.Drawing.Color.PaleGreen;
            this.sayı3_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayı3_button.Location = new System.Drawing.Point(232, 136);
            this.sayı3_button.Name = "sayı3_button";
            this.sayı3_button.Size = new System.Drawing.Size(86, 66);
            this.sayı3_button.TabIndex = 3;
            this.sayı3_button.Text = "3";
            this.sayı3_button.UseVisualStyleBackColor = false;
            this.sayı3_button.Click += new System.EventHandler(this.sayı3_button_Click);
            // 
            // sayı4_button
            // 
            this.sayı4_button.BackColor = System.Drawing.Color.PaleGreen;
            this.sayı4_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayı4_button.Location = new System.Drawing.Point(23, 222);
            this.sayı4_button.Name = "sayı4_button";
            this.sayı4_button.Size = new System.Drawing.Size(86, 66);
            this.sayı4_button.TabIndex = 4;
            this.sayı4_button.Text = "4";
            this.sayı4_button.UseVisualStyleBackColor = false;
            this.sayı4_button.Click += new System.EventHandler(this.sayı4_button_Click);
            // 
            // sayı5_button
            // 
            this.sayı5_button.BackColor = System.Drawing.Color.PaleGreen;
            this.sayı5_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayı5_button.Location = new System.Drawing.Point(126, 222);
            this.sayı5_button.Name = "sayı5_button";
            this.sayı5_button.Size = new System.Drawing.Size(86, 66);
            this.sayı5_button.TabIndex = 5;
            this.sayı5_button.Text = "5";
            this.sayı5_button.UseVisualStyleBackColor = false;
            this.sayı5_button.Click += new System.EventHandler(this.sayı5_button_Click);
            // 
            // sayı6_button
            // 
            this.sayı6_button.BackColor = System.Drawing.Color.PaleGreen;
            this.sayı6_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayı6_button.Location = new System.Drawing.Point(232, 222);
            this.sayı6_button.Name = "sayı6_button";
            this.sayı6_button.Size = new System.Drawing.Size(86, 66);
            this.sayı6_button.TabIndex = 6;
            this.sayı6_button.Text = "6";
            this.sayı6_button.UseVisualStyleBackColor = false;
            this.sayı6_button.Click += new System.EventHandler(this.sayı6_button_Click);
            // 
            // sayı7_button
            // 
            this.sayı7_button.BackColor = System.Drawing.Color.PaleGreen;
            this.sayı7_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayı7_button.Location = new System.Drawing.Point(23, 305);
            this.sayı7_button.Name = "sayı7_button";
            this.sayı7_button.Size = new System.Drawing.Size(86, 66);
            this.sayı7_button.TabIndex = 7;
            this.sayı7_button.Text = "7";
            this.sayı7_button.UseVisualStyleBackColor = false;
            this.sayı7_button.Click += new System.EventHandler(this.sayı7_button_Click);
            // 
            // sayı8_button
            // 
            this.sayı8_button.BackColor = System.Drawing.Color.PaleGreen;
            this.sayı8_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayı8_button.Location = new System.Drawing.Point(126, 305);
            this.sayı8_button.Name = "sayı8_button";
            this.sayı8_button.Size = new System.Drawing.Size(86, 66);
            this.sayı8_button.TabIndex = 8;
            this.sayı8_button.Text = "8";
            this.sayı8_button.UseVisualStyleBackColor = false;
            this.sayı8_button.Click += new System.EventHandler(this.sayı8_button_Click);
            // 
            // sayı9_button
            // 
            this.sayı9_button.BackColor = System.Drawing.Color.PaleGreen;
            this.sayı9_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayı9_button.Location = new System.Drawing.Point(232, 305);
            this.sayı9_button.Name = "sayı9_button";
            this.sayı9_button.Size = new System.Drawing.Size(86, 66);
            this.sayı9_button.TabIndex = 9;
            this.sayı9_button.Text = "9";
            this.sayı9_button.UseVisualStyleBackColor = false;
            this.sayı9_button.Click += new System.EventHandler(this.sayı9_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.Color.Red;
            this.clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.clear_button.ForeColor = System.Drawing.Color.White;
            this.clear_button.Location = new System.Drawing.Point(23, 387);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(86, 66);
            this.clear_button.TabIndex = 10;
            this.clear_button.Text = "C";
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // sayı0_button
            // 
            this.sayı0_button.BackColor = System.Drawing.Color.PaleGreen;
            this.sayı0_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sayı0_button.Location = new System.Drawing.Point(126, 387);
            this.sayı0_button.Name = "sayı0_button";
            this.sayı0_button.Size = new System.Drawing.Size(86, 66);
            this.sayı0_button.TabIndex = 11;
            this.sayı0_button.Text = "0";
            this.sayı0_button.UseVisualStyleBackColor = false;
            this.sayı0_button.Click += new System.EventHandler(this.sayı0_button_Click);
            // 
            // sonuc_button
            // 
            this.sonuc_button.BackColor = System.Drawing.Color.Aqua;
            this.sonuc_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sonuc_button.Location = new System.Drawing.Point(232, 387);
            this.sonuc_button.Name = "sonuc_button";
            this.sonuc_button.Size = new System.Drawing.Size(86, 66);
            this.sonuc_button.TabIndex = 12;
            this.sonuc_button.Text = "=";
            this.sonuc_button.UseVisualStyleBackColor = false;
            this.sonuc_button.Click += new System.EventHandler(this.sonuc_button_Click);
            // 
            // bolme_button
            // 
            this.bolme_button.BackColor = System.Drawing.Color.Pink;
            this.bolme_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bolme_button.Location = new System.Drawing.Point(329, 387);
            this.bolme_button.Name = "bolme_button";
            this.bolme_button.Size = new System.Drawing.Size(86, 66);
            this.bolme_button.TabIndex = 16;
            this.bolme_button.Text = "/";
            this.bolme_button.UseVisualStyleBackColor = false;
            this.bolme_button.Click += new System.EventHandler(this.bolme_button_Click);
            // 
            // carpma_button
            // 
            this.carpma_button.BackColor = System.Drawing.Color.Pink;
            this.carpma_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.carpma_button.Location = new System.Drawing.Point(329, 305);
            this.carpma_button.Name = "carpma_button";
            this.carpma_button.Size = new System.Drawing.Size(86, 66);
            this.carpma_button.TabIndex = 15;
            this.carpma_button.Text = "X";
            this.carpma_button.UseVisualStyleBackColor = false;
            this.carpma_button.Click += new System.EventHandler(this.carpma_button_Click);
            // 
            // cikarma_button
            // 
            this.cikarma_button.BackColor = System.Drawing.Color.Pink;
            this.cikarma_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cikarma_button.Location = new System.Drawing.Point(329, 222);
            this.cikarma_button.Name = "cikarma_button";
            this.cikarma_button.Size = new System.Drawing.Size(86, 66);
            this.cikarma_button.TabIndex = 14;
            this.cikarma_button.Text = "-";
            this.cikarma_button.UseVisualStyleBackColor = false;
            this.cikarma_button.Click += new System.EventHandler(this.cikarma_button_Click);
            // 
            // toplama_button
            // 
            this.toplama_button.BackColor = System.Drawing.Color.Pink;
            this.toplama_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.toplama_button.Location = new System.Drawing.Point(329, 136);
            this.toplama_button.Name = "toplama_button";
            this.toplama_button.Size = new System.Drawing.Size(86, 66);
            this.toplama_button.TabIndex = 13;
            this.toplama_button.Text = "+";
            this.toplama_button.UseVisualStyleBackColor = false;
            this.toplama_button.Click += new System.EventHandler(this.toplama_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 480);
            this.Controls.Add(this.bolme_button);
            this.Controls.Add(this.carpma_button);
            this.Controls.Add(this.cikarma_button);
            this.Controls.Add(this.toplama_button);
            this.Controls.Add(this.sonuc_button);
            this.Controls.Add(this.sayı0_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.sayı9_button);
            this.Controls.Add(this.sayı8_button);
            this.Controls.Add(this.sayı7_button);
            this.Controls.Add(this.sayı6_button);
            this.Controls.Add(this.sayı5_button);
            this.Controls.Add(this.sayı4_button);
            this.Controls.Add(this.sayı3_button);
            this.Controls.Add(this.sayı2_button);
            this.Controls.Add(this.sayı1_button);
            this.Controls.Add(this.ekran_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HESAP MAKİNESİ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label ekran_label;
        private System.Windows.Forms.Button sayı1_button;
        private System.Windows.Forms.Button sayı2_button;
        private System.Windows.Forms.Button sayı3_button;
        private System.Windows.Forms.Button sayı4_button;
        private System.Windows.Forms.Button sayı5_button;
        private System.Windows.Forms.Button sayı6_button;
        private System.Windows.Forms.Button sayı7_button;
        private System.Windows.Forms.Button sayı8_button;
        private System.Windows.Forms.Button sayı9_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button sayı0_button;
        private System.Windows.Forms.Button sonuc_button;
        private System.Windows.Forms.Button bolme_button;
        private System.Windows.Forms.Button carpma_button;
        private System.Windows.Forms.Button cikarma_button;
        private System.Windows.Forms.Button toplama_button;
    }
}

