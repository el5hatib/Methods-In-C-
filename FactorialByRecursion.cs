/*using System;
class Methods12
{
    static int FactorialByRecursion(int n) // Method to calculate the factorial of a number using recursion
    {
        if (n == 0) // Check if n is 0
        {
            return 1; // Return 1 if n is 0
        }
        else
        {
            return n * FactorialByRecursion(n - 1); // Return n multiplied by the factorial of n-1
        }
    }
    static void Main() // Main method
    {
        Console.WriteLine("Enter a number: "); // Ask the user to enter a number
        int number = Convert.ToInt32(Console.ReadLine()); // Read the number
        int result = FactorialByRecursion(number); // Call the FactorialByRecursion method
        Console.WriteLine("The factorial of " + number + " is: " + result); // Print the result
    }
}
/*
 ************* Recursion *************  
 * recursion is a technique in which a method calls itself to solve a problem.
 * 1. The FactorialByRecursion method calculates the factorial of a number using recursion.
 * 2. It checks if the number is 0 and returns 1 if it is.
 * 3. Otherwise, it returns the number multiplied by the factorial of the number minus 1.
 * *************** Eng / Ahmed Elkhatib ***************
 
 */
