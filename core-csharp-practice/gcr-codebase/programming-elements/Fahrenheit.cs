public class TemperatureConverter
{
    public static void Main()
    {
        double celsius = 25;
        double fahrenheit = (celsius * 9 / 5) + 32;
        
        System.Console.WriteLine($"{celsius}°C = {fahrenheit}°F");
    }
}