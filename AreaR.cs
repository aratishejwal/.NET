using System;
namespace Area
{
  class Triangle
  {
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the length of Rectangle:");
        double l = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the breadth of Rectangle:");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("The Area of Rectangle: " + (l*b));
      }
      
    
  }
}