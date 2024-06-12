using System;
namespace Application
{
    class Assignment{
        public static void Main(string[] args){
            int N;
            Console.WriteLine("Enter the number:");
            N=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("= :"+N);
            Console.WriteLine("+= :"+ (N+=N));
            Console.WriteLine("-= :"+ (N-=5));
            Console.WriteLine("*= :"+ (N*=2));
            Console.WriteLine("/= :"+ (N/=3));
            Console.WriteLine("%= :"+ (N%=4));
            Console.WriteLine("&= :"+ (N&=6));
        }
    }

}