// fahrenheit to celsius
// celsius to fah
//pounds to kg
//kg to pounds
//gallons to liters
//liters to gallon
using System;
class UnitConverter3
{
    public static double FahToCelsius(double fah)
    {
        double fah2celsius=(fah-32)*5/9;
        return fah2celsius;
    }
    public static double CelsiusToFah(double cel)
    {
        double cel2Fah = (cel*9/5)+32;
        return cel2Fah;
    }
    public static double PoundToKg(double pound)
    {
        double pound2kg=0.453592;
        return pound*pound2kg;
    }
    public static double KgToPound(double kg)
    {
        double kg2pounds = 2.20462;
        return kg*kg2pounds;
    }
    public static double GallonToLitre(double gallon)
    {
        double gallon2Liter=3.78541;
        return gallon*gallon2Liter;
    }
    public static double LitreToGallon(double litre)
    {
        double litre2gallon=0.264172;
        return litre*litre2gallon;
    }
    public static void Main(String[] args)
    {
        Console.WriteLine("98.6 f in celsius: "+FahToCelsius(98.6));
        Console.WriteLine("37 c to fahrenheit: "+CelsiusToFah(37));
        Console.WriteLine("150 pounds to kg: "+PoundToKg(150));
        Console.WriteLine("68 kg in pounds: "+KgToPound(68));
        Console.WriteLine("5 gallons in litres: "+GallonToLitre(5));
        Console.WriteLine("10 litres in gallons: "+LitreToGallon(18.92751));
    }
}