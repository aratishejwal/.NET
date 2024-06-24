using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list to store names
        List<string> names = new List<string>();

        // Ask the user how many names they want to enter
        Console.Write("How many names would you like to enter? ");
        int numberOfNames;
        numberOfNames=Convert.ToInt32(Console.ReadLine());
        // Get names from the user
        for (int i = 0; i < numberOfNames; i++)
        {
            Console.Write("Enter name "+(i + 1)+": ");
            names.Add(Console.ReadLine());
        }
        Console.WriteLine("Before Sorting:");
        foreach (string name in names)
        {
            Console.Write(name+" ");
        }

        // Sort the list in alphabetical order
        names.Sort();

        // Print the sorted list
        Console.WriteLine("\nNames in alphabetical order:");
        foreach (string name in names)
        {
            Console.Write(name+" ");
        }
    }
}
