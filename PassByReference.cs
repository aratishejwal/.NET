using System;

class Program
{
    static void Main(string[] args)
    {
        // Declare an initial balance
        decimal balance = 1000.00m;

        Console.WriteLine("Initial balance: $" + balance);

        // Deposit an amount
        Deposit(ref balance, 250.00m);
        Console.WriteLine("Balance after deposit: $" + balance);

        // Withdraw an amount
        Withdraw(ref balance, 300.00m);
        Console.WriteLine("Balance after withdrawal: $" + balance);
    }

    // Method to deposit money (pass by reference)
    static void Deposit(ref decimal accountBalance, decimal amount)
    {
        accountBalance += amount;
        Console.WriteLine("Deposited: $" + amount);
    }

    // Method to withdraw money (pass by reference)
    static void Withdraw(ref decimal accountBalance, decimal amount)
    {
        if (amount <= accountBalance)
        {
            accountBalance -= amount;
            Console.WriteLine("Withdrew: $" + amount);
        }
        else
        {
            Console.WriteLine("Insufficient funds to withdraw: $" + amount);
        }
    }
}
