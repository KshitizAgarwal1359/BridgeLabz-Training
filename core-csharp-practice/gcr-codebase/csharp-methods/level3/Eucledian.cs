//making a program to find the distance b/w two points
//also make the equation for the lines b/w the two points
using System;

public class Euclidean{
    public static double FindDistance(double x1, double y1, double x2, double y2){
        double distance = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
        return distance;
    }
    public static double[] FindLineEquation(double x1, double y1, double x2, double y2){
        double m = (y2 - y1) / (x2 - x1); // slope
        double b = y1 - m * x1; // y-intercept
        return new double[] { m, b };
}
public static void Main(string[] args){
    Console.WriteLine("Enter x1:");
    double x1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter y1:");
    double y1 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter x2:");
    double x2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter y2:");
    double y2 = Convert.ToDouble(Console.ReadLine());
    double distance = FindDistance(x1, y1, x2, y2);
    double[] lineEquation = FindLineEquation(x1, y1, x2, y2);
    Console.WriteLine($"Euclidean Distance: {distance}");
    Console.WriteLine($"Equation of the line: y = {lineEquation[0]}*x + {lineEquation[1]}");
    }
}