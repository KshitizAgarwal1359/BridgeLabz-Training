using System;
class PoundToKilogram
{
    public static void Main()
    {
        Console.Write("Enter weight in Pounds: ");
        double pounds = Convert.ToDouble(Console.ReadLine());
        double kilograms = pounds * 0.45359237;
        Console.WriteLine($"The weight of person in pounds is {pounds} and  in kg is {kilograms}");
    }
}