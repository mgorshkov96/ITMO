using System.Data;
using System.Reflection;
using System.Windows.Forms;
using ExcelObj = Microsoft.Office.Interop.Excel;

namespace ITMO.CsharpWinForms.Lab05.Exercise01
{
    public partial class Form1 : Form
    {
        //В поле класса формы создайте объект приложения и объявите
        //объекты приложения Excel: книга, лист и диапазон
        ExcelObj.Application app = new ExcelObj.Application();
        ExcelObj.Workbook workbook;
        ExcelObj.Worksheet NwSheet;
        ExcelObj.Range ShtRange;

        //После этого создайте с использованием класса DataTable таблицу dt,
        //в которую будут заноситься полученные из файла данные
        System.Data.DataTable dt = new System.Data.DataTable();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Откройте окно диалога и в случае нажатия в нем кнопки OK в элемент
            //управления textBox1 в текстовое поле с помощью свойства FileName
            //объекта ofd выведете путь, имя и расширение выбранного файла
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = ofd.FileName;

                workbook = app.Workbooks.Open(ofd.FileName);
                NwSheet = (ExcelObj.Worksheet)workbook.Sheets.get_Item(1);
                ShtRange = NwSheet.UsedRange;

                //После получения объекта ShtRange, с помощью цикла For реализуйте
                //загрузку первой строки из таблицы
                for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                {
                    dt.Columns.Add(new DataColumn((ShtRange.Cells[1, Cnum] as ExcelObj.Range).Value2.ToString()));
                }
                dt.AcceptChanges();

                //Установите каждое значение первой строки из таблицы в качестве
                //имени колонки таблицы
                string[] columnNames = new String[dt.Columns.Count];
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    columnNames[0] = dt.Columns[i].ColumnName;
                }

                //Далее загрузите все оставшиеся строки с добавлением в таблицу
                for (int Rnum = 2; Rnum <= ShtRange.Rows.Count; Rnum++)
                {
                    DataRow dr = dt.NewRow();
                    for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                    {
                        if ((ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2 != null)
                        {
                            dr[Cnum - 1] = (ShtRange.Cells[Rnum, Cnum] as ExcelObj.Range).Value2.ToString();
                        }
                    }
                    dt.Rows.Add(dr);
                    dt.AcceptChanges();
                }

                //По завершении загрузки данных с указанного листа, сформированную
                //таблицу dt подключите к элементу управления dataGridView1 и
                //закройте объект приложения
                dataGridView1.DataSource = dt;
                app.Quit();
            }
            else
            {
                MessageBox.Show("Вы не выбрали файл для открытия",
                "Загрузка данных...", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}