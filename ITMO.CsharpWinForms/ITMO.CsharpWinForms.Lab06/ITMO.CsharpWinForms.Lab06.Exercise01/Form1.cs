namespace ITMO.CsharpWinForms.Lab06.Exercise01
{
    public partial class Form1 : Form
    {
        public double a, b;
        public Form1()
        {
            InitializeComponent();
            a = 0.1;
            b = 0.04;
        }

        public string DataA
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }       

        public string DataB
        {
            get
            {
                return textBox2.Text;
            }
            set
            {
                textBox2.Text = value;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                a = double.Parse(DataA);
                b = double.Parse(DataB);
                panel1.Refresh();
            }
            catch (FormatException er)
            {
                MessageBox.Show("При выполнении ввода исходных данных " +
                    "возникла ошибка: \n" + er.Message,"Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);

                return;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit editF = new Edit();
            editF.Show(this);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            double t = 0;
            Point p1, p2;
            int w = (int)panel1.Width;
            int h = (int)panel1.Height;
            int y = h / 2;

            for (int x = 0; x < w; x++)
            {
                // Cоздайте начальную точку
                p1 = new Point(x, y);

                // Вызовите метод SummSin класса Operation для расчета
                // текущего значения функции
                t = Operation.SummSin(x, a, b);

                // Пересчитайте значение y и сместите график для вывода
                y = (int)(t * h / 5);
                y = y + h / 2;

                // Cоздайте конечную точку
                p2 = new Point(x, y);

                // Создайте два объекта: объект Graphics и объект Pen
                Graphics dc = e.Graphics;
                Pen p = new Pen(Color.Red, 1);

                // Вызовите метод рисования линии, передав ему объект-перо и
                // две точки – начальную и конечную
                dc.DrawLine(p, p1, p2);
            }
        }
    }
}