using System;
class Methods19
{
    static void Main ()
    {
        double initialVelocity, acceleration, time, distance;
        Console.WriteLine("Enter the initial velocity in m/s: ");
        initialVelocity = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the acceleration in m/s^2: ");
        acceleration = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the time in s: ");
        time = Convert.ToDouble(Console.ReadLine());
        distance = initialVelocity * time + 0.5 * acceleration * time * time;
        Console.WriteLine("The distance is: " + distance);

    }



}
