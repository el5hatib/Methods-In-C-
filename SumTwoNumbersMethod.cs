using System; 
class Methods2
{
    static int SumTwoNumbers(int num1, int num2) // Method to sum two numbers
    {
        return num1 + num2; // Return the sum of two numbers
    }
    static void Main() // Main method
    {
        Console.WriteLine("Enter number 1: "); // Ask the user to enter the first number
        int number1 = Convert.ToInt32(Console.ReadLine()); // Read the first number
        Console.WriteLine("Enter number 2: "); // Ask the user to enter the second number
        int number2 = Convert.ToInt32(Console.ReadLine()); // Read the second number
        int result = SumTwoNumbers(number1, number2); // Call the SumTwoNumbers method
        Console.WriteLine("The sum of two numbers is: " + result); // Print the result
    }
}   
/*
 *************** return type ***************
 *(1) void: It does not return any value.
 *(2) int: It returns an integer value.
 *(3) float: It returns a floating-point value.
 *(4) double: It returns a double-precision floating-point value.
 *(5) string: It returns a string value.
 *(6) bool: It returns a Boolean value.
 ******************* Eng / Ahmed Elkhatib *******************
 */