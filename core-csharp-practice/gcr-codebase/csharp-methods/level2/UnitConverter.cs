//miles to km
//km to miles
// m to feet
// feet to m
using System;
class UnitConverter
{
    public static double KmToMiles(double km)
    {
        double km2Miles = 0.621371;
        return km2Miles*km;
    }
    public static double MilesToKm(double miles)
    {
        double miles2Km = 1.60934;
        return miles*miles2Km;
    }
    public static double FeetToMeters(double feet)
    {
        double feet2meters= 0.3048;
        return feet*feet2meters;
    }
    public static double MeterToFeet(double meter)
    {
        double meter2feet=3.28084;
        return meter*meter2feet;
    }
    public static void Main(String[] args)
    {
        Console.Write("Enter Miles: ");
        double miles = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"the {miles} miles in km is {MilesToKm(miles)} km.");
        Console.Write("Enter km: ");
        double km = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"the {km} km in miles is {KmToMiles(km)} miles.");
        Console.Write("Enter feet: ");
        double feet = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"the {feet} feet in m is {FeetToMeters(feet)} m.");
        Console.Write("Enter Meter: ");
        double meter = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"the {meter} m in feet is {MeterToFeet(meter)} feet.");
    }
}
