using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Markup;
using System.Reflection;

namespace ITMO.ADONET.Test
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SqlConnection NorthwindConnection = new 
            SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\mgors\Desktop\ITMO\ITMO.ADONET\ITMO.ADONET.Test\Data\NorthwndData.mdf;Integrated Security=True");

        private DataSet NorthwindDataset = new DataSet("Northwind");

        private DataTable CustomersTable = new DataTable("Customers");
        private DataTable OrdersTable = new DataTable("Orders");

        private DataView CustomersDataView;
        private DataView OrdersDataView;

        private SqlDataAdapter CustomersAdapter;
        private SqlDataAdapter OrdersAdapter;

        public MainWindow()
        {
            InitializeComponent();
            CreateDataset();
        }

        public void CreateDataset()
        {
            try
            {
                CustomersAdapter = new SqlDataAdapter("SELECT * FROM Customers", NorthwindConnection);
                OrdersAdapter = new SqlDataAdapter("SELECT * FROM Orders", NorthwindConnection);
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(CustomersAdapter);

                NorthwindDataset.Tables.Add(CustomersTable);
                NorthwindDataset.Tables.Add(OrdersTable);                

                CustomersAdapter.Fill(NorthwindDataset.Tables["Customers"]);
                OrdersAdapter.Fill(NorthwindDataset.Tables["Orders"]);

                CustomersDataView = new DataView(NorthwindDataset.Tables["Customers"]);
                OrdersDataView = new DataView(NorthwindDataset.Tables["Orders"]);

                if (NorthwindDataset.Tables["Customers"].Rows.Count > 0)
                {
                    CustomersDataGrid.ItemsSource = CustomersDataView;
                }

                if (NorthwindDataset.Tables["Orders"].Rows.Count > 0)
                {
                    OrdersDataGrid.ItemsSource = OrdersDataView;
                    OrdersDataView.RowFilter = "CustomerID=''";
                }

                CustomersDataGrid.SelectionMode = DataGridSelectionMode.Single;                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }                                   
        }

        private void CustomersDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                DataRowView selectedRow = (DataRowView)CustomersDataGrid.SelectedItem;
                if (selectedRow != null)
                {
                    string selectedID = selectedRow["CustomerID"].ToString();

                    OrdersDataView.RowFilter = "CustomerID='" + selectedID + "'";

                    //int selectedСolumn = CustomersDataGrid.CurrentCell.Column.DisplayIndex;
                    //var selectedCell = CustomersDataGrid.SelectedCells[selectedСolumn];
                    //var cellContent = selectedCell.Column.GetCellContent(selectedCell.Item);

                    //currentCellTextBox.Text = (cellContent as TextBlock).Text;
                    //statusCellTextBox.Text = selectedRow.RowVersion.ToString();
                }
                else
                {
                    OrdersDataView.RowFilter = "CustomerID=''";
                }
            }
            catch (InvalidCastException)
            {
                OrdersDataView.RowFilter = "CustomerID=''";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //MessageBox.Show(CustomersDataGrid.SelectedCells[1].Item.ToString());


        }

        private void RefreshButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {                
                CustomersAdapter.Update(NorthwindDataset, "Customers");

                //CustomersTable.Clear();
                //NorthwindDataset.Clear(NorthwindDataset.Tables["Customers"]);
                NorthwindDataset.Tables["Customers"].Clear();
                
                CustomersAdapter.Fill(NorthwindDataset.Tables["Customers"]);
                MessageBox.Show("Данные были синхронизированны");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SortTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string test = "";
            if (SortTextBox.Text != test)
            {
                CustomersDataView.Sort = "CustomerID='" + SortTextBox.Text + "'";
            }
        }

        private void FilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string test = "";
            try
            {
                if (FilterTextBox.Text != test)
                {
                    CustomersDataView.RowFilter = "ContactTitle ='" + FilterTextBox.Text + "'";
                }
                else
                {
                    CustomersDataView.RowFilter = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                                    
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            DataRowView selectedRow = (DataRowView)CustomersDataGrid.SelectedItem;
            selectedRow.Delete();
        }
    }
}
