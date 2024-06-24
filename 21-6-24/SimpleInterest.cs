using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter rate of interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter time (in years): ");
        int time = Convert.ToInt32(Console.ReadLine());

        double interest = (principal * rate * time) / 100;
        Console.WriteLine("Simple Interest: " + interest);
    }
}
