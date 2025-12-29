using System;
class TemperatureConverter{
    public static double CelsiusToFahrenheit(double c){ //Celsius to Fahrenheit
        return (c * 9.0 / 5.0) + 32;
    }
    public static double FahrenheitToCelsius(double f){ //Fahrenheit to Celsius
        return (f - 32) * 5.0 / 9.0;
    }
    public static void Main(string[] args){
        Console.Write("Enter temperature in Celsius: ");
        double cel = Convert.ToDouble(Console.ReadLine());
        double fahrenAns = CelsiusToFahrenheit(cel);
        Console.WriteLine($"{cel} = {fahrenAns:F2}");
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahren = Convert.ToDouble(Console.ReadLine());
        double celAns = FahrenheitToCelsius(fahren);
        Console.WriteLine($"{fahren}= {celAns:F2}");
    }
}