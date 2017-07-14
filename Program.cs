using System;
using SplashKitSDK;

public class Program
{

    public static void Main()
    {
        Account account = new Account("Eddie", 200);
        Account account2 = new Account("Jeff", 200);

        account2.Deposit(50);
        Console.WriteLine("Jeff, you deposited $50");
        account2.Print();

        account.Withdraw(50);
        Console.WriteLine("Eddie, you withdrew $50");
        account.Print();

        account2.Withdraw(210);
        Console.WriteLine("Jeff, you withdrew $210");
        account2.Print();

        account.Withdraw(63);
        Console.WriteLine("Eddie, you withdrew $63");
        account.Print();








    }



}
