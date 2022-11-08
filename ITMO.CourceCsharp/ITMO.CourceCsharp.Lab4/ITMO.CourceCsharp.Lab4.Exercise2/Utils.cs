namespace ITMO.CourceCsharp.Lab4.Exercise2
{
    class Utils
    {
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
    }
}
