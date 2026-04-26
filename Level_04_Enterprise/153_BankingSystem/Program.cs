using System;
using System.Collections.Generic;

class Account
{
    public int Id { get; set; }
    public string Name { get; set; }
    public double Balance { get; set; }
}

class Program
{
    static List<Account> accounts = new List<Account>();
    static int idCounter = 1;

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n--- Banking System ---");
            Console.WriteLine("1. Create Account");
            Console.WriteLine("2. View Accounts");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. Withdraw");
            Console.WriteLine("5. Exit");
            Console.Write("Enter choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateAccount();
                    break;
                case 2:
                    ViewAccounts();
                    break;
                case 3:
                    Deposit();
                    break;
                case 4:
                    Withdraw();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    static void CreateAccount()
    {
        Console.Write("Enter Name: ");
        string name = Console.ReadLine();

        accounts.Add(new Account { Id = idCounter++, Name = name, Balance = 0 });

        Console.WriteLine("Account Created!");
    }

    static void ViewAccounts()
    {
        Console.WriteLine("\n--- Account List ---");

        foreach (var acc in accounts)
        {
            Console.WriteLine($"ID: {acc.Id}, Name: {acc.Name}, Balance: {acc.Balance}");
        }
    }

    static void Deposit()
    {
        Console.Write("Enter Account ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var acc = accounts.Find(a => a.Id == id);

        if (acc != null)
        {
            Console.Write("Enter Amount: ");
            double amt = Convert.ToDouble(Console.ReadLine());

            acc.Balance += amt;
            Console.WriteLine("Deposit Successful!");
        }
        else
        {
            Console.WriteLine("Account not found!");
        }
    }

    static void Withdraw()
    {
        Console.Write("Enter Account ID: ");
        int id = Convert.ToInt32(Console.ReadLine());

        var acc = accounts.Find(a => a.Id == id);

        if (acc != null)
        {
            Console.Write("Enter Amount: ");
            double amt = Convert.ToDouble(Console.ReadLine());

            if (amt <= acc.Balance)
            {
                acc.Balance -= amt;
                Console.WriteLine("Withdraw Successful!");
            }
            else
            {
                Console.WriteLine("Insufficient Balance!");
            }
        }
        else
        {
            Console.WriteLine("Account not found!");
        }
    }
}