using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADONET.Lab04.Exercise06
{
    public partial class Form1 : Form
    {
        // В классе формы создайте экземпляры DataView для таблиц Customers и Orders
        DataView customersDataView;
        DataView ordersDataView;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Загрузите данные в таблицы Customers и Orders
            customersTableAdapter1.Fill(northwindDataSet1.Customers);
            ordersTableAdapter1.Fill(northwindDataSet1.Orders);

            // Настройте объекты DataSet для использования таблиц Customers и Orders
            customersDataView = new DataView(northwindDataSet1.Customers);
            ordersDataView = new DataView(northwindDataSet1.Orders);

            // Присвойте исходный порядок сортировки в DataView
            customersDataView.Sort = "CustomerID";

            // Настройте CustomerGrid для отображения CustomerDataView
            CustomersGrid.DataSource = customersDataView;
        }

        private void SetDataViewPropertiesButton_Click(object sender, EventArgs e)
        {
            // В обработчике события Click кнопки Set Data View реализуйте сортировку
            // и фильтрацию данных в зависимости от значений, введенных в элементы
            // SortTextBox и FilterTextBox соответственно
            customersDataView.Sort = SortTextBox.Text;
            customersDataView.RowFilter = FilterTextBox.Text;
        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            DataRowView newCustomRow = customersDataView.AddNew();

            newCustomRow["CustomerID"] = "WINGT";
            newCustomRow["CompanyName"] = "Wing Tip Toys";
            newCustomRow.EndEdit();
        }

        private void GetOrdersButton_Click(object sender, EventArgs e)
        {
            // Получите CustomerID для строки, выбранной в CustomersGrid
            string selectedCustomerID =
                (string)CustomersGrid.SelectedCells[0].OwningRow.Cells["CustomerID"].Value;

            // Создайте DataRowView и присвойте ему выбранную строку
            DataRowView selectedRow =
                customersDataView[customersDataView.Find(selectedCustomerID)];

            // Вызовите метод CreateChildView() для перемещения по записям и
            // создания нового DataView, основанного на связанных записях
            ordersDataView =
                selectedRow.CreateChildView(northwindDataSet1.Relations["FK_Orders_Customers"]);

            // Настройте OrderGrid для отображения связанного DataView
            OrdersGrid.DataSource = ordersDataView;
        }
    }
}
