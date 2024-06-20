using System;

class Program
{
    static void Main(string[] args)
    {
        // Prompt the user to enter a string
        Console.WriteLine("Enter a string in uppercase:");

        // Read input from the user
        string input = Console.ReadLine();

        // Convert input to lowercase
        string converted = input.ToLower();

        // Output the converted string
        Console.WriteLine("Original: " + input);
        Console.WriteLine("Converted: " + converted);
    }
}
