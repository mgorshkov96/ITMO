using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADONET.Lab04.Exercise03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = northwindDataSet1.Customers;

            // Вызовите метод Fill объекта DataAdapter для загрузки клиентов данными
            sqlDataAdapter1.Fill(northwindDataSet1.Customers);
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(northwindDataSet1);
        }

        private void sqlDataAdapter1_RowUpdating(object sender, System.Data.SqlClient.SqlRowUpdatingEventArgs e)
        {
            // Создайте экземпляр CustomerRow и присвойте ему изменяемую строку
            NorthwindDataSet.CustomersRow CustRow =
                (NorthwindDataSet.CustomersRow)e.Row;

            // Отобразите диалоговое окно для подтверждения обновления
            DialogResult response = MessageBox.Show("Continue updating " +
                CustRow.CustomerID.ToString() + "?", "Continue Update?",
                MessageBoxButtons.YesNo);

            // Реализуйте отмену обновления, если пользователь выбрал Нет
            if (response == DialogResult.No)
                e.Status = UpdateStatus.SkipCurrentRow;
        }

        private void sqlDataAdapter1_RowUpdated(object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs e)
        {
            NorthwindDataSet.CustomersRow CustRow =
                (NorthwindDataSet.CustomersRow)e.Row;

            MessageBox.Show(CustRow.CustomerID.ToString() + " has been updated");

            // Реализуйте сброс таблицы после обновления строки для отражения изменений
            northwindDataSet1.Customers.Clear();
            sqlDataAdapter1.Fill(northwindDataSet1.Customers);
        }

        private void sqlDataAdapter1_FillError(object sender, FillErrorEventArgs e)
        {
            DialogResult response = MessageBox.Show("The following error " +
                "occurred while Fillingthe DataSet: " + e.Errors.Message.ToString() +
                " Continue attempting to fill?", "FillError Encountered",
                MessageBoxButtons.YesNo);

            // Реализуйте попытку продолжения, если пользователь выбрал Да
            if (response == DialogResult.Yes)
            {
                e.Continue = true;
            }
            else
            {
                e.Continue = false;
            }
        }
    }
}
