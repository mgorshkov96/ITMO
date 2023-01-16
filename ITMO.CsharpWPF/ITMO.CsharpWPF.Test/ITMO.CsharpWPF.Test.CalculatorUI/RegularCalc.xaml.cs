using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ITMO.CsharpWPF.Test.CalculatorUI
{
    /// <summary>
    /// Interaction logic for RegularCalc.xaml
    /// </summary>
    public partial class RegularCalc : Window
    {
        public RegularCalc()
        {
            InitializeComponent();
        }

        private void regularClick(object sender, RoutedEventArgs e)
        {           
            engineeringKeys.Children.Clear();
            engineeringRow.Height = new GridLength(0);
        }

        private void engineeringClick(object sender, RoutedEventArgs e)
        {
            engineeringRow.Height = new GridLength(100);

            // Создаём label для вывода значения факториала
            Label answerFact = new Label();
            answerFact.Content = "Здесь появится значение факториала...";
            engineeringKeys.Children.Add(answerFact);
            Grid.SetRow(answerFact, 0);
            Grid.SetColumnSpan(answerFact, 4);

            // Создаём кнопку для ввода коэффициентов квадратного уравнения
            Button quadraticEquation = new Button();
            quadraticEquation.Content = "ax²+bx+c=0";
            engineeringKeys.Children.Add(quadraticEquation);
            Grid.SetRow(quadraticEquation, 1);
            Grid.SetColumn(quadraticEquation, 0);
            Grid.SetColumnSpan(quadraticEquation, 2);

            // Создаём кнопку для возведения в квадрат
            Button square = new Button();
            square.Content = "x²";
            engineeringKeys.Children.Add(square);
            Grid.SetRow(square, 1);
            Grid.SetColumn(square, 2);

            // Создаём кнопку для возведения в степень
            Button exponent = new Button();
            exponent.Content = "xⁿ";
            engineeringKeys.Children.Add(exponent);
            Grid.SetRow(exponent, 1);
            Grid.SetColumn(exponent, 3);

            // Создаём кнопку для извлечения квадратного корня  
            Button squareRoot = new Button();
            squareRoot.Content = "²√x";
            engineeringKeys.Children.Add(squareRoot);
            Grid.SetRow(squareRoot, 2);
            Grid.SetColumn(squareRoot, 0);

            // Создаём кнопку для извлечения кубического корня  
            Button cubeRoot = new Button();
            cubeRoot.Content = "³√x";
            engineeringKeys.Children.Add(cubeRoot);
            Grid.SetRow(cubeRoot, 2);
            Grid.SetColumn(cubeRoot, 1);

            // Создаём кнопку для получения обратного значения  
            Button multiplicativeInverse = new Button();
            multiplicativeInverse.Content = "1/x";
            engineeringKeys.Children.Add(multiplicativeInverse);
            Grid.SetRow(multiplicativeInverse, 2);
            Grid.SetColumn(multiplicativeInverse, 2);

            // Создаём кнопку для получения факториала  
            Button factorial = new Button();
            factorial.Content = "n!";
            engineeringKeys.Children.Add(factorial);
            Grid.SetRow(factorial, 2);
            Grid.SetColumn(factorial, 3);
        }
    }
}
