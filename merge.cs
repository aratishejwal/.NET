using System;

public class MergeSort
{
    public static void Sort(int[] array, int left, int right)
    {
        if (left >= right) return;
        int mid = (left + right) / 2;
        Sort(array, left, mid);
        Sort(array, mid + 1, right);
        Merge(array, left, mid, right);
    }

    private static void Merge(int[] array, int left, int mid, int right)
    {
        int[] temp = new int[right - left + 1];
        int i = left, j = mid + 1, k = 0;

        while (i <= mid && j <= right)
            temp[k++] = array[i] <= array[j] ? array[i++] : array[j++];
        while (i <= mid)
            temp[k++] = array[i++];
        while (j <= right)
            temp[k++] = array[j++];

        Array.Copy(temp, 0, array, left, temp.Length);
    }

    public static void Main(string[] args)
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
        Sort(array, 0, array.Length - 1);
        Console.WriteLine("Sorted array:");
        Console.WriteLine(string.Join(" ", array));
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
