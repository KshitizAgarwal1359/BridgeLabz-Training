//yards to feet
//feet to yards
//meter to inches
//inches to meter
//inches to centimeter
using System;
class UnitConverter2
{
    public static void Main(String[] args)
    {
        Console.WriteLine("2 yards in feet: "+YardsToFeet(2));
        Console.WriteLine("6 feet in yards: "+FeetToYards(6));
        Console.WriteLine("1 meter in inches: "+MeterToInches(1));
        Console.WriteLine("10 inches in meter: "+InchesToMeter(10));
        Console.WriteLine("10 inches in centimeters: "+InchesToCentiMeter(10));
    }
    public static double YardsToFeet(double yards)
    {
        double yards2feet=3;
        return yards*yards2feet;
    }
    public static double FeetToYards(double feet)
    {
        double feet2yards = 0.333333;
        return feet*feet2yards;
    }
    public static double MeterToInches(double meters)
    {
        double meter2inches=39.3701;
        return meters*meter2inches;
    }
    public static double InchesToCentiMeter(double inches)
    {
        double inches2cm=2.54;
        return inches*inches2cm;
    }
    public static double InchesToMeter(double inches)
    {
        double inches2meter=0.0254;
        return inches*inches2meter;
    }
}