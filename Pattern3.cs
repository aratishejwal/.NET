using System;
namespace Pattern{
    class Patt{
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter how many rows do you want:");
            int rows =Convert.ToInt32(Console.ReadLine()); 
  
            for (int i = 0; i <= rows*2 - 1; i++) { 
  
                int temp; 
                if (i < rows) { 
                    temp = i; 
                } 
                else { 
                    temp = rows*2-i; 
                } 
  
                // first inner loop to print leading whitespaces 
                for (int j = 0; j < rows-temp; j++) { 
                    Console.Write(" "); 
                } 
  
                // second inner loop to print stars * 
                for (int k = 0; k < temp; k++) { 
                    Console.Write("* "); 
                } 
                
                 Console.WriteLine(); 
                
    
            } 
        }
    }
}