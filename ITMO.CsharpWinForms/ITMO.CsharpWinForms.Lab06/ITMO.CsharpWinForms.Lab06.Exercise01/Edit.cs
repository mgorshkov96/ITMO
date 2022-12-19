using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CsharpWinForms.Lab06.Exercise01
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm1 = this.Owner as Form1;

            try
            {
                frm1.a = double.Parse(textBox1.Text);
                frm1.b = double.Parse(textBox2.Text);
                frm1.DataA = textBox1.Text;
                frm1.DataB = textBox2.Text;
            }
            catch (FormatException er)
            {
                MessageBox.Show("При выполнении ввода исходных данных" +
                    "возникла ошибка: \n" + er.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            this.Close();
            frm1.Refresh();
        }
    }
}
