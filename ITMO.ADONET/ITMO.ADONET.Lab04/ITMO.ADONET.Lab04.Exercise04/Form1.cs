using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ITMO.ADONET.Lab04.Exercise04
{
    public partial class Form1 : Form
    {
        // Программно добавьте в класс формы объект Connection для соединения
        // с базой данных на локальном сервере
        private SqlConnection NorthwindConnection = new SqlConnection("Data " +
            "Source=(local)\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True");

        private SqlDataAdapter SqlDataAdapter1;

        // Создайте объект DataSet с таблицей Customer
        private DataSet NorthwindDataset = new DataSet("Northwind");
        private DataTable CustomersTable = new DataTable("Customers");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter1 = new SqlDataAdapter("SELECT * FROM Customers",
                NorthwindConnection);

            NorthwindDataset.Tables.Add(CustomersTable);
            SqlDataAdapter1.Fill(NorthwindDataset.Tables["Customers"]);
            dataGridView1.DataSource = NorthwindDataset.Tables["Customers"];

            // Создайте там же объект CommandBuilder, который предоставит
            // дополнительные команды INSERT, UPDATE и DELETE, требующиеся для
            // обновления базы при вызове метода DataAdapter.Update
            SqlCommandBuilder commands = new SqlCommandBuilder(SqlDataAdapter1);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            NorthwindDataset.EndInit();
            SqlDataAdapter1.Update(NorthwindDataset.Tables["Customers"]);
        }
    }
}
