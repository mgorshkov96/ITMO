using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.CsharpWinForms.Lab01.Exercise05.Test02
{
    public partial class ParentForm : Form
    {       
        public ParentForm()
        {
            InitializeComponent();

            // Открываем форму на весь экран
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
        }

        //Создаём вторую форму (зелёный ромб)
        private void clickMeMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm myF2 = new ChildForm();
            myF2.Show();
        }
    }
}
