using ITMO.CourceCsharp.Lab7.Exercise2;
using System;

public class Test
{
    public static void Main()
    {
        Console.WriteLine("Enter string to reverse:");
        string message = Console.ReadLine();

        Utils.Reverse(ref message);

        Console.WriteLine(message);
    }
}