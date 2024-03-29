﻿using System;
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
        private SqlConnection NorthwindConnection;

        private DataSet NorthwindDataset = new DataSet("Northwind");

        private DataTable CustomersTable = new DataTable("Customers");
        private DataTable OrdersTable = new DataTable("Orders");        

        private DataView CustomersDataView;
        private DataView OrdersDataView;

        private SqlDataAdapter CustomersAdapter;
        private SqlDataAdapter OrdersAdapter;

        public MainWindow(string connectionString)
        {
            InitializeComponent();
            CreateDataset(connectionString);
        }

        public void CreateDataset(string connectionString)
        {
            try
            {
                NorthwindConnection = new SqlConnection(connectionString);

                CustomersAdapter = new SqlDataAdapter("SELECT * FROM Customers", NorthwindConnection);
                OrdersAdapter = new SqlDataAdapter("SELECT * FROM Orders", NorthwindConnection);

                SqlCommandBuilder customersCommandBuilder = new SqlCommandBuilder(CustomersAdapter);
                SqlCommandBuilder ordersCommandBuilder = new SqlCommandBuilder(OrdersAdapter);

                NorthwindDataset.Tables.Add(CustomersTable);
                NorthwindDataset.Tables.Add(OrdersTable);

                CustomersAdapter.Fill(NorthwindDataset.Tables["Customers"]);
                OrdersAdapter.Fill(NorthwindDataset.Tables["Orders"]);

                CustomersDataView = new DataView(NorthwindDataset.Tables["Customers"]);
                OrdersDataView = new DataView(NorthwindDataset.Tables["Orders"]);

                if (NorthwindDataset.Tables["Customers"].Rows.Count > 0)
                {
                    CustomersDataGrid.ItemsSource = CustomersDataView;
                    CustomersDataGrid.SelectionMode = DataGridSelectionMode.Single;
                }

                if (NorthwindDataset.Tables["Orders"].Rows.Count > 0)
                {
                    OrdersDataGrid.ItemsSource = OrdersDataView;
                    OrdersDataView.RowFilter = "CustomerID=''";
                }
            }  
            catch (SqlException SqlEr)
            {
                StringBuilder message = new StringBuilder();

                foreach(SqlError error in SqlEr.Errors)
                {
                    message.AppendLine("Ошибка " + error.Number + "\n" + error.Message + "\n");
                }

                MessageBox.Show(message.ToString());
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
        }

        private void SynchItem_Click(object sender, RoutedEventArgs e)
        {
            try
            {                
                CustomersAdapter.Update(NorthwindDataset.Tables["Customers"]);
                OrdersAdapter.Update(NorthwindDataset.Tables["Orders"]);
                NorthwindDataset.Clear();                
                CustomersAdapter.Fill(NorthwindDataset.Tables["Customers"]);
                OrdersAdapter.Fill(NorthwindDataset.Tables["Orders"]);
                MessageBox.Show("Данные были синхронизированны");                
            }
            catch (SqlException SqlEr)
            {
                StringBuilder message = new StringBuilder();

                foreach (SqlError error in SqlEr.Errors)
                {
                    message.AppendLine("Ошибка " + error.Number + "\n" + error.Message + "\n");
                }

                MessageBox.Show(message.ToString(), "Ошибка синхронизации с базой данных");
            }
        }

        private void SortTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            switch (SortTextBox.Text)
            {
                case "ID":
                    CustomersDataView.Sort = "CustomerID";
                    break;
                case "Компания":
                    CustomersDataView.Sort = "CompanyName";
                    break;
                case "Имя":
                    CustomersDataView.Sort = "ContactName";
                    break;
                case "Должность":
                    CustomersDataView.Sort = "ContactTitle";
                    break;
                case "Телефон":
                    CustomersDataView.Sort = "Phone";
                    break;
                default:
                    CustomersDataView.Sort = "";
                    break;
            }
        }

        private void FilterTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {                       
            if (!String.IsNullOrEmpty(FilterTextBox.Text))
            {
                CustomersDataView.RowFilter = "ContactTitle ='" + FilterTextBox.Text + "'";
            }
            else
            {
                CustomersDataView.RowFilter = "";
            }                                               
        }

        private void customersDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView selectedRow = (DataRowView)CustomersDataGrid.SelectedItem;
                selectedRow.Delete();
            }
            catch (InvalidCastException)
            {
                return;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Сначала выберите строку");
            }
        }

        private void ordersDeleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataRowView selectedRow = (DataRowView)OrdersDataGrid.SelectedItem;
                selectedRow.Delete();
            }
            catch (InvalidCastException)
            {
                return;
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Сначала выберите строку");
            }
        }

        private void customersAddButton_Click(object sender, RoutedEventArgs e)
        {
            DataRowView customersRowView = CustomersDataView.AddNew();            
            customersRowView["CustomerID"] = "ZTEST";
            customersRowView["CompanyName"] = "MyCompany";
            customersRowView["ContactName"] = "Vasiliy";
            customersRowView["Phone"] = "88005553535";
            customersRowView.EndEdit();
        }

        private void ordersAddButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {                
                DataRowView selectedRow = (DataRowView)CustomersDataGrid.SelectedItem;
                string selectedID = selectedRow["CustomerID"].ToString();

                DataRowView ordersRowView = OrdersDataView.AddNew();
                ordersRowView["OrderID"] = 11078;
                ordersRowView["CustomerID"] = selectedID;                
                ordersRowView["ShipAddress"] = "Невский проспект, д. 1";
                ordersRowView.EndEdit();                
            }
            catch (InvalidCastException)
            {
                return;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);                 
            }                      
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            CustomersDataView.RowFilter = null;
            int customersLength = CustomersDataView.Count;
            CustomersDataView.RowStateFilter = DataViewRowState.Unchanged;
            int customersUnchangedLength = CustomersDataView.Count;
            CustomersDataView.RowStateFilter = DataViewRowState.CurrentRows;

            OrdersDataView.RowFilter = null;
            int ordersLength = OrdersDataView.Count;
            OrdersDataView.RowStateFilter = DataViewRowState.Unchanged;
            int ordersUnchangedLength = OrdersDataView.Count;
            OrdersDataView.RowStateFilter = DataViewRowState.CurrentRows;
            OrdersDataView.RowFilter = "CustomerID=''";


            if (customersLength != customersUnchangedLength || ordersLength != ordersUnchangedLength)
            {
                string msg = "Данные не синхронизированны. Закрыть без синхронизации?";
                MessageBoxResult result =
                  MessageBox.Show(
                    msg,
                    "Предупреждение",
                    MessageBoxButton.YesNo,
                    MessageBoxImage.Warning);
                if (result == MessageBoxResult.No)
                {                    
                    e.Cancel = true;
                }
            }            
        }             
    }
}
