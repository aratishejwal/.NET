using System;
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter the age:");
      int age = Convert.ToInt32(Console.ReadLine());
      if(age>=21&&age<32)
      {
      Console.WriteLine("Allow for upsc exam.");
      }
      else{
        Console.WriteLine("Don't allow.");
      }
      
      }
      
    
  }
}