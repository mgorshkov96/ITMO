namespace ITMO.CsharpWinForms.Lab06.Exercise02
{
    public partial class Form1 : Form
    {
        // Объявите две переменные типа
        // Point, первая определяет начальную позицию, вторая – приращение координат
        // при перемещении
        Point location = new Point(50, 50);
        Point speed = new Point(5, 5);

        public Form1()
        {
            InitializeComponent();
        }

        // В классе формы создайте закрытый метод, реализующий перемещение
        // фигуры и отскок от стен
        private void Go()
        {
            location = new Point(location.X + speed.X, location.Y + speed.Y);
            if (location.X + 0 > ClientRectangle.Width || location.X < 0)
                speed = new Point(-speed.X, speed.Y);
            if (location.Y + 10 > ClientRectangle.Height || location.Y < 0)
                speed = new Point(speed.X, -speed.Y);
        }

        // В классе формы создайте закрытый метод, реализующий графическую
        // фигуру и вызывающий метод перемещения
        private void Ball()
        {
            Graphics gr = Graphics.FromHwnd(this.Handle);
            gr.FillEllipse(Brushes.Red, location.X, location.Y, 10, 10);
            Go();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Refresh();
            Ball();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                timer1.Enabled = true;
            else
                timer1.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                timer1.Enabled = true;
            else
                timer1.Enabled = false;
        }
    }
}