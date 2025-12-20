using System;
class TemperatureConversion
{
    public static void Main()
    {
        Console.Write("Enter temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($" the {celsius}  Celsius is {fahrenheit} Fahrenheit ");
    }
}