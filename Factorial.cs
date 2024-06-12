using System;
namespace Factori{
    class fact{
        static void Main(string[] args){

            int num,fact=1;
            Console.WriteLine("Factorial.");
            Console.WriteLine("Enter the number to find the factorial:");
            num=Convert.ToInt32(Console.ReadLine());

            for(int i=1;i<=num;i++)
            {
                fact=fact*i;
            }
            Console.WriteLine("Factorial is: "+fact);
    }
}
}