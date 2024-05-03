using System;
class Methods11
{
    static int[] ArrayReverse(int[] arr) // Method to reverse an array
    {
        int[] reversedArray = new int[arr.Length]; // Create a new array to store the reversed elements
        for (int i = 0; i < arr.Length; i++) // Loop through the original array
        {
            reversedArray[i] = arr[arr.Length - 1 - i]; // Reverse the elements
        }
        return reversedArray; // Return the reversed array
    }
    static void Main() // Main method
    {
        int[] numbers = { 10, 20, 30, 40, 50 }; // Initialize an array of numbers
        int[] result = ArrayReverse(numbers); // Call the ArrayReverse method
        Console.WriteLine("The reversed array is: "); // Print the message
        foreach (int num in result) // Loop through the reversed array
        {
            Console.Write(num + " "); // Print each element
        }
    }
}   
/*
 ************** Eng / Ahmed Elkhatib **************
 */