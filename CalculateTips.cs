using System;
class Method16
{

  
    static void Main()
    {
        double subtotal, gratuityRate, gratuity, total; 
        Console.WriteLine("Enter the subtotal and a gratuity rate: "); 
        subtotal = Convert.ToDouble(Console.ReadLine());    
        gratuityRate = Convert.ToDouble(Console.ReadLine());
        gratuity = subtotal * gratuityRate / 100;   
        total = subtotal + gratuity;
        Console.WriteLine("The gratuity is $" + gratuity + " and total is $" + total);  

    }
}*/
