using System;
namespace Area
{
  class Triangle
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter the base of triangle:");
      double b = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine("Enter the height of triangle:");
      double h = Convert.ToDouble(Console.ReadLine());

      Console.WriteLine("The Area of Triangle: " + (0.5*b*h));
      }
      
    
  }
}