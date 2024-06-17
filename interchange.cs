using System;
namespace Interchange
{


    class MatrixColumnInterchange
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many rows of matrix:");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many columns of matrix:");
            int column = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[row,column];
            Console.WriteLine("Enter elements for matrix :");

            for (int i = 0; i < row; i++)
            {
                for(int j=0; j < column;j++){
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Original matrix:");
            PrintMatrix(matrix);

            // Interchange columns here; for example, interchange column 0 and column 2
            InterchangeColumns(matrix, 0, 2);

            Console.WriteLine("Matrix after interchanging columns:");
            PrintMatrix(matrix);
        }

        static void InterchangeColumns(int[,] matrix, int column1, int column2)
        {
            int rows = matrix.GetLength(0);

            for (int i = 0; i < rows; i++)
            {
                int temp = matrix[i, column1];
                matrix[i, column1] = matrix[i, column2];
                matrix[i, column2] = temp;
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

}