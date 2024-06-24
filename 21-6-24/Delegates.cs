using System;

delegate int Operation(int x, int y);

class Program
{
    static int Add(int x, int y)
    {
        return x + y;
    }

    static int Subtract(int x, int y)
    {
        return x - y;
    }

    static void Main()
    {
        Operation op = Add;
        Console.WriteLine("Addition: " + op(3, 4));

        op = Subtract;
        Console.WriteLine("Subtraction: " + op(7, 2));
    }
}
