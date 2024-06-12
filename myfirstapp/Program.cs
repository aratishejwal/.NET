// See https://aka.ms/new-console-template for more information
namespace MyApplication
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Enter the number:");
      int num = Convert.ToInt32(Console.ReadLine());
      if(num%2==0){
        Console.WriteLine("The number is even: " + num);
      }
      else{
      Console.WriteLine("The number  is odd: " +num );
      }
    }
  }
}