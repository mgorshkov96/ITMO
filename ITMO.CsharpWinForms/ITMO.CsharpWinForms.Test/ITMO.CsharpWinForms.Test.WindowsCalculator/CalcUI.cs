using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator;
using ITMO.CsharpWinForms.Test.WindowsCalculator;

namespace SimpleCalculator
{
    public partial class CalcUI : Form
    {
        // Output Display Constants.
        private const string oneOut = "1";
        private const string twoOut = "2";
        private const string threeOut = "3";
        private const string fourOut = "4";
        private const string fiveOut = "5";
        private const string sixOut = "6";
        private const string sevenOut = "7";
        private const string eightOut = "8";
        private const string nineOut = "9";
        private const string zeroOut = "0";

        private bool answer; // проверка на наличие ошибок в ядре при нажатии на кнопки действий

        public CalcUI()
        {
            InitializeComponent();

            //
            // Get version information from the Calculator Module.
            //

            VersionInfo.Text = CalcEngine.GetVersion();
            OutputDisplay.Text = "0";
            outputFactorial.Text = "0";

            // Задаем настройки меню по-умолчанию
            toolStripType.SelectedIndex = 0;
            toolStripTheme.SelectedIndex = 0;
        }

        protected void KeyPlus_Click(object sender, System.EventArgs e)
        {
            answer = CalcEngine.CalcOperation(CalcEngine.Operator.eAdd);
            if (!answer)
                OutputDisplay.Text = "0";
        }

        protected void KeyMinus_Click(object sender, System.EventArgs e)
        {
            answer = CalcEngine.CalcOperation(CalcEngine.Operator.eSubtract);
            if (!answer)
                OutputDisplay.Text = "0";
        }

        protected void KeyMultiply_Click(object sender, System.EventArgs e)
        {
            answer = CalcEngine.CalcOperation(CalcEngine.Operator.eMultiply);
            if (!answer)
                OutputDisplay.Text = "0";
        }

        protected void KeyDivide_Click(object sender, System.EventArgs e)
        {
            answer = CalcEngine.CalcOperation(CalcEngine.Operator.eDivide);
            if (!answer)
                OutputDisplay.Text = "0";
        }
        private void keyExponent_Click(object sender, EventArgs e)
        {
            answer = CalcEngine.CalcOperation(CalcEngine.Operator.eExponent);
            if (!answer)
                OutputDisplay.Text = "0";
        }

        //
        // Other non-numeric key click methods.
        //

        protected void KeySign_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcSign();
        }

