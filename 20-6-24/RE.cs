using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // Example 1: Validate an Email Address
        Console.WriteLine("Example 1: Validate an Email Address");
        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        string[] emails = { "arati123@gmail.com", "invalid-email@", "another.test@domain.org" };
        
        foreach (var email in emails)
        {
            bool isValid = Regex.IsMatch(email, emailPattern);
            Console.WriteLine(string.Format("{0} is {1}", email, isValid ? "valid" : "invalid"));
        }

   }
}
