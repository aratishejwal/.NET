using System;
namespace Pattern{
    class Patt{
        public static void Main(string[] args)
        {
                Console.WriteLine("Enter how many rows do you want:");
                int rows =Convert.ToInt32(Console.ReadLine()); 
  
                // first loop to print all rows 
                for (int i = rows; i >=1; i--) { 
  
                // inner loop 1 to print white spaces 
                for (int j = 0; j < rows- i; j++) { 
                Console.Write(" "); 
                } 
  
                // inner loop 2 to print star * character 
                for (int k = 0; k < i ; k++) { 
                Console.Write("* "); 
                } 
                Console.WriteLine(); 
                /*
                         * * * * *
                          * * * *
                           * * *
                            * *
                             *
                            
                */
            } 
        }
    }
}