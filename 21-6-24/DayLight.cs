using System;

class Program
{
    static void Main()
    {
        // Specify the time zone you are interested in
        string timeZoneId = "India Standard Time"; // Correct time zone ID for IST
        TimeZoneInfo timeZone = TimeZoneInfo.FindSystemTimeZoneById(timeZoneId);

        // Get the current time
        DateTime now = DateTime.Now;

        // Determine if the current time is in Daylight Saving Time
        bool isDaylightSaving = timeZone.IsDaylightSavingTime(now);

        // Display the information
        Console.WriteLine("Time Zone: {0}", timeZone.DisplayName);
        Console.WriteLine("Current Date and Time: {0}", now);
        Console.WriteLine("Is Daylight Saving Time: {0}", isDaylightSaving);
    }
}
