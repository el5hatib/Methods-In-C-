using System;
class Methods7
{
    static int SumOfDigits(int number) // Method to calculate the sum of digits of a number
    {
        int sum = 0; // Initialize the sum variable to 0
        while (number > 0) // Loop until the number becomes 0
        {
            sum += number % 10; // Add the last digit of the number to the sum
            number /= 10; // Remove the last digit from the number
        }
        return sum; // Return the sum of digits
    }
    static void Main() // Main method
    {
        Console.WriteLine("Enter a number: "); // Ask the user to enter a number
        int num = Convert.ToInt32(Console.ReadLine()); // Read the number
        int result = SumOfDigits(num); // Call the SumOfDigits method
        Console.WriteLine("The sum of digits of the number is: " + result); // Print the result
    }
}                   
/*
 
 * the SumOfDigits method calculates the sum of digits of a number by extracting the last digit of the number using the modulo operator (%) and adding it to the sum.
 * the functionally of the code is to calculate the sum of digits of a number by extracting the last digit of the number using the modulo operator (%) and adding it to the sum.
 * example:
 * 1. If the number is 123, the sum of digits would be 1 + 2 + 3 = 6.
 * 2.we take the last digit of the number by using the modulo operator (%) with 10.
 * 3.123%10 = 3, which is the last digit of the number.
 * 4.We add this digit to the sum 
 * 5.remove the last digit from the number by dividing it by 10.
 * 6. 123/10 = 12, which is the number without the last digit.
 * ************* Eng / Ahmed Elkhatib *************
 
 */