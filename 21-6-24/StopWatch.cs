using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        Stopwatch stopwatch = new Stopwatch();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nStopwatch Menu:");
            Console.WriteLine("1. Start");
            Console.WriteLine("2. Stop");
            Console.WriteLine("3. Reset");
            Console.WriteLine("4. Display Time");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    stopwatch.Start();
                    Console.WriteLine("Stopwatch started.");
                    break;

                case "2":
                    stopwatch.Stop();
                    Console.WriteLine("Stopwatch stopped.");
                    break;

                case "3":
                    stopwatch.Reset();
                    Console.WriteLine("Stopwatch reset.");
                    break;

                case "4":
                    TimeSpan elapsed = stopwatch.Elapsed;
                    Console.WriteLine("Elapsed Time: {0:hh\\:mm\\:ss\\.fff}", elapsed);
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }

        Console.WriteLine("Exiting Stopwatch application. Goodbye!");
    }
}
