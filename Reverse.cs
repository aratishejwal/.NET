using System;
namespace Reverse
{
    class Display
    {
        static void Main(string[] args){
            Console.WriteLine("How many elements do you want to store in the array?");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[arraySize];

            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("Enter element "+(i+1)+":");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("ARRAY ELEMENTS ARE :: ");
            for(int i = 0; i < arraySize ; i++){
            Console.Write(a[i]+ " ");
            }
            Console.WriteLine();

            Console.WriteLine("REVERSED ARRAY ELEMENTS ARE :: ");
            int [] newArray = new int[arraySize];
            for(int i = arraySize-1; i >=0 ; i--){
                Console.Write(a[i] + " ");
            }
    }
}
}