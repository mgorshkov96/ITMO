namespace ITMO.CsharpWinForms.Lab03.Exercise01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.userControlTimer1.TimeEnabled = true;
            }
            else
            {
                this.userControlTimer1.TimeEnabled = false;
            }
        }
    }
}