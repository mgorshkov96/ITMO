using System.Text;
using System.Windows.Forms;

namespace ITMO.CsharpWinForms.Lab04.Exercise05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnSetRange_Click(object sender, EventArgs e)
        {
            // Создаём форму 2 справа от формы 1
            Form2 frm2 = new Form2();
            frm2.StartPosition = FormStartPosition.Manual;
            frm2.Location = new Point(this.Location.X + this.Width, this.Location.Y);

            // Получаем DialogResult
            if (frm2.ShowDialog() != DialogResult.OK)
                return;
            else 
            {
                try
                {
                    double leftBorder = Math.Round(double.Parse(frm2.LeftBorder), 2, MidpointRounding.AwayFromZero);
                    double rightBorder = Math.Round(double.Parse(frm2.RightBorder), 2, MidpointRounding.AwayFromZero);

                    StringBuilder answer = new StringBuilder();

                    // Производим расчёт функции и заносим данные в текстовую переменную 
                    for (double i = leftBorder; Math.Round(i, 2, MidpointRounding.AwayFromZero) <= rightBorder; i += 0.10) 
                    {
                        answer.Append(Math.Round(i, 2, MidpointRounding.AwayFromZero).ToString() + ": " + Math.Round(Math.Sin(i), 2, MidpointRounding.AwayFromZero).ToString() + "\n");
                    }


                    // Проверяем попало ли значение rightBorder в диапазон при работе цикла
                    bool check = int.TryParse(Math.Round(((rightBorder - leftBorder) / 0.10), 2, MidpointRounding.AwayFromZero).ToString(), out int number);
       
                    if (check == false)
                    {
                        answer.Append(rightBorder.ToString() + ": " + Math.Round(Math.Sin(rightBorder), 2, MidpointRounding.AwayFromZero).ToString() + "\n");
                    }


                    //Заполняем параметр "Текст" в переменных в первой форме
                    rtxtAnswer.Text = answer.ToString();
                    lblInterval.Text = "Левая граница: " + leftBorder.ToString() + ", правая граница: " + rightBorder.ToString();
                }
                catch (FormatException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}