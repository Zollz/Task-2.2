using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {

        Console.WriteLine("What is your ")
        Account account = new Account("Eddie", 20000);
        Account account2 = new Account("Jeff", 50);
      

        account.Print();
        account.Deposit(500);
        account.PrintDeposit();
        account.Print();
    }
}
