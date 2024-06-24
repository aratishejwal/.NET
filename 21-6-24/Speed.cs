using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter distance (in meters): ");
        double distance = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter speed (in meters per second): ");
        double speed = Convert.ToDouble(Console.ReadLine());

        double time = distance / speed;
        Console.WriteLine("Time required: " + time + " seconds");
    }
}
