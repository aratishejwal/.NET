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

    Console.WriteLine("Maximum:" + Math.Max(num1,num2));
    Console.WriteLine("Minimum:"+ Math.Min(num1,num2));
      }
      
    
  }
}