        protected void KeyPoint_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcDecimal();
        }

        protected void KeyDate_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.GetDate();
            CalcEngine.CalcReset();
        }

        protected void KeyClear_Click(object sender, System.EventArgs e)
        {
            CalcEngine.CalcReset();
            OutputDisplay.Text = "0";
            outputFactorial.Text = "0";
        }

        private void keySquare_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.Square();

            if (OutputDisplay.Text != "")
                CalcEngine.EndOperation();
            else
                OutputDisplay.Text = "0";
        }

        private void keySquareRoot_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.SquareRoot();

            if (OutputDisplay.Text != "")
                CalcEngine.EndOperation();
            else
                OutputDisplay.Text = "0";
        }

        private void keyCubeRoot_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CubeRoot();

            if (OutputDisplay.Text != "")
                CalcEngine.EndOperation();
            else
                OutputDisplay.Text = "0";
        }

        private void keyMultiplicativeInverse_Click(object sender, EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.MultiplicativeInverse();

            if (OutputDisplay.Text != "")
                CalcEngine.EndOperation();
            else
                OutputDisplay.Text = "0";
        }

        private async void keyFactorial_Click(object sender, EventArgs e)
        {
            if (int.TryParse(CalcEngine.CalcNumber(""), out int n))
            {
                CalcEngine.CalcReset();
                int fact = await CalcEngine.Factorial(n);
                outputFactorial.Text = fact.ToString();
            }
            else
            {
                MessageBox.Show("Расчёт факториала возможен только с целыми числами");
                CalcEngine.CalcReset();
            }

        }

        //
        // Perform the calculation.
        //

        protected void KeyEqual_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcEqual();
            CalcEngine.EndOperation();
        }

        //
        // Numeric key click methods.
        //

        protected void KeyNine_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(nineOut);
        }

        protected void KeyEight_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(eightOut);
        }

        protected void KeySeven_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(sevenOut);
        }

        protected void KeySix_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(sixOut);
        }

        protected void KeyFive_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(fiveOut);
        }

        protected void KeyFour_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(fourOut);
        }

        protected void KeyThree_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(threeOut);
        }

        protected void KeyTwo_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(twoOut);
        }

        protected void KeyOne_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(oneOut);
        }

        protected void KeyZero_Click(object sender, System.EventArgs e)
        {
            OutputDisplay.Text = CalcEngine.CalcNumber(zeroOut);
        }

        //
        // End the program.
        //

        protected void KeyExit_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void toolStripType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripType.SelectedIndex == 0)
            {
                this.MaximumSize = new Size(280, 310);
                this.MinimumSize = new Size(280, 310);
                this.Size = new Size(280, 310);
            }
            else if (toolStripType.SelectedIndex == 1)
            {
                this.MaximumSize = new Size(400, 310);
                this.MinimumSize = new Size(400, 310);
                this.Size = new Size(400, 310);
            }
        }

        private void toolStripTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripTheme.SelectedIndex == 0)
            {
                this.BackColor = SystemColors.Control;
                this.BackColor = SystemColors.Control;
                this.KeyExit.BackColor = SystemColors.Control;
                this.KeyDate.BackColor = SystemColors.Control;
                this.KeyClear.BackColor = SystemColors.Control;
                this.KeyMinus.BackColor = SystemColors.Control;
                this.KeyPlus.BackColor = SystemColors.Control;
                this.KeyEqual.BackColor = SystemColors.Control;
                this.KeyMultiply.BackColor = SystemColors.Control;
                this.KeyDivide.BackColor = SystemColors.Control;
                this.KeyPoint.BackColor = SystemColors.Control;
                this.KeySign.BackColor = SystemColors.Control;
                this.KeyZero.BackColor = SystemColors.Control;
                this.KeyNine.BackColor = SystemColors.Control;
                this.KeyEight.BackColor = SystemColors.Control;
                this.KeySeven.BackColor = SystemColors.Control;
                this.KeySix.BackColor = SystemColors.Control;
                this.KeyFive.BackColor = SystemColors.Control;
                this.KeyFour.BackColor = SystemColors.Control;
                this.KeyThree.BackColor = SystemColors.Control;
                this.KeyTwo.BackColor = SystemColors.Control;
                this.KeyOne.BackColor = SystemColors.Control;
                this.keyExponent.BackColor = SystemColors.Control;
                this.keySquareRoot.BackColor = SystemColors.Control;
                this.keyMultiplicativeInverse.BackColor = SystemColors.Control;
                this.keySquare.BackColor = SystemColors.Control;
                this.keyFactorial.BackColor = SystemColors.Control;
                this.keyCubeRoot.BackColor = SystemColors.Control;
                this.keyQuadraticEquation.BackColor = SystemColors.Control;
                this.lblFactorial.ForeColor = SystemColors.ControlText;
            }
            else if (toolStripTheme.SelectedIndex == 1)
            {
                this.BackColor = Color.Black;
                this.KeyExit.BackColor = Color.Gray;
                this.KeyDate.BackColor = Color.Gray;
                this.KeyClear.BackColor = Color.Gray;
                this.KeyMinus.BackColor = Color.Gray;
                this.KeyPlus.BackColor = Color.Gray;
                this.KeyEqual.BackColor = Color.Gray;
                this.KeyMultiply.BackColor = Color.Gray;
                this.KeyDivide.BackColor = Color.Gray;
                this.KeyPoint.BackColor = Color.Gray;
                this.KeySign.BackColor = Color.Gray;
                this.KeyZero.BackColor = Color.Gray;
                this.KeyNine.BackColor = Color.Gray;
                this.KeyEight.BackColor = Color.Gray;
                this.KeySeven.BackColor = Color.Gray;
                this.KeySix.BackColor = Color.Gray;
                this.KeyFive.BackColor = Color.Gray;
                this.KeyFour.BackColor = Color.Gray;
                this.KeyThree.BackColor = Color.Gray;
                this.KeyTwo.BackColor = Color.Gray;
                this.KeyOne.BackColor = Color.Gray;
                this.keyExponent.BackColor = Color.Gray;
                this.keySquareRoot.BackColor = Color.Gray;
                this.keyMultiplicativeInverse.BackColor = Color.Gray;
                this.keySquare.BackColor = Color.Gray;
                this.keyFactorial.BackColor = Color.Gray;
                this.keyCubeRoot.BackColor = Color.Gray;
                this.keyQuadraticEquation.BackColor = Color.Gray;
                this.lblFactorial.ForeColor = Color.White;
            }
        }    

        private void keyQuadraticEquation_Click(object sender, EventArgs e)
        {
            Сoefficients coef = new Сoefficients(toolStripTheme.SelectedIndex);
            coef.StartPosition = FormStartPosition.Manual;
            coef.Location = new Point(this.Location.X + this.Width, this.Location.Y);

            if (coef.ShowDialog() != DialogResult.OK)
                return;
            else
            {
                try
                {
                    double a = double.Parse(coef.СoefficientA);
                    double b = double.Parse(coef.СoefficientB);
                    double c = double.Parse(coef.СoefficientC);

                    if (a != 0)
                    { 
                        OutputDisplay.Text = CalcEngine.QuadraticEquation(a, b, c);
                        CalcEngine.CalcReset();
                    }
                    else
                        MessageBox.Show("Коэффициент a не может быть равень нулю");
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Ошибка при заполнении коэффициентов!");
                }
            }
        }

        
    }
}
