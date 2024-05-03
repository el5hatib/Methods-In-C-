using System;
class Methods9
{
    static int SumFrom1toN(int n) // Method to calculate the sum of numbers from 1 to n
    {
        int sum = 0; // Initialize the sum variable to 0
        for (int i = 1; i <= n; i++) // Loop from 1 to n
        {
            sum += i; // Add the current number to the sum
        }
        return sum; // Return the sum
    }
    static void Main() // Main method
    {
        Console.WriteLine("Enter a number: "); // Ask the user to enter a number
        int number = Convert.ToInt32(Console.ReadLine()); // Read the number
        int result = SumFrom1toN(number); // Call the SumFrom1toN method
        Console.WriteLine("The sum of numbers from 1 to " + number + " is: " + result); // Print the result
    }
}
/*
 
 *************** Eng / Ahmed Elkhatib ***************
 */