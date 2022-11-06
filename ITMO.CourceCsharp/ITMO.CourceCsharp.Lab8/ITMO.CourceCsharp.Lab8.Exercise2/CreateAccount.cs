using System;

class CreateAccount
{
    static void Main()
    {
        BankAccount acc1 = new BankAccount();
        BankAccount acc2 = new BankAccount(AccountType.Deposit);
        BankAccount acc3 = new BankAccount(100);
        BankAccount acc4 = new BankAccount(AccountType.Deposit, 500);

        acc1.Deposit(1000);
        acc2.TransferFrom(acc1, 500);
        acc3.Deposit(1000);
        acc4.Withdraw(400);
        acc4.TransferFrom(acc3, 550);

        Write(acc1);
        Write(acc2);
        Write(acc3);
        Write(acc4);
    }

    static void Write(BankAccount acc)
    {
        Console.WriteLine("Account number is {0}", acc.Number());
        Console.WriteLine("Account balance is {0}", acc.Balance());
        Console.WriteLine("Account type is {0}", acc.Type());
        Console.WriteLine("Transactions:");

        foreach (BankTransaction tran in acc.Transactions())
        {
            Console.WriteLine("Date/Time: {0}\tAmount: {1}", tran.When(), tran.Amount());
        }
        Console.WriteLine();
    }
}