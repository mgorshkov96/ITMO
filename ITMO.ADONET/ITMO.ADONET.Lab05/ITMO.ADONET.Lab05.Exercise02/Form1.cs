using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADONET.Lab05.Exercise02
{
    public partial class Form1 : Form
    {
        private BindingSource productsBindingSource;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Загрузите данные в таблицу Products
            productsTableAdapter1.Fill(northwindDataSet1.Products);

            // Создайте BindingSource для таблицы Products
            productsBindingSource = new BindingSource(northwindDataSet1, "Products");

            // Настройте связывание для TextBox
            ProductIDTextBox.DataBindings.Add("Text", productsBindingSource,
                "ProductID");
            ProductNameTextBox.DataBindings.Add("Text", productsBindingSource,
                "ProductName");
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            productsBindingSource.MovePrevious();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            productsBindingSource.MoveNext();
        }
    }
}
