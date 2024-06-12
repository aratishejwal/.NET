using System;
namespace Fibonacci
{
    class fibo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            int n=Convert.ToInt32(Console.ReadLine());

            if (n < 1) {
                Console.WriteLine("Invalid Number of terms\n");
                return;
            }
 
            // when number of terms is greater than 0
            int prev1 = 1;
            int prev2 = 0;
 
            // for loop to print fibonacci series
            for (int i = 1; i <= n; i++) 
            {
                if (i > 2) {
                    int num = prev1 + prev2;
                    prev2 = prev1;
                    prev1 = num;
                    Console.Write(num+" ");
                }
 
                // for first two terms
                if (i == 1) {
                     Console.Write(prev2+" ");
                }
                if (i == 2) {
                    Console.Write(prev1+" ");
                }
            }    
        }
    }
}


