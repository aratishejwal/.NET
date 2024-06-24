using System;

namespace MathOperations
{
    public class Arithmetic
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return a - b;
        }

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(int a, int b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException("Division by zero is not allowed.");
            }
            return (double)a / b;
        }
    }
}

namespace GreetingOperations
{
    public class Greeter
    {
        public void SayHello(string name)
        {
            Console.WriteLine("Hello, " + name + "!");
        }

        public void SayGoodbye(string name)
        {
            Console.WriteLine("Goodbye, " + name + "!");
        }
    }
}

class Program
{
    static void Main()
    {
        // Using the Arithmetic class from the MathOperations namespace
        MathOperations.Arithmetic arithmetic = new MathOperations.Arithmetic();
        int sum = arithmetic.Add(10, 5);
        int difference = arithmetic.Subtract(10, 5);
        int product = arithmetic.Multiply(10, 5);
        double quotient = arithmetic.Divide(10, 5);

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Difference: " + difference);
        Console.WriteLine("Product: " + product);
        Console.WriteLine("Quotient: " + quotient);

        // Using the Greeter class from the GreetingOperations namespace
        GreetingOperations.Greeter greeter = new GreetingOperations.Greeter();
        greeter.SayHello("Alice");
        greeter.SayGoodbye("Bob");
    }
}
