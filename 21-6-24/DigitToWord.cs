using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string number = Console.ReadLine();
        Console.WriteLine("Number in words: " + ConvertDigitsToWords(number));
    }

    static string ConvertDigitsToWords(string number)
    {
        string[] digits = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
        string result = "";

        foreach (char digit in number)
        {
            if (char.IsDigit(digit))
            {
                result += digits[digit - '0'] + " ";
            }
            else
            {
                result += "Invalid character ";
            }
        }

        return result.Trim();
    }
}
