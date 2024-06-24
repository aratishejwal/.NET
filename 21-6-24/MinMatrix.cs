using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] matrix = new int[rows, cols];

        Console.WriteLine("Enter the elements of the matrix:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write("Element [{0},{1}]: ",i,j);
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        int min = matrix[0, 0];
        foreach (int value in matrix)
        {
            if (value < min)
            {
                min = value;
            }
        }

        Console.WriteLine("Smallest element: " + min);
    }
}
