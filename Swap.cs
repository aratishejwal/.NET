using System;
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Before Swapping:");
        Console.WriteLine("num1=" + num1);
        Console.WriteLine("num2=" + num2);
        int num3;
        num3=num1;
        num1=num2;
        num2=num3;
        Console.WriteLine("After swaping:");
        Console.WriteLine("num1="+num1);
        Console.WriteLine("num2="+num2);
      }
      
    
  }
}