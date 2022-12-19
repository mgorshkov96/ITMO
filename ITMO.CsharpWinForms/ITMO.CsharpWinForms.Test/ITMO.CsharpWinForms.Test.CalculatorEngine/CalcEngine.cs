using System.Reflection;

namespace Calculator
{

    using System;
    using System.Threading;
    using System.Threading.Tasks;

    public class CalcEngine
    {
        //
        // Operation Constants.
        //
        public enum Operator : int
        {
            eUnknown = 0,
            eAdd = 1,
            eSubtract = 2,
            eMultiply = 3,
            eDivide = 4,
            eExponent = 5
        }

        //
        // Module-Level Constants
        //

        private static double negativeConverter = -1;
        // TODO: Upgrade the version number to 3.0.1.1
        private static string versionInfo = "Calculator v2.0.1.1";

        //
        // Module-level Variables.
        //

        private static double numericAnswer;
        private static string stringAnswer;
        private static Operator calcOperation;
        private static double firstNumber;
        private static double secondNumber;
        private static bool secondNumberAdded;
        private static bool decimalAdded;

        //
        // Class Constructor.
        //

        public CalcEngine()
        {
            decimalAdded = false;
            secondNumberAdded = false;
        }

        //
        // Returns the custom version string to the caller.
        //

        public static string GetVersion()
        {
            return (versionInfo);
        }
        //
        // Called when the Date key is pressed.
        //

        public static string GetDate()
        {
            DateTime curDate = new DateTime();
            curDate = DateTime.Now;

            stringAnswer = String.Concat(curDate.ToShortDateString(), " ", curDate.ToLongTimeString());

            return (stringAnswer);
        }

        //
        // Called when a number key is pressed on the keypad.
        //

        public static string CalcNumber(string KeyNumber)
        {
            stringAnswer = stringAnswer + KeyNumber;
            return (stringAnswer);
        }

        //
        // Called when an operator is selected (+, -, *, /)
        //

        public static bool CalcOperation(Operator calcOper)
        {
            bool answer;

            if (stringAnswer != "" && !secondNumberAdded)
            {
                firstNumber = System.Convert.ToDouble(stringAnswer);
                calcOperation = calcOper;
                stringAnswer = "";
                decimalAdded = false;
                answer = true;
            }
            else
            {
                CalcReset();
                answer = false;
            }
            return (answer);
        }

        //
        // Called when the +/- key is pressed.
        //

        public static string CalcSign()
        {
            double numHold;

            if (stringAnswer != "")
            {
                numHold = System.Convert.ToDouble(stringAnswer);
                stringAnswer = System.Convert.ToString(numHold * negativeConverter);
            }

            return (stringAnswer);
        }

        //
        // Called when the . key is pressed.
        //

        public static string CalcDecimal()
        {
            if (!decimalAdded && !secondNumberAdded)
            {
                if (stringAnswer != "")
                    stringAnswer = stringAnswer + ",";
                else
                    stringAnswer = "0,";

                decimalAdded = true;
            }

            return (stringAnswer);
        }

        //
        // Called when the x² key is pressed.
        //

        public static string Square()
        {
            if (double.TryParse(stringAnswer, out firstNumber))
            {                
                numericAnswer = firstNumber * firstNumber;
                stringAnswer = System.Convert.ToString(numericAnswer);
            }
            else
            {
                CalcReset();
            }

            return (stringAnswer);
        }

        //
        // Called when the ²√x key is pressed.
        //

        public static string SquareRoot()
        {
            if (double.TryParse(stringAnswer, out firstNumber))
            {
                numericAnswer = Math.Sqrt(firstNumber);
                stringAnswer = System.Convert.ToString(numericAnswer);
            }
            else
            {
                CalcReset();
            }

            return (stringAnswer);
        }

        //
        // Called when the ³√x key is pressed.
        //

        public static string CubeRoot()
        {
            if (double.TryParse(stringAnswer, out firstNumber))
            {
                numericAnswer = Math.Round(Math.Pow(firstNumber, 0.33333333333333333), 15, MidpointRounding.AwayFromZero);
                stringAnswer = System.Convert.ToString(numericAnswer);
            }
            else
            {
                CalcReset();
            }

            return (stringAnswer);
        }

        //
        // Called when the QuadraticEquation key is pressed.
        //

