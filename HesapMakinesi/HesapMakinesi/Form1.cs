namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (ScreenLabel.Text == "0") ScreenLabel.Text = "";
            ScreenLabel.Text += "3";
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            if (ScreenLabel.Text == "0") ScreenLabel.Text = "";
            ScreenLabel.Text += "1";
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            if (ScreenLabel.Text == "0") ScreenLabel.Text = "";
            ScreenLabel.Text += "2";
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            if (ScreenLabel.Text == "0") ScreenLabel.Text = "";
            ScreenLabel.Text += "4";
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            if (ScreenLabel.Text == "0") ScreenLabel.Text = "";
            ScreenLabel.Text += "5";
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            if (ScreenLabel.Text == "0") ScreenLabel.Text = "";
            ScreenLabel.Text += "6";
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            if (ScreenLabel.Text == "0") ScreenLabel.Text = "";
            ScreenLabel.Text += "9";
        }

        private void EýghtButton_Click(object sender, EventArgs e)
        {
            if (ScreenLabel.Text == "0") ScreenLabel.Text = "";
            ScreenLabel.Text += "8";
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            if (ScreenLabel.Text == "0") ScreenLabel.Text = "";
            ScreenLabel.Text += "7";
        }

        private void ZeroButton_Click(object sender, EventArgs e)
        {
            if (ScreenLabel.Text == "0") ScreenLabel.Text = "";
            ScreenLabel.Text += "0";
        }
    }
}