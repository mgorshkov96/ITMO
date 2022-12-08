namespace ITMO.CsharpWinForms.Lab01.Exercise05.Test03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonClick(this.richTextBox1.Text.Length, this.button1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonClick(this.richTextBox1.Text.Length, this.button2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonClick(this.richTextBox1.Text.Length, this.button3.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ButtonClick(this.richTextBox1.Text.Length, this.button4.Text);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ButtonClick(this.richTextBox1.Text.Length, this.button5.Text);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ButtonClick(this.richTextBox1.Text.Length, this.button6.Text);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ButtonClick(this.richTextBox1.Text.Length, this.button7.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ButtonClick(this.richTextBox1.Text.Length, this.button8.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ButtonClick(this.richTextBox1.Text.Length, this.button9.Text);
        }

        private void ButtonClick (int textLength, string buttonNumber)
        {
            if (textLength <= 20)
            {
                richTextBox1.Text += buttonNumber;
            }
            else
            {
                richTextBox1.Text = buttonNumber;
            }
        }
    }
}