using System;
class Method17
{     static void Main()
    {
        Console.WriteLine("Enter the number of minutes: "); // Ask the user to enter the number of minutes
        int minutes = Convert.ToInt32(Console.ReadLine()); // Read the number of minutes
        int years = minutes / 525600; // Calculate the number of years
        int days = (minutes % 525600) / 1440; // Calculate the number of days
        Console.WriteLine(minutes + " minutes is approximately " + years + " years and " + days + " days."); // Print the result
    }
}
