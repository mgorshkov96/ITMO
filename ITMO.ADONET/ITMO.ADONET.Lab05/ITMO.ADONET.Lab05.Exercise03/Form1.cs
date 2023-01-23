using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADONET.Lab05.Exercise03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BindGridButton_Click(object sender, EventArgs e)
        {
            // Заполните таблицу Products данными из базы данных
            productsTableAdapter1.Fill(northwindDataSet1.Products);

            // Создайте новый компонент BindingSource для таблицы Products
            BindingSource productsBindingSource = new
                BindingSource(northwindDataSet1, "Products");

            // Свяжите сетку с компонентом BindingSource
            ProductsGrid.DataSource = productsBindingSource;

            // Свяжите навигатор с компонентом BindingSource
            bindingNavigator1.BindingSource = productsBindingSource;
        }
    }
}
