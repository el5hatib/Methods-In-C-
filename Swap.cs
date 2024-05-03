using System;
class Methods5
{
    static void Swap(ref int a, ref int b) // Method to swap two numbers
    {
        int temp = a; // Store the value of a in a temporary variable
        a = b; // Assign the value of b to a
        b = temp; // Assign the value of a to b
    }
    static void Main() // Main method
    {
        int num1 = 10; // Initialize the first number
        int num2 = 20; // Initialize the second number
        Console.WriteLine("Before swapping: num1 = " + num1 + ", num2 = " + num2); // Print the numbers before swapping
        Swap(ref num1, ref num2); // Call the Swap method
        Console.WriteLine("After swapping: num1 = " + num1 + ", num2 = " + num2); // Print the numbers after swapping
    }
}/*
  * In this example, we have a method named Swap that takes two integer parameters by reference. 
  * * The method swaps the values of the two parameters using a temporary variable. 
  * * We call the Swap method by passing the two numbers as arguments. 
  * * After calling the method, the values of the two numbers are swapped.
  * * *********** Pass by Reference ***********
  * * 1. When we pass a parameter
  * * 2. by reference, the method can modify the value of the parameter.
  * * 3. The ref keyword is used to pass a parameter by reference.
  * * 4. The changes made to the parameter inside the method are reflected outside the method.
  * * 5. The ref keyword must be used in both the method declaration and the method call.
  * * 6. The ref keyword is used to pass a reference to the memory location of the variable.
  * * 7. The ref keyword is used to pass the actual variable, not a copy of the variable.
  * ********************** * Eng / Ahmed Elkhatib ***********************
  *  */