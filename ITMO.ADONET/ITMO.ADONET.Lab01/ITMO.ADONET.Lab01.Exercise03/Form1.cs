using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITMO.ADONET.Lab01.Exercise03
{
    public partial class Form1 : Form
    {
        string testConnect = @"Provider=SQLOLEDB.1;Integrated Security=SSPI;
        Persist Security Info=False;Initial Catalog=Northwind;
        Data Source=DESKTOP-T597S8K\SQLEXPRESS";

        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection connection = new OleDbConnection();

        private void menuConnectDB_Click(object sender, EventArgs e)
        {
            try 
            {             
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

        private void menuDisonnectDB_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Соединение с базой данных закрыто");
            }
            else
                MessageBox.Show("Соединение с базой данных уже закрыто");
        }
    }
}
