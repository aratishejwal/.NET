using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = 3; // Number of bits
        List<string> grayCodes = GenerateGrayCode(n);

        Console.WriteLine("Gray Codes for {0} bits:", n);
        foreach (string code in grayCodes)
        {
            Console.WriteLine(code);
        }
    }

    static List<string> GenerateGrayCode(int n)
    {
        if (n <= 0)
        {
            return new List<string> { "0" };
        }

        if (n == 1)
        {
            return new List<string> { "0", "1" };
        }

        List<string> previousGrayCodes = GenerateGrayCode(n - 1);
        List<string> newGrayCodes = new List<string>();

        // Add 0 to the front of the previous Gray codes
        foreach (string code in previousGrayCodes)
        {
            newGrayCodes.Add("0" + code);
        }

        // Add 1 to the front of the previous Gray codes in reverse order
        for (int i = previousGrayCodes.Count - 1; i >= 0; i--)
        {
            newGrayCodes.Add("1" + previousGrayCodes[i]);
        }

        return newGrayCodes;
    }
}
