using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADONET.Lab02.Exercise03
{
    public partial class Form1 : Form
    {
        //string testConnect = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;
        //Persist Security Info=False;Initial Catalog=Northwind;
        //Data Source=(local)\SQLEXPRESS";

        string testConnect = GetConnectionStringByName("DBConnect.NorthwindConnectionString");

        OleDbConnection connection = new OleDbConnection();

        public Form1()
        {
            InitializeComponent();

            this.connection.StateChange += new System.Data.StateChangeEventHandler(this.connection_StateChange);
        }

        static string GetConnectionStringByName(string name)
        {
            string retutnValue = null;
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings[name];

            if (settings != null)            
                retutnValue = settings.ConnectionString;
            
            return retutnValue;
        }

        private void connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {           
            menuConnectDB.Enabled = (e.CurrentState == ConnectionState.Closed);

            menuDisconnectDB.Enabled = (e.CurrentState == ConnectionState.Open);
        }

        private void menuConnectDB_Click(object sender, EventArgs e)
        {           
            try
            {
                // if особо не нужен, т.к. мы обрабатываем данный сценарий 
                // в исключении. Оставил if, как написано в примере
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = testConnect;
                    connection.Open();
                    MessageBox.Show("Соединение с базой данных выполненно успешно");
                }
                else
                    MessageBox.Show("Соединение с базой данных уже установлено");
            }
            catch (OleDbException XcpSQL)
            {
                foreach (OleDbError se in XcpSQL.Errors)
                {
                    MessageBox.Show(se.Message,
                        "SQL Error code " + se.NativeError,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, "Unexcepted Exception",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuDisconnectDB_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Соединение с базой данных закрыто");
            }
            else
                MessageBox.Show("Соединение с базой данных уже закрыто");
        }

        private void menuConnectList_Click(object sender, EventArgs e)
        {
            ConnectionStringSettingsCollection settings =
                ConfigurationManager.ConnectionStrings;

            if (settings != null)
            {
                foreach (ConnectionStringSettings cs in settings)
                {
                    MessageBox.Show("name = " + cs.Name);
                    MessageBox.Show("providerName = " + cs.ProviderName);
                    MessageBox.Show("connectionString = " + cs.ConnectionString);
                }
            }
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                OleDbCommand command = new OleDbCommand();
                
                // Устанавливаем свойству Connection требуемый объект
                // соединения.
                command.Connection = connection;

                // в свойстве CommandText пишем SQL запрос
                command.CommandText = "SELECT COUNT(*) FROM Products";

                // ExecuteScalar - выполнение запроса. Возвращает 1 значение
                // типа object, поэтому явно приводим к int
                int number = (int)command.ExecuteScalar();

                lblCount.Text = number.ToString();
            }
            else
            {
                MessageBox.Show("Отсутствует подключение к базе данных");
            }
        }

        private void btnProductList_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                // Создаем объект OleDbCommand через метод CreateCommand()
                // объекта OleDbConnection. В таком случае не надо
                // прописывать свойство Connection, как в btnCount_Click
                OleDbCommand command = connection.CreateCommand();

                // в свойстве CommandText пишем SQL запрос
                command.CommandText = "SELECT ProductName FROM Products";

                // Выполняем запрос через метод ExecuteReader(),
                // возвращается объект OleDbReader
                OleDbDataReader reader = command.ExecuteReader();

                // reader.Read() возвращает True, если есть еще значения
                while (reader.Read())
                {
                    lvProductList.Items.Add(reader["ProductName"].ToString());
                }
            }
            else
            {
                MessageBox.Show("Отсутствует подключение к базе данных");
            }
        }

        private void btnTransact_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                // Создаем объект OleDbTransaction через метод
                // BeginTransaction() у объекта OleDbConnection
                OleDbTransaction OleTran = connection.BeginTransaction();

                // Создаем объект OleDbCommand, с помощью которого
                // будет выполняться SQL запрос
                OleDbCommand command = connection.CreateCommand();

                // Связываем транзакцию с коммандой (через свойство)
                command.Transaction = OleTran;

                try
                {
                    command.CommandText = "INSERT INTO Products (ProductName) " +
                        "VALUES('Wrong size')";

                    // Метод для запросов, не возвращающих значения, а 
                    // изменяющих данные в БД
                    command.ExecuteNonQuery();


                    command.CommandText = "INSERT INTO Products (ProductName) " +
                        "VALUES('Wrong color')";

                    command.ExecuteNonQuery();

                    // Сохраняем изменения, расписанные выше
                    OleTran.Commit();

                    MessageBox.Show("Транзакция прошла успешно, данные добавлены");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    try
                    {
                        OleTran.Rollback();
                        MessageBox.Show("Транзакция откачена");
                    }
                    catch (Exception exRollback)
                    {                        
                        MessageBox.Show(exRollback.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Отсутствует подключение к базе данных");
            }
        }
    }
}