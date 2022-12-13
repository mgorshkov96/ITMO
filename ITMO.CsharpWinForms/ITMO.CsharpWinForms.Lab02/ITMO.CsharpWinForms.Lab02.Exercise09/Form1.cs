using MyClass;
using System.Text;

namespace ITMO.CsharpWinForms.Lab02.Exercise09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string Author // Автор
        {
            get { return textBox1.Text; }
            set { textBox1.Text = value; }
        }
        public string Title // Название
        {
            get { return textBox2.Text; }
            set { textBox2.Text = value; }
        }

        public string PublishHouse // Издательство
        {
            get { return textBox3.Text; }
            set { textBox3.Text = value; }
        }

        public int Page // Количество страниц
        {
            get { return (int)numericUpDown1.Value; }
            set { numericUpDown1.Value = value; }
        }
        public int Year // Год издания
        {
            get { return (int)numericUpDown2.Value; }
            set { numericUpDown2.Value = value; }
        }
        public int InvNumber // Инвентарный номер
        {
            get { return (int)numericUpDown3.Value; }
            set { numericUpDown3.Value = value; }
        }
        public bool Existence // Наличие
        {
            get { return checkBox1.Checked; }
            set { checkBox1.Checked = value; }
        }
        public bool SortInvNumber // Сортировка по инвентарному номеру
        {
            get { return checkBox2.Checked; }
            set { checkBox2.Checked = value; }
        }
        public bool ReturnTime // Возвращение в срок
        {
            get { return checkBox3.Checked; }
            set { checkBox3.Checked = value; }
        }
        public int PeriodUse // Срок пользования
        {
            get { return (int)numericUpDown4.Value; }
            set { numericUpDown4.Value = value; }
        }

        List<Item> its = new List<Item>();

        private void button1_Click(object sender, EventArgs e)
        {
            Book b = new Book(Author, Title, PublishHouse,
                Page, Year, InvNumber, Existence);

            // Проверка возврата книги в срок
            if (ReturnTime)
                b.ReturnSrok();

            // Расчёт стоимости с учетом срока пользования
            b.PriceBook(PeriodUse);

            // Добавляем книгу в список
            its.Add(b);

            // Отчищяем поля ввода 
            Author = Title = PublishHouse = "";
            Page = InvNumber = PeriodUse = 0;
            Year = 2022;
            Existence = ReturnTime = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Проверка наличия флажка сортировки
            if (SortInvNumber)
                its.Sort();

            // Вывод информации в переменную
            StringBuilder sb = new StringBuilder();
            foreach (Item item in its)
            {
                sb.Append("\n" + item.ToString());
            }

            // Выводим текст в richTextBox
            richTextBox1.Text = sb.ToString();
        }

        // ЖУРНАЛЫ      
        public string MagazineTitle // Название журнала
        {
            get { return textBox6.Text; }
            set { textBox6.Text = value; }
        }
        public string MagazineTom // Том журнала
        {
            get { return textBox5.Text; }
            set { textBox5.Text = value; }
        }
        public int MagazineNumber // Номер журнала
        {
            get { return (int)numericUpDown8.Value; }
            set { numericUpDown8.Value = value; }
        }
        public int MagazineYear // Год издания журнала
        {
            get { return (int)numericUpDown7.Value; }
            set { numericUpDown7.Value = value; }
        }
        public int MagazineInvNumber // Инвентарный номер журнала
        {
            get { return (int)numericUpDown6.Value; }
            set { numericUpDown6.Value = value; }
        }
        public bool MagazineSub // Подписка
        {
            get { return checkBox5.Checked; }
            set { checkBox5.Checked = value; }
        }
        public bool MagazineSortInvNumber // Сортировка по инвентарному номеру
        {
            get { return checkBox6.Checked; }
            set { checkBox6.Checked = value; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Magazine m = new Magazine(MagazineTom, MagazineNumber, MagazineTitle,
                MagazineYear, MagazineInvNumber, MagazineSub);

            m.IfSubs = MagazineSub;

            // Добавляем журнал в список
            its.Add(m);

            // Отчищяем поля ввода 
            MagazineTom = MagazineTitle =  "";
            MagazineNumber = MagazineInvNumber = 0;
            MagazineYear = 2022;
            MagazineSub = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Проверка наличия флажка сортировки
            if (MagazineSortInvNumber)
                its.Sort();

            // Вывод информации в переменную
            StringBuilder sb = new StringBuilder();
            foreach (Item item in its)
            {
                sb.Append("\n" + item.ToString());
            }

            // Выводим текст в richTextBox
            richTextBox2.Text = sb.ToString();
        }
    }
}