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
            InterchangeRows(matrix, 0, 2);

            Console.WriteLine("Matrix after interchanging columns:");
            PrintMatrix(matrix);
        }

        static void InterchangeRows(int[,] matrix, int row1, int row2)
        {
            int columns = matrix.GetLength(1);

            for (int j = 0; j < columns; j++)
            {
                int temp = matrix[row1, j];
                matrix[row1, j] = matrix[row2, j];
                matrix[row2, j] = temp;
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