using System;
class Methods3
{
    static int SpacesCount(string text) // Method to count the number of spaces in a string
    {
        int count = 0; // Initialize the count variable to 0
        for (int i = 0; i < text.Length; i++) // Loop through each character of the string
        {
            if (text[i] == ' ') // Check if the character is a space
            {
                count++; // Increment the count variable
            }
        }
        return count; // Return the count of spaces
    }
    static void Main() // Main method
    {
        Console.WriteLine("Enter a string: "); // Ask the user to enter a string
        string input = Console.ReadLine(); // Read the input string
        int spaces = SpacesCount(input); // Call the SpacesCount method
        Console.WriteLine("The number of spaces in the string is: " + spaces); // Print the result
    }
}
/*
 * *************** Method Parameters ***************
 * (1) Method parameters are used to pass values to a method.
 * (2) Parameters are defined in the method declaration.
 * (3) Parameters are enclosed in parentheses after the method name.
 * (4) Parameters are separated by commas.
 * (5) Parameters can have different data types.
 * (6) Parameters are used to provide input to the method.
 * (7) parameters are optional.
 * (8) Parameters are passed by value by default.
 * (9) Parameters can be passed by reference using the ref or out keywords.
 * (10) Parameters can be named or unnamed.
 *********************** Eng / Ahmed Elkhatib ***********************
 */
