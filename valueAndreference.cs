using System;

class Program
{
    static void Main()
    {
        // Example with Value Type
        int valueType = 10;
        Console.WriteLine("Before ModifyValueType: " + valueType);
        ModifyValueType(valueType);
        Console.WriteLine("After ModifyValueType: " + valueType);

        // Example with Reference Type
        MyClass referenceType = new MyClass();
        referenceType.Number = 10;
        Console.WriteLine("Before ModifyReferenceType: " + referenceType.Number);
        ModifyReferenceType(referenceType);
        Console.WriteLine("After ModifyReferenceType: " + referenceType.Number);
    }

    // Method to demonstrate pass by value (Value Type)
    static void ModifyValueType(int num)
    {
        num = 20;
        Console.WriteLine("Inside ModifyValueType: " + num);
    }

    // Method to demonstrate pass by reference (Reference Type)
    static void ModifyReferenceType(MyClass obj)
    {
        obj.Number = 20;
        Console.WriteLine("Inside ModifyReferenceType: " + obj.Number);
    }
}

// Reference Type Class
class MyClass
{
    public int Number { get; set; }
}
