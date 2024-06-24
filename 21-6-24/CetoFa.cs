using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a temperature in Celsius
        Console.Write("Enter temperature in Celsius: ");
        string input = Console.ReadLine();
        
        // Parse the input to a double
        double celsius;
        if (double.TryParse(input, out celsius))
        {
            // Convert Celsius to Fahrenheit
            double fahrenheit = (celsius * 9 / 5) + 32;
            
            // Display the result
            Console.WriteLine("{0}°C is equal to {1}°F", celsius, fahrenheit);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }
    }
}
