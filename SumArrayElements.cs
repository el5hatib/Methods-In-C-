using System;
class Methods4
{
    static int SumArrayElements(int[] array) // Method to sum the elements of an array
    {
        int sum = 0; // Initialize the sum variable to 0
        for (int i = 0; i < array.Length; i++) // Loop through each element of the array
        {
            sum += array[i]; // Add the element to the sum
        }
        return sum; // Return the sum of array elements
    }
    static void Main() // Main method
    {
        Console.WriteLine("Enter the number of elements in the array: "); // Ask the user to enter the number of elements
        int n = Convert.ToInt32(Console.ReadLine()); // Read the number of elements
        int[] numbers = new int[n]; // Create an array of size n
        for (int i = 0; i < n; i++) // Loop through each element of the array
        {
            Console.WriteLine("Enter element " + (i + 1) + ": "); // Ask the user to enter the element
            numbers[i] = Convert.ToInt32(Console.ReadLine()); // Read the element
        }
        int sum = SumArrayElements(numbers); // Call the SumArrayElements method
        Console.WriteLine("The sum of array elements is: " + sum); // Print the result
    }
}
/*
 * we use the for loop to iterate through each element of the array and add it to the sum variable. 
 * *********** Array ***********
 * 1. An array is a collection of elements of the same data type.
 * 2. Arrays are used to store multiple values in a single variable.    
 * 3. Each element in an array is accessed by an index.
 * 4. The index of the first element in an array is 0.
 * ***************** Eng / Ahmed Elkhatib *****************
 
 */
