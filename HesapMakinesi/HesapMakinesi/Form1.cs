namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        private char _islem;
        bool _ekranTemizlenekcekMi;
        private int _ilkSayi;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenekcekMi)
            {
                ScreenLabel.Text = "";
                _ekranTemizlenekcekMi = false;
            }
            if (ScreenLabel.Text == "0") ScreenLabel.Text = "";
            ScreenLabel.Text += "1";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenekcekMi)
            {
                ScreenLabel.Text = "";
                _ekranTemizlenekcekMi = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenekcekMi)
            {
                ScreenLabel.Text = "";
                _ekranTemizlenekcekMi = false;
            }


            _islem = '*';
            _ekranTemizlenekcekMi = true;
            _ilkSayi = Convert.ToInt32(ScreenLabel.Text);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenekcekMi) ScreenLabel.Text = "";
            if (ScreenLabel.Text == "0") ScreenLabel.Text = "";
            ScreenLabel.Text += "3";
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenekcekMi)
            {
                ScreenLabel.Text = "";
                _ekranTemizlenekcekMi = false;
            }
            if (ScreenLabel.Text == "0") ScreenLabel.Text = "";
            ScreenLabel.Text += "1";
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenekcekMi)
            {
                ScreenLabel.Text = "";
                _ekranTemizlenekcekMi = false;
            }
            if (ScreenLabel.Text == "0") ScreenLabel.Text = "";
            ScreenLabel.Text += "2";
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenekcekMi)
            {
                ScreenLabel.Text = "";
                _ekranTemizlenekcekMi = false;
            }
            if (ScreenLabel.Text == "0") ScreenLabel.Text = "";
            ScreenLabel.Text += "4";
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenekcekMi)
            {
                ScreenLabel.Text = "";
                _ekranTemizlenekcekMi = false;
            }
            if (ScreenLabel.Text == "0") ScreenLabel.Text = "";
            ScreenLabel.Text += "5";
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenekcekMi)
            {
                ScreenLabel.Text = "";
                _ekranTemizlenekcekMi = false;
            }
            if (ScreenLabel.Text == "0") ScreenLabel.Text = "";
            ScreenLabel.Text += "6";
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenekcekMi)
            {
                ScreenLabel.Text = "";
                _ekranTemizlenekcekMi = false;
            }
            if (ScreenLabel.Text == "0") ScreenLabel.Text = "";
            ScreenLabel.Text += "9";
        }

        private void EýghtButton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenekcekMi)
            {
                ScreenLabel.Text = "";
                _ekranTemizlenekcekMi = false;
            }
            if (ScreenLabel.Text == "0") ScreenLabel.Text = "";
            ScreenLabel.Text += "8";
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenekcekMi)
            {
                ScreenLabel.Text = "";
                _ekranTemizlenekcekMi = false;
            }
            if (ScreenLabel.Text == "0") ScreenLabel.Text = "";
            ScreenLabel.Text += "7";
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenekcekMi)
            {
                ScreenLabel.Text = "";
                _ekranTemizlenekcekMi = false;
            }
            if (ScreenLabel.Text == "0") ScreenLabel.Text = "";
            ScreenLabel.Text += "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {




            if (_ekranTemizlenekcekMi)
            {
                ScreenLabel.Text = "";
                _ekranTemizlenekcekMi = false;
            }


            _islem = '+';
            _ekranTemizlenekcekMi = true;
            _ilkSayi = Convert.ToInt32(ScreenLabel.Text);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(ScreenLabel.Text);
            int sonuc;

            switch (_islem)
            {
                case '+':
                    sonuc = _ilkSayi + ikinciSayi;
                    break;
                case '-':
                    sonuc = _ilkSayi - ikinciSayi;
                    break;
                case '*':
                    sonuc = _ilkSayi * ikinciSayi;
                    break;
                case '/':
                    sonuc = _ilkSayi / ikinciSayi;
                    break;
                default:
                    sonuc = 0;
                    break;
            }
            ScreenLabel.Text = Convert.ToString(sonuc);
        }

        private void acButton_Click(object sender, EventArgs e)
        {
            ScreenLabel.Text = "0";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (_ekranTemizlenekcekMi)
            {
                ScreenLabel.Text = "";
                _ekranTemizlenekcekMi = false;
            }


            _islem = '/';
            _ekranTemizlenekcekMi = true;
            _ilkSayi = Convert.ToInt32(ScreenLabel.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_ekranTemizlenekcekMi)
            {
                ScreenLabel.Text = "";
                _ekranTemizlenekcekMi = false;
            }


            _islem = '-';
            _ekranTemizlenekcekMi = true;
            _ilkSayi = Convert.ToInt32(ScreenLabel.Text);
        }
    }
}