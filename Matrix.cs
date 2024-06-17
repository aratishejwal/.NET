using System;
namespace Matrix
{
    class Display
    {
        static void Main(string[] args){
            Console.WriteLine("How many rows of matrix:");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many columns of matrix:");
            int column = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[row,column];
            int[,] m = new int[row,column];
            Console.WriteLine("Enter elements for first matrix :");

            for (int i = 0; i < row; i++)
            {
                for(int j=0; j < column;j++){
                a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Enter elements for Second  matrix :");

            for (int i = 0; i < row; i++)
            {
                for(int j=0; j < column;j++){
                m[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("The first matrix is:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("The Second matrix is:");
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(m[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Addition of Two matrix Are:");
            for(int i=0;i<row;i++){
                for(int j=0;j<column;j++){
                    Console.Write(a[i,j]+m[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Substraction of Two matrix Are:");
            for(int i=0;i<row;i++){
                for(int j=0;j<column;j++){
                    Console.Write(a[i,j]-m[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("multiplication of Two matrix Are:");
            for(int i=0;i<row;i++){
                for(int j=0;j<column;j++){
                    Console.Write(a[i,j]*m[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("division of Two matrix Are:");
            for(int i=0;i<row;i++){
                for(int j=0;j<column;j++){
                    Console.Write(a[i,j]/m[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Modulo of Two matrix Are:");
            for(int i=0;i<row;i++){
                for(int j=0;j<column;j++){
                    Console.Write(a[i,j]%m[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}