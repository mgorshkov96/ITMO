using System;
using System.Diagnostics;

class BankAccount
{
    private long accNo;
    private decimal accBal;
    private AccountType accType;
    private static long nextAccNo = 123;

    public BankAccount()
    {
        accNo = NextNumber();
        accType = AccountType.Checking;
        accBal = 0;
    }

    public BankAccount(AccountType aType)
    {
        accNo = NextNumber();
        accType= aType;
        accBal= 0;
    }

    public BankAccount(decimal aBal)
    {
        accNo = NextNumber();
        accType = AccountType.Checking;
        accBal = aBal;
    }

    public BankAccount(AccountType aType, decimal aBal)
    {
        accNo = NextNumber();
        accType = aType;
        accBal = aBal;
    }

    public void TransferFrom(BankAccount accFrom, decimal amount)
    {
        if (accFrom.Withdraw(amount))
        {
            this.Deposit(amount);
        }
    }

    public decimal Deposit(decimal amount)
    {
        try
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("Amount less than zero");
            }
            accBal += amount;
            return accBal;
        }
        catch (ArgumentOutOfRangeException e)
        {
            Trace.WriteLine(e.Message);
            Console.WriteLine("Error: you entered amount less than zero.");
            return accBal;
        }
    }

    public bool Withdraw(decimal amount)
    {
        bool sufficientFunds = accBal >= amount;
        if (sufficientFunds)
        {
            accBal -= amount;
        }
        return sufficientFunds;
    }

    private static long NextNumber()
    {
        return nextAccNo++;
    }

    public long Number()
    {
        return accNo;
    }

    public decimal Balance()
    {
        return accBal;
    }

    public string Type()
    {
        return accType.ToString();
    }
}