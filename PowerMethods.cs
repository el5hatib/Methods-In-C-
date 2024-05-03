using System;
class Methods6
{
    static double Power(double x, int y) // Method to calculate the power of a number
    {
        double result = 1; // Initialize the result variable to 1
        for (int i = 0; i < y; i++) // Loop y times
        {
            result *= x; // Multiply x by itself y times
        }
        return result; // Return the result
    }
    static void Main() // Main method
    {
        Console.WriteLine("Enter the base number: "); // Ask the user to enter the base number
        double baseNumber = Convert.ToDouble(Console.ReadLine()); // Read the base number
        Console.WriteLine("Enter the exponent: "); // Ask the user to enter the exponent
        int exponent = Convert.ToInt32(Console.ReadLine()); // Read the exponent
        double result = Power(baseNumber, exponent); // Call the Power method
        Console.WriteLine("The result is: " + result); // Print the result
    }
}   
/*
 * Power method calculates the power of a number by multiplying the base number by itself exponent times.
 * 1. The method takes two parameters: the base number x and the exponent y.
 * 2. It initializes the result variable to 1.
 * 3. It then multiplies the base number by itself exponent times using a for loop.
 * 4. Finally, it returns the result.
 * ************ Eng / Ahmed Elkhatib ************
 */