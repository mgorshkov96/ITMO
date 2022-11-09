using System;

namespace ITMO.CsharpCource.Lab01.Exercise1
{
    class Greeter
    {
        public static void Main(string[] args)
        {
            string myName;

            Console.WriteLine("Please enter your name");
            myName = Console.ReadLine();
            Console.WriteLine("Hello {0}", myName);
            Console.ReadKey();
        }
    }
}