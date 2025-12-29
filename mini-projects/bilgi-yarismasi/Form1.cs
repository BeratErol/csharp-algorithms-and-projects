using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int soruNo = 0, dogru = 0, yanlis = 0;
        string dogruCevap, secilenCevap;
        
        private void BtnSonraki_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = true;
            BtnB.Enabled = true;
            BtnC.Enabled = true;
            BtnD.Enabled = true;
            BtnSonraki.Enabled = false;
           
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            soruNo++;
            if (soruNo < 4)
            {
                LblSoruNo.Text = Convert.ToString(soruNo);
            }

            if (soruNo == 1)
            {
                richTextBox1.Text = "Cumhuriyet kaç yılında ilan edilmiştir ?";
                BtnA.Text = "1920";
                BtnB.Text = "1921";
                BtnC.Text = "1922";
                BtnD.Text = "1923";
                dogruCevap = "1923";
            }
            if (soruNo == 2)
            {
                richTextBox1.Text = "Hangi il Ege bölgemizde bulunmaz ?";
                BtnA.Text = "İzmir";
                BtnB.Text = "Balıkesir";
                BtnC.Text = "Aydın";
                BtnD.Text = "Manisa";
                dogruCevap = "Balıkesir";
            }
            if (soruNo == 3)
            {
                richTextBox1.Text = "Son Kuşlar hangi yazarımıza aittir ?";
                BtnA.Text = "Sait Faik Abasıyanık";
                BtnB.Text = "Cemal Süreyya";
                BtnC.Text = "Atilla İlhan";
                BtnD.Text = "Reşat Nuri Güntekin";
                dogruCevap = "Sait Faik Abasıyanık";

                BtnSonraki.Text = "SONUÇLAR";
            }
            if (soruNo == 4)
            {
                BtnA.Enabled = false;
                BtnB.Enabled = false;
                BtnC.Enabled = false;
                BtnD.Enabled = false;
                BtnSonraki.Enabled = false;

                MessageBox.Show("Doğru: " + dogru + "\nYanlış: " + yanlis);
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            secilenCevap = BtnA.Text;
            if (dogruCevap == secilenCevap)
            {
                dogru++;
                LblDogru.Text = Convert.ToString(dogru);
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = Convert.ToString(yanlis);
                pictureBox2.Visible = true;
            }
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            secilenCevap = BtnB.Text;
            if (dogruCevap == secilenCevap)
            {
                dogru++;
                LblDogru.Text = Convert.ToString(dogru);
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = Convert.ToString(yanlis);
                pictureBox2.Visible = true;
            }
        }
        
        private void BtnC_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            secilenCevap = BtnC.Text;
            if (dogruCevap == secilenCevap)
            {
                dogru++;
                LblDogru.Text = Convert.ToString(dogru);
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = Convert.ToString(yanlis);
                pictureBox2.Visible = true;
            }
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            BtnA.Enabled = false;
            BtnB.Enabled = false;
            BtnC.Enabled = false;
            BtnD.Enabled = false;
            BtnSonraki.Enabled = true;

            secilenCevap = BtnD.Text;
            if (dogruCevap == secilenCevap)
            {
                dogru++;
                LblDogru.Text = Convert.ToString(dogru);
                pictureBox1.Visible = true;
            }
            else
            {
                yanlis++;
                LblYanlis.Text = Convert.ToString(yanlis);
                pictureBox2.Visible = true;
            }
        }
    }
}
