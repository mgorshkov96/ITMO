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

namespace ITMO.ADONET.Lab01.Exercise05
{
    public partial class Form1 : Form
    {
        //string testConnect = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;
        //Persist Security Info=False;Initial Catalog=Northwind;
        //Data Source=DESKTOP-T597S8K\SQLEXPRESS";

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
    }
}