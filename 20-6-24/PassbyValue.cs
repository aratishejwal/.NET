using System;

class Program
{
    static void Main()
    {
        // Declare an integer variable
        int number = 10;

        Console.WriteLine("Before calling PassByValue method, number = " + number);

        // Call the method and pass the variable by value
        PassByValue(number);

        Console.WriteLine("After calling PassByValue method, number = " + number);
    }

    // Method to demonstrate pass by value
    static void PassByValue(int num)
    {
        // Modify the parameter
        num = 20;
        Console.WriteLine("Inside PassByValue method, num = " + num);
    }
}
