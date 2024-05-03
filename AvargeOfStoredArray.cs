using System;
class Method10
{
    static double AverageOfStoredArray(int[] arr) // Method to calculate the average of an array
    {
        double sum = 0; // Initialize the sum variable to 0
        for (int i = 0; i < arr.Length; i++) // Loop through the array
        {
            sum += arr[i]; // Add the current element to the sum
        }
        return sum / arr.Length; // Return the average
    }
    static void Main() // Main method
    {
        int[] numbers = { 10, 20, 30, 40, 50 }; // Initialize an array of numbers
        double result = AverageOfStoredArray(numbers); // Call the AverageOfStoredArray method
        Console.WriteLine("The average of the stored array is: " + result); // Print the result
    }
}
/*
 
 ************************ Eng / Ahmed Elkhatib ************************ 
 
 */