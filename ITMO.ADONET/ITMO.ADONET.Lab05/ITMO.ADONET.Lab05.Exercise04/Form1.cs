using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADONET.Lab05.Exercise04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwindDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.northwindDataSet.Customers);

            // Укажите код для создания нового столбца в DataTable
            DataColumn Location = new DataColumn("Location");
            Location.Expression = "City + ',' + Country";
            northwindDataSet.Customers.Columns.Add(Location);

        }

        private void AddColumnButton_Click(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn LocationColumn = new DataGridViewTextBoxColumn();
            LocationColumn.Name = "LocationColumn";
            LocationColumn.HeaderText = "Location";
            LocationColumn.DataPropertyName = "Location";
            customersDataGridView.Columns.Add(LocationColumn);
        }

        private void DeleteColumnButton_Click(object sender, EventArgs e)
        {
            try
            {
                customersDataGridView.Columns.Remove("LocationColumn");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void GetClickedCellButton_Click(object sender, EventArgs e)
        {
            // Объявите переменную для хранения информации о выбранной ячейке
            string CurrentCellInfo;

            // Присвойте объявленной переменной содержимое ячейки
            CurrentCellInfo = customersDataGridView.CurrentCell.Value.ToString() +
                Environment.NewLine;

            // Добавьте к переменной информацию об имени столбца, а также индексах
            // столбца и строки
            CurrentCellInfo += "Column: " +
                customersDataGridView.CurrentCell.OwningColumn.DataPropertyName +
                Environment.NewLine;
            CurrentCellInfo += "Column Index: " +
                customersDataGridView.CurrentCell.ColumnIndex.ToString() +
                Environment.NewLine;
            CurrentCellInfo += "Row Index: " +
                customersDataGridView.CurrentCell.RowIndex.ToString() +
                Environment.NewLine;

            // Результирующую строку выведете в поле надписи формы
            label1.Text = CurrentCellInfo;
        }

        private void customersDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (customersDataGridView.Columns[e.ColumnIndex].DataPropertyName ==
                "ContactName")
            {
                customersDataGridView.Rows[e.RowIndex].ErrorText =
                        "ContactName is a required field";
                e.Cancel = true;
            }
            else
                customersDataGridView.Rows[e.RowIndex].ErrorText = "";
        }

        private void ApplyStyleButton_Click(object sender, EventArgs e)
        {
            customersDataGridView.AlternatingRowsDefaultCellStyle.BackColor = 
                Color.LightGray;
        }
    }
}
