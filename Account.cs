using System;

public class Account
{
    private decimal _balance;
    private string _name;
    //Constructor
    public Account(string name, decimal startingBalance)
    {
    _name = name;
    _balance = startingBalance;
    Console.WriteLine("Your name is " + _name + " your balance is " + _balance);
    
    }

    public void Deposit(decimal amountToAdd)
    {
    _balance = _balance + amountToAdd;
    }

    public void Withdraw(decimal amountToSubtract)
    {
    _balance = _balance - amountToSubtract;
    }

    public string Name
    {
    get { return _name; }
    }

}



