using System;
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter the age:");
      int age = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(!(age > 3 && age < 10));
      
      }
      
    
  }
}