        public static string QuadraticEquation(double a, double b, double c)
        {
            double x1;
            double x2;
            double disc;

            if (b == 0 & c == 0)
            {
                stringAnswer = "x = 0";
            }
            else if (b == 0 & c != 0)
            {
                if (((c * -1) / a) < 0)
                {
                    stringAnswer = "Нет корней";
                }
                else
                {
                    x1 = Math.Round(Math.Sqrt((c * -1) / a), 3, MidpointRounding.AwayFromZero);
                    stringAnswer = "x1 = " + x1.ToString() + "; x2 = " + (x1 * -1).ToString();
                }
            }
            else if (b != 0 & c == 0)
            {
                x1 = Math.Round((b * -1) / a, 3, MidpointRounding.AwayFromZero);
                stringAnswer = "x1 = 0; x2 = " + x1.ToString();
            }
            else if (b != 0 & c != 0)
            {
                disc = (b*b) - (4*a*c);

                if (disc < 0)
                {
                    stringAnswer = "Нет корней";
                }
                else if (disc == 0)
                {
                    x1 = Math.Round((b * -1) / (2 * a), 3, MidpointRounding.AwayFromZero);
                    stringAnswer = "x = " + x1.ToString();
                }
                else if (disc > 0)
                {
                    x1 = Math.Round(((b * -1) + Math.Sqrt(disc)) / (2 * a), 3, MidpointRounding.AwayFromZero);
                    x2 = Math.Round(((b * -1) - Math.Sqrt(disc)) / (2 * a), 3, MidpointRounding.AwayFromZero);
                    stringAnswer = "x1 = " + x1.ToString() + "; x2 = " + x2.ToString();
                }
            }

            return (stringAnswer);
        }

        //
        // Called when the 1/x key is pressed.
        //

        public static string MultiplicativeInverse()
        {
            if (double.TryParse(stringAnswer, out firstNumber))
            {
                numericAnswer = Math.Round(1 / firstNumber, 15, MidpointRounding.AwayFromZero);
                stringAnswer = System.Convert.ToString(numericAnswer);
            }
            else
            {
                CalcReset();
            }

            return (stringAnswer);
        }

        //
        // Called when the n! key is pressed.
        //

        public static async Task<int> Factorial(int n)
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(5000);
                int factorial = 1;

                for (int i = 1; i <= n; i++)
                    factorial *= i;

                return factorial;
            }
            );
        }

        //
        // Called when = is pressed.
        //

        public static string CalcEqual()
        {
            bool validEquation = false;

            if (stringAnswer != "")
            {
                secondNumber = System.Convert.ToDouble(stringAnswer);
                secondNumberAdded = true;

                switch (calcOperation)
                {
                    case Operator.eUnknown:
                        validEquation = false;
                        break;

                    case Operator.eAdd:
                        numericAnswer = firstNumber + secondNumber;
                        validEquation = true;
                        break;

                    case Operator.eSubtract:
                        numericAnswer = firstNumber - secondNumber;
                        validEquation = true;
                        break;

                    case Operator.eMultiply:
                        numericAnswer = firstNumber * secondNumber;
                        validEquation = true;
                        break;

                    case Operator.eDivide:
                        numericAnswer = firstNumber / secondNumber;
                        validEquation = true;
                        break;

                    case Operator.eExponent:
                        numericAnswer = Math.Pow(firstNumber, secondNumber);
                        validEquation = true;
                        break;

                    default:
                        validEquation = false;
                        break;
                }

                if (validEquation)
                { 
                    stringAnswer = System.Convert.ToString(numericAnswer);
                    
                }
            }

            return (stringAnswer);
        }
        

        //
        // Resets the various module-level variables for the next calculation.
        //
        public static void EndOperation()
        {            
            stringAnswer = System.Convert.ToString(numericAnswer);
            numericAnswer = 0;
            firstNumber = 0;
            secondNumber = 0;
            calcOperation = Operator.eUnknown;
            decimalAdded = false;
            secondNumberAdded = false;
        }

        public static void CalcReset()
        {
            numericAnswer = 0;
            stringAnswer = "";
            firstNumber = 0;
            secondNumber = 0;           
            calcOperation = Operator.eUnknown;
            decimalAdded = false;
            secondNumberAdded = false;            
        }
    }
}