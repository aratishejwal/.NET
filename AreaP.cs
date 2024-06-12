using System;
namespace Area{
    class Polygon{
        public static void Main(String[] args){
            Console.WriteLine("Enter the number of sides:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the length of One side:");
            double l = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the apothem:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The Area of Polygon is:"+(0.5*n*l*a));
        }
    }
}