using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CsharpWinForms.Lab04.Exercise05
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string LeftBorder 
        {
            get { return txtLeftBorder.Text; }
            set { txtLeftBorder.Text = value; }
        }
        public string RightBorder
        {
            get { return txtRightBorder.Text; }
            set { txtRightBorder.Text = value; }
        }

        // Задаем ограничение по вводимым символам для полей границ
        private void Borders_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 | e.KeyChar > 57) & (e.KeyChar != 44) & (e.KeyChar != 8) & (e.KeyChar != 45))
            {
                e.Handled = true;                
            } 
        }
    }
}
