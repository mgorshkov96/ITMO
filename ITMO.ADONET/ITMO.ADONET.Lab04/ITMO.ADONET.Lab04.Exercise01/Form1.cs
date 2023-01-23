using ITMO.ADONET.Lab04.Exercise01.NorthwindDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADONET.Lab04.Exercise01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetCustomersButton_Click(object sender, EventArgs e)
        {
            // Создайте экземпляр типизированного набора данных Northwind
            NorthwindDataSet NorthwindDataset1 = new NorthwindDataSet();

            // Создайте экземпляр CustomersTableAdapter
            NorthwindDataSetTableAdapters.CustomersTableAdapter CustomersTableAdapter1 = 
                new NorthwindDataSetTableAdapters.CustomersTableAdapter();

            // Загрузка всех клиентов в DataTable
            CustomersTableAdapter1.Fill(NorthwindDataset1.Customers);

            // Передаём значения столбца CompanyName в ListBox
            foreach (NorthwindDataSet.CustomersRow NWCustomer in 
                NorthwindDataset1.Customers.Rows)
            {
                CustomersListBox.Items.Add(NWCustomer.CompanyName);
            }
        }
    }
}
