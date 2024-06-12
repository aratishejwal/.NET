using System;
class Pattern {
   static void Main() {
      int i, j, k;
      int n = 6;
      // loop to print the series
      for (i = 1; i <= n; i++) {
         for (j = 1; j <= n - i; j++) {
               Console.Write(" ");
         }
         for (k = 1; k <= i; k++) {
            Console.Write("*");
         }
         Console.WriteLine();
      }
      
   }
}