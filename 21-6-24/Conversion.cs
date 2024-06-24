using System;

class Program
{
    static void Main()
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nConversion Menu:");
            Console.WriteLine("1. Convert Meters to Kilometers");
            Console.WriteLine("2. Convert Kilometers to Meters");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ConvertMetersToKilometers();
                    break;

                case "2":
                    ConvertKilometersToMeters();
                    break;

                case "3":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        Console.WriteLine("Exiting the application. Goodbye!");
    }

    static void ConvertMetersToKilometers()
    {
        Console.Write("Enter the distance in meters: ");
        string input = Console.ReadLine();
        double meters;
        if (double.TryParse(input, out meters))
        {
            double kilometers = meters / 1000;
            Console.WriteLine("{0} meters is equal to {1} kilometers.", meters, kilometers);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }
    }

    static void ConvertKilometersToMeters()
    {
        Console.Write("Enter the distance in kilometers: ");
        string input = Console.ReadLine();
        double kilometers;
        if (double.TryParse(input, out kilometers))
        {
            double meters = kilometers * 1000;
            Console.WriteLine("{0} kilometers is equal to {1} meters.", kilometers, meters);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a numeric value.");
        }
    }
}
