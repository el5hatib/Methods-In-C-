// The permutations formula is nPr = n! / (n - r)!. 
// using recursion to calculate the permutations of n objects taken r at a time.  
using System;
class Methods13
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
    static int Permutations(int n, int r) // Method to calculate the permutations of n objects taken r at a time
    {
        return FactorialByRecursion(n) / FactorialByRecursion(n - r); // Return n! / (n - r)!
    }
    static void Main() // Main method
    {
        Console.WriteLine("Enter the value of n: "); // Ask the user to enter the value of n
        int n = Convert.ToInt32(Console.ReadLine()); // Read the value of n
        Console.WriteLine("Enter the value of r: "); // Ask the user to enter the value of r
        int r = Convert.ToInt32(Console.ReadLine()); // Read the value of r
        int result = Permutations(n, r); // Call the Permutations method
        Console.WriteLine("The permutations of " + n + " objects taken " + r + " at a time is: " + result); // Print the result
    }
}
  /*
   ************* Eng / Ahmed Elkhatib *************
   
   */