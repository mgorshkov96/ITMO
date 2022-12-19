using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace ITMO.CsharpWinForms.Lab06.Exercise03
{
    public partial class Form1 : Form
    {
        static int k = 10;
        Dat d1 = new Dat(k);

        public Form1()
        {
            InitializeComponent();

            chartPlot(k, "Ветер м/с");

            //// Сначала в цикле для объекта Series1 коллекции Series вызовите
            //// метод AddXY(позволяет добавить точку с двумя заданными
            //// координатами)
            //for (int i = 1; i <= k; i++)
            //{
            //    chart1.Series["Series1"].Points.AddXY(i, d1.random(10));
            //}

            //// Настройте отображение кривой, установив тип кривой –
            //// Spline(округленная линия)
            //chart1.Series["Series1"].ChartType = SeriesChartType.Spline;

            //// Установите видимость значений на графике в местах
            //// перелома кривой и настройте легенду диаграммы
            //chart1.Series["Series1"].IsValueShownAsLabel = true;
            //chart1.Series["Series1"].LegendText = "Ветер м/с";
        }

        private void chartPlot(int d, string leg)
        {
            chart1.Series["Series1"].Points.Clear();
            for (int i = 1; i <= k; i++)
            {
                chart1.Series["Series1"].Points.AddXY(i, d1.random(d));
            }

            // Замените в методе chartPlot установку типа кривой Spline на код,
            // проверяющий состояние флажка и меняющий тип кривой Spline на Column
            if (checkBox1.Checked == true)
                chart1.Series["Series1"].ChartType = SeriesChartType.Column;
            else
                chart1.Series["Series1"].ChartType = SeriesChartType.Spline;

            chart1.Series["Series1"].IsValueShownAsLabel = true;
            chart1.Series["Series1"].LegendText = leg;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                chartPlot(100, "Влажность");
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked == true)
            {
                chartPlot(30, "Температура");
            }
        }
    }
}
