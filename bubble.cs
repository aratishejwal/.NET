using System;

class BubbleSortExample
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of array:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];
        Console.WriteLine("Enter elements for array:");

        for (int i = 0; i < n; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Original array:");
        PrintArray(array);

        BubbleSort(array);

        Console.WriteLine("Sorted array:");
        PrintArray(array);
    }

    static void BubbleSort(int[] array)
    {
        bool swapped;
        do
        {
            swapped = false;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    // Swap the elements
                    int temp = array[i];
                    array[i] = array[i + 1];
                    array[i + 1] = temp;
                    swapped = true;
                }
            }
        } while (swapped);
    }

    static void PrintArray(int[] array)
    {
        foreach (int value in array)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }
}
