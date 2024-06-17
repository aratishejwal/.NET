using System;
namespace Concat
{
    class strings{
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter first String:");
            string string1=Console.ReadLine();
            Console.WriteLine("Enter second String:");
            string string2=Console.ReadLine();
            Console.WriteLine("The Concatenated string:"+(string1+string2));
        }
    }
}