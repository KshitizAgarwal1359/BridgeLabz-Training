using System;

class PowerCalculation
{
    static void Main()
    {
        double baseNumber = 2.0;
        double exponent = 3.0;
        double result = Math.Pow(baseNumber, exponent);
        
        Console.WriteLine($"{baseNumber} raised to the power of {exponent} is {result}");
    }
}