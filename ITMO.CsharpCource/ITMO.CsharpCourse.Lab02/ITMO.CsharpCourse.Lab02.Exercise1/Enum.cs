using System;

namespace ITMO.CsharpCourse.Lab01.Exercise1
{
    public enum AccountType { Checking, Deposit }
    class Enum
    {
        public static void Main(string[] args)
        {
            AccountType goldAccount;
            AccountType platinumAccount;

            goldAccount = AccountType.Checking;
            platinumAccount = AccountType.Deposit;

            Console.WriteLine("The Customer Account Type is {0}", goldAccount);
            Console.WriteLine("The Customer Account Type is {0}", platinumAccount);
        }
    }
}
