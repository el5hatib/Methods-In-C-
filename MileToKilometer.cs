using System;
class Method15
{
    static double MileToKilometer(double mile) // Method to convert miles to kilometers
    {
        return mile * 1.6; // Return the value of miles multiplied by 1.60934
    }
    static void Main()
    {
        double mile;
        Console.WriteLine("Enter a number of Mile");
        mile = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("The number in kilometer is {0}",MileToKilometer(mile)); // Call the MileToKilometer method and print the result
    
    }
}
