using System;
namespace Transpose
{
    public static class Matrix
    {
        
        static void transpose(int[,] a,int[,] b,int row,int column)
        {
            for(int i=0;i<row;i++)
            {
                for(int j=0;j<column;j++)
                {
                    b[i,j]=a[j,i];
                }
            }
        }
        public static void Main(string[] args){
            Console.WriteLine("How many rows of matrix:");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many columns of matrix:");
            int column = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[row,column];
            Console.WriteLine("Enter elements for matrix :");

            for (int i = 0; i < row; i++)
            {
                for(int j=0; j < column;j++){
                a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The matrix is:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            int[, ] b = new int[row, column];
            transpose(a,b,row,column);
            Console.WriteLine("Transpose matrix is: \n"); 
            for (int i = 0; i < row; i++) { 
                for (int j = 0; j < column; j++) 
                    Console.Write(b[i, j] + " "); 
                    Console.Write("\n");
                }
        }

    }
}