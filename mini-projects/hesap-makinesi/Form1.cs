using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hesap_Makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        char _secilenIslem;
        int _ekrandakiIlkSayi;
        bool _ekranTemizlensinMi;
        
        private void sayı1_button_Click(object sender, EventArgs e)
        {
            if (ekran_label.Text == "0" || _ekranTemizlensinMi)
            { ekran_label.Text = "";
              _ekranTemizlensinMi = false;
            }
            ekran_label.Text += "1";
        }

        private void sayı2_button_Click(object sender, EventArgs e)
        {
            if (ekran_label.Text == "0" || _ekranTemizlensinMi)
            {
                ekran_label.Text = "";
                _ekranTemizlensinMi = false;
            }
            ekran_label.Text += "2";
        }

        private void sayı3_button_Click(object sender, EventArgs e)
        {
            if (ekran_label.Text == "0" || _ekranTemizlensinMi)
            {
                ekran_label.Text = "";
                _ekranTemizlensinMi = false;
            }
            ekran_label.Text += "3";
        }

        private void sayı4_button_Click(object sender, EventArgs e)
        {
            if (ekran_label.Text == "0" || _ekranTemizlensinMi)
            {
                ekran_label.Text = "";
                _ekranTemizlensinMi = false;
            }
            ekran_label.Text += "4";
        }

        private void sayı5_button_Click(object sender, EventArgs e)
        {
            if (ekran_label.Text == "0" || _ekranTemizlensinMi)
            {
                ekran_label.Text = "";
                _ekranTemizlensinMi = false;
            }
            ekran_label.Text += "5";
        }

        private void sayı6_button_Click(object sender, EventArgs e)
        {
            if (ekran_label.Text == "0" || _ekranTemizlensinMi)
            {
                ekran_label.Text = "";
                _ekranTemizlensinMi = false;
            }
            ekran_label.Text += "6";
        }

        private void sayı7_button_Click(object sender, EventArgs e)
        {
            if (ekran_label.Text == "0" || _ekranTemizlensinMi)
            {
                ekran_label.Text = "";
                _ekranTemizlensinMi = false;
            }
            ekran_label.Text += "7";
        }

        private void sayı8_button_Click(object sender, EventArgs e)
        {
            if (ekran_label.Text == "0" || _ekranTemizlensinMi)
            {
                ekran_label.Text = "";
                _ekranTemizlensinMi = false;
            }
            ekran_label.Text += "8";
        }

        private void sayı9_button_Click(object sender, EventArgs e)
        {
            if (ekran_label.Text == "0" || _ekranTemizlensinMi)
            {
                ekran_label.Text = "";
                _ekranTemizlensinMi = false;
            }
            ekran_label.Text += "9";
        }

        private void sayı0_button_Click(object sender, EventArgs e)
        {
            if (ekran_label.Text == "0" || _ekranTemizlensinMi)
            {
                ekran_label.Text = "";
                _ekranTemizlensinMi = false;
            }
            ekran_label.Text += "0";
        }

        private void toplama_button_Click(object sender, EventArgs e)
        {
            _ekrandakiIlkSayi = Convert.ToInt32(ekran_label.Text);
            _ekranTemizlensinMi = true;
            _secilenIslem = '+';

        }

        private void cikarma_button_Click(object sender, EventArgs e)
        {
            _ekrandakiIlkSayi = Convert.ToInt32(ekran_label.Text);
            _ekranTemizlensinMi = true;
            _secilenIslem = '-';
        }

        private void carpma_button_Click(object sender, EventArgs e)
        {
            _ekrandakiIlkSayi = Convert.ToInt32(ekran_label.Text);
            _ekranTemizlensinMi = true;
            _secilenIslem = '*';
        }

        private void bolme_button_Click(object sender, EventArgs e)
        {
            _ekrandakiIlkSayi = Convert.ToInt32(ekran_label.Text);
            _ekranTemizlensinMi = true;
            _secilenIslem = '/';
        }

        private void sonuc_button_Click(object sender, EventArgs e)
        {
            int sonuc=0;
            if (_secilenIslem == '+')
                sonuc = _ekrandakiIlkSayi + Convert.ToInt32(ekran_label.Text);
            else if (_secilenIslem == '-')
                sonuc = _ekrandakiIlkSayi - Convert.ToInt32(ekran_label.Text);
            else if (_secilenIslem == '*')
                sonuc = _ekrandakiIlkSayi * Convert.ToInt32(ekran_label.Text);
            else if (_secilenIslem == '/')
                sonuc = _ekrandakiIlkSayi / Convert.ToInt32(ekran_label.Text);

            ekran_label.Text=Convert.ToString(sonuc);
        }

        private void clear_button_Click(object sender, EventArgs e)
        {
            ekran_label.Text = "0";
        }
    }
}
