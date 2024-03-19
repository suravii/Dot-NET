using System;
using System.Collections.Generic;

class BankAccount
{
    public string Owner { get; }
    public double Balance { get; private set; }

    public BankAccount(string owner)
    {
        Owner = owner;
        Balance = 0;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
        Console.WriteLine($"Deposited {amount} into {Owner}'s account. New balance: {Balance}");
    }

    public void Withdraw(double amount)
    {
        if (amount > Balance)
        {
            Console.WriteLine("Insufficient funds!");
        }
        else
        {
            Balance -= amount;
            Console.WriteLine($"Withdrawn {amount} from {Owner}'s account. New balance: {Balance}");
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine($"Current balance of {Owner}'s account: {Balance}");
    }
}

class Program
{
    static Dictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();
    static int accountIdCounter = 1;

    static void Main(string[] args)
    {
        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\n1. Create Account\n2. Deposit\n3. Withdraw\n4. Check Balance\n5. Exit");
            Console.Write("Select an option: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CreateAccount();
                    break;
                case 2:
                    Deposit();
                    break;
                case 3:
                    Withdraw();
                    break;
                case 4:
                    CheckBalance();
                    break;
                case 5:
                    exit = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void CreateAccount()
    {
        Console.Write("Enter owner's name: ");
        string owner = Console.ReadLine();
        BankAccount account = new BankAccount(owner);
        accounts.Add(accountIdCounter, account);
        Console.WriteLine($"Account created successfully with ID: {accountIdCounter}");
        accountIdCounter++;
    }

    static void Deposit()
    {
        Console.Write("Enter account ID: ");
        int accountId = Convert.ToInt32(Console.ReadLine());
        if (accounts.ContainsKey(accountId))
        {
            Console.Write("Enter deposit amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            accounts[accountId].Deposit(amount);
        }
        else
        {
            Console.WriteLine("Invalid account ID!");
        }
    }

    static void Withdraw()
    {
        Console.Write("Enter account ID: ");
        int accountId = Convert.ToInt32(Console.ReadLine());
        if (accounts.ContainsKey(accountId))
        {
            Console.Write("Enter withdrawal amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());
            accounts[accountId].Withdraw(amount);
        }
        else
        {
            Console.WriteLine("Invalid account ID!");
        }
    }

    static void CheckBalance()
    {
        Console.Write("Enter account ID: ");
        int accountId = Convert.ToInt32(Console.ReadLine());
        if (accounts.ContainsKey(accountId))
        {
            accounts[accountId].CheckBalance();
        }
        else
        {
            Console.WriteLine("Invalid account ID!");
        }
    }
}
