using System.Text;
using ITMO.CsharpWinForms.Lab03.Exercise04.Library;

namespace ITMO.CsharpWinForms.Lab03.Exercise04.MyForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder message = new StringBuilder();

            foreach (User user in ctrlUser.users)
            {
                message.AppendLine(user.ToString() + "\n");
            }

            rtxtUsers.Text = message.ToString();
        }
    }
}