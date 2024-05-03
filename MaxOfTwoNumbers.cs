using System;
class Methods8
{
    static int MaxOfTwoNumbers(int num1, int num2) // Method to find the maximum of two numbers
    {
        if (num1 > num2) // Check if num1 is greater than num2
        {
            return num1; // Return num1 if it is greater
        }
        else
        {
            return num2; // Return num2 if it is greater or equal
        }
    }
    static void Main() // Main method
    {
        Console.WriteLine("Enter number 1: "); // Ask the user to enter the first number
        int number1 = Convert.ToInt32(Console.ReadLine()); // Read the first number
        Console.WriteLine("Enter number 2: "); // Ask the user to enter the second number
        int number2 = Convert.ToInt32(Console.ReadLine()); // Read the second number
        int result = MaxOfTwoNumbers(number1, number2); // Call the MaxOfTwoNumbers method
        Console.WriteLine("The maximum of two numbers is: " + result); // Print the result
    }
}                             
/*
 ************** Eng / Ahmed Elkhatib **************
 
 */