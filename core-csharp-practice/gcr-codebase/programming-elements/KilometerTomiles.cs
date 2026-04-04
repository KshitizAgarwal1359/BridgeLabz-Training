using System;

class KilometerToMiles
{
    static void Main()
    {
        double kilometers = 100;
        double miles = kilometers * 0.621371;
        
        Console.WriteLine($"{kilometers} kilometers = {miles} miles");
    }
}