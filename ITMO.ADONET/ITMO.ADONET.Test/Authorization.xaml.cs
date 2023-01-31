using ITMO.ADONET.Test.Properties;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using System.Data.SqlClient;

namespace ITMO.ADONET.Test
{
    /// <summary>
    /// Interaction logic for Authorization.xaml
    /// </summary>
    public partial class Authorization : Window
    {
        private string login;
        private string password;
        private string path;

        public Authorization()
        {
            InitializeComponent();           
        }

        private string GetConnectionString(string login, string password, string path)
        {
            string connectionString =
                @"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + path + "; User ID = " + 
                login + "; Password = " + password;           

            return connectionString;
        }

        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            login = LoginTextBlock.Text;
            password = PasswordTextBlock.Password;
            path = PathTextBlock.Text;

            string connectionString = GetConnectionString(login, password, path);

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    if (connection.State == ConnectionState.Open)
                    {
                        MainWindow mainWindow = new MainWindow(connectionString);
                        mainWindow.Show();

                        connection.Close();
                        this.Close();
                    }
                }
            }
            catch (SqlException SqlEr)
            {
                StringBuilder message = new StringBuilder();

                foreach (SqlError error in SqlEr.Errors)
                {
                    if (error.Number == 18456)
                    {
                        message.AppendLine("Ошибка 18456\nНеверный логин или пароль\n");
                    }
                    else
                    {
                        message.AppendLine("Ошибка " + error.Number + "\n" + error.Message + "\n");
                    }
                }
                MessageBox.Show(message.ToString(), "Ошибка авторизации");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
