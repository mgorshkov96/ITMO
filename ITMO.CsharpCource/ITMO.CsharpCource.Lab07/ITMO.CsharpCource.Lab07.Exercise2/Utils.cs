namespace ITMO.CsharpCource.Lab07.Exercise2
{
    using System;
    using System.Diagnostics;

    class Utils
    {
        public static void Reverse(ref string s)
        {
            string sRev = "";
            for (int k = s.Length - 1; k >= 0; k--)
                sRev = sRev + s[k];

            // Return result to caller
            s = sRev;
        }

        //
        // Return the greater of two integer values
        //
        public static int Greater(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }

        //
        // Exchange two integers, passed by reference
        //
        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // Calculate factorial
        // and return the result as an out parameter
        public static bool Factorial(int n, out int answer)
        {
            int k; // Loop counter
            int f; // Working value
            bool ok = true; // True if okay, false if not

            // Check the input value

            if (n < 0)
                ok = false;

            // Calculate the factorial value as the
            // product of all of the numbers from 2 to n

            try
            {
                checked
                {
                    f = 1;
                    for (k = 2; k <= n; ++k)
                    {
                        f = f * k;
                    }
                }
            }
            catch (OverflowException e)
            {
                // If something goes wrong in the calculation,
                // catch it here. All exceptions
                // are handled the same way: set the result
                // to zero and return false.

                Trace.WriteLine(e.Message);

                f = 0;
                ok = false;
            }

            // Assign result value
            answer = f;
            // Return to caller
            return ok;
        }

    }
}