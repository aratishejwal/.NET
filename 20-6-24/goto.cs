using System;

class Program
{
    static void Main()
    {
        int count = 0;

        // Using a loop to demonstrate the goto statement
        startLoop:

        count++;
        Console.WriteLine("Count is: " + count);

        if (count < 3)
            goto startLoop;

        Console.WriteLine("End of program.");
    }
}
