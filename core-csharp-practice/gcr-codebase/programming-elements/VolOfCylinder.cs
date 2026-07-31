using System;

class VolOfCylinder
{
    static void Main()
    {
        double radius = 5.0;
        double height = 10.0;
        
        double volume = Math.PI * radius * radius * height;
        
        Console.WriteLine($"Radius: {radius}");
        Console.WriteLine($"Height: {height}");
        Console.WriteLine($"Volume of Cylinder: {volume:F2}");
    }
}