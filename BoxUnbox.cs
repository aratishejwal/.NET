using System;

class Program
{
    static void Main()
    {
        // Example  of Boxing
        int valueType = 123;      // Value type
        object boxedValue = valueType;  // Boxing: Converting value type to object type

        Console.WriteLine("Boxing:");
        Console.WriteLine("Value type: " + valueType);
        Console.WriteLine("Boxed value: " + boxedValue);

        // Example of Unboxing
        object obj = 456;         // Boxed value
        int unboxedValue = (int)obj; // Unboxing: Converting object type back to value type

        Console.WriteLine("\nUnboxing:");
        Console.WriteLine("Object type: " + obj);
        Console.WriteLine("Unboxed value: " + unboxedValue);

        // Another example with double
        double doubleValue = 78.9; // Value type
        object boxedDouble = doubleValue; // Boxing

        Console.WriteLine("\nBoxing double:");
        Console.WriteLine("Double value: " + doubleValue);
        Console.WriteLine("Boxed double: " + boxedDouble);

        double unboxedDouble = (double)boxedDouble; // Unboxing

        Console.WriteLine("\nUnboxing double:");
        Console.WriteLine("Object type: " + boxedDouble);
        Console.WriteLine("Unboxed double: " + unboxedDouble);
    }
}