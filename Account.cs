using System;

public class Account
{
    private decimal _balance;
    private string _name;
    public int amountToAdd;
    public int amountToSubtract;



    public Account(string name, decimal startingBalance)
    {
        _name = name;
        _balance = startingBalance;
        Console.WriteLine("Your name is " + _name + " and your account balance is $" + _balance);
    }

    public void Deposit(decimal amountToAdd)
    {
        _balance += amountToAdd;
    }

    public void Withdraw(decimal amountToSubtract)
    {
        _balance -= amountToSubtract;
    }

    public void Print()
    {
        Console.WriteLine("Your balance is currently " + _balance + ".");
    }

    public void PrintDeposit()
    {
        Console.WriteLine("You have deposited {0}", amountToAdd);
    }

    public void PrintWithdraw()
    {
        Console.WriteLine("You have withdrawn" + amountToSubtract);
    }

    public string Name
    {
        get { return _name; }
    }

}



