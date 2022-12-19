using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CsharpWinForms.Test.WindowsCalculator
{
    public partial class Сoefficients : Form
    {
        private int theme;
        public Сoefficients(int ownerTheme)
        {
            InitializeComponent();
            theme = ownerTheme;
        }

        public string СoefficientA
        {
            get { return txtСoefficientsA.Text; }
            set { txtСoefficientsA.Text = value; }
        }
        public string СoefficientB
        {
            get { return txtСoefficientsB.Text; }
            set { txtСoefficientsB.Text = value; }
        }
        public string СoefficientC
        {
            get { return txtСoefficientsC.Text; }
            set { txtСoefficientsC.Text = value; }
        }

        private void txtСoefficientsA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 | e.KeyChar > 57) & (e.KeyChar != 44) & (e.KeyChar != 8) & (e.KeyChar != 45))
            {
                e.Handled = true;
            }
        }

        private void txtСoefficientsB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 | e.KeyChar > 57) & (e.KeyChar != 44) & (e.KeyChar != 8) & (e.KeyChar != 45))
            {
                e.Handled = true;
            }
        }

        private void txtСoefficientsC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 | e.KeyChar > 57) & (e.KeyChar != 44) & (e.KeyChar != 8) & (e.KeyChar != 45))
            {
                e.Handled = true;
            }
        }

        private void Сoefficients_Load(object sender, EventArgs e)
        {
            if (theme != 0)
            {
                this.BackColor = Color.Black;
                this.lblСoefficientsEquation.ForeColor = Color.White;
                this.lblСoefficientsA.ForeColor = Color.White;
                this.lblСoefficientsB.ForeColor = Color.White;
                this.lblСoefficientsC.ForeColor = Color.White;
                this.btnСoefficientsOK.ForeColor = Color.White;
                this.btnСoefficientsOK.BackColor = Color.Gray;
                this.btnСoefficientsCancel.ForeColor = Color.White;
                this.btnСoefficientsCancel.BackColor = Color.Gray;
            }
        }
    }
}
