using System;

class Program
{
    static void Main()
    {
        // Prompt the user to enter a string
        Console.WriteLine("Enter a string:");

        // Read input from the user
        string input = Console.ReadLine();

        // Convert characters to opposite case
        string converted = ConvertToOppositeCase(input);

        // Output the converted string
        Console.WriteLine("Original: " + input);
        Console.WriteLine("Converted: " + converted);
    }

    static string ConvertToOppositeCase(string input)
    {
        char[] characters = input.ToCharArray();

        for (int i = 0; i < characters.Length; i++)
        {
            if (char.IsLower(characters[i]))
            {
                characters[i] = char.ToUpper(characters[i]);
            }
            else if (char.IsUpper(characters[i]))
            {
                characters[i] = char.ToLower(characters[i]);
            }
            // If the character is neither uppercase nor lowercase, it remains unchanged
        }

        return new string(characters);
    }
}
