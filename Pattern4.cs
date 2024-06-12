using System;
namespace Pattern{
    class Patt{
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter how many rows do you want:");
            int rows =Convert.ToInt32(Console.ReadLine()); 
  
            for (int i = 1; i <= rows; i++) {
                Console.WriteLine(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write("* ");
                    
            }
            for (int i = rows; i >= 1; i--) {
                Console.WriteLine(" ");
                for (int j = 1; j <= i; j++)
                    Console.Write("* ");
                    
            }
            
            
               
                  
                
    
            
        }
    }
}