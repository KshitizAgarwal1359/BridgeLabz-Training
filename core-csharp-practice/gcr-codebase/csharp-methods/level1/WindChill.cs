//calculation of wind chill temperature
using System;
class WindChill
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the temp: ");
        double temp = Convert.ToDouble(Console.ReadLine());
        Console.Write("ENter the wind speed: ");
        double speed = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"the wind chill temperature is {new WindChill().CalculateWindChill(temp,speed):F2}");
    }
    public double CalculateWindChill(double temperature, double windSpeed)
    {
        double windChill = 35.74 + (0.6215 * temperature) + ((0.4275 * temperature) - 35.75) * Math.Pow(windSpeed, 0.16);
        return windChill;
    }
}
