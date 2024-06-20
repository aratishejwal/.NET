using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        // Example 1: Validate an Email Address
        Console.WriteLine("Example 1: Validate an Email Address");
        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        string[] emails = { "test@example.com", "invalid-email@", "another.test@domain.org" };
        
        foreach (var email in emails)
        {
            bool isValid = Regex.IsMatch(email, emailPattern);
            Console.WriteLine(string.Format("{0} is {1}", email, isValid ? "valid" : "invalid"));
        }

        // Example 2: Validate a Phone Number (US Format)
        Console.WriteLine("\nExample 2: Validate a Phone Number (US Format)");
        string phonePattern = @"^\(\d{3}\) \d{3}-\d{4}$";
        string[] phoneNumbers = { "(123) 456-7890", "123-456-7890", "(987) 654-3210" };
        
        foreach (var phone in phoneNumbers)
        {
            bool isValid = Regex.IsMatch(phone, phonePattern);
            Console.WriteLine(string.Format("{0} is {1}", phone, isValid ? "valid" : "invalid"));
        }

        // Example 3: Extract Dates from Text
        Console.WriteLine("\nExample 3: Extract Dates from Text");
        string text = "Today's date is 06/20/2024. Tomorrow's date will be 06/21/2024. Another date: 01/01/2025.";
        string datePattern = @"\b\d{2}/\d{2}/\d{4}\b";
        
        MatchCollection matches = Regex.Matches(text, datePattern);
        
        foreach (Match match in matches)
        {
            Console.WriteLine("Found date: " + match.Value);
        }
    }
}
