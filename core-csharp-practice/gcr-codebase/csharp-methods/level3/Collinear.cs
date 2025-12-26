// program to check whether three given points are collinear using
// slope comparison and area of triangle method.
using System;
public class CollinearPoints{
    public static bool AreCollinearUsingSlope(double x1, double y1, double x2, double y2, double x3, double y3){
        double slopeAB = (y2 - y1) / (x2 - x1);
        double slopeBC = (y3 - y2) / (x3 - x2);
        double slopeAC = (y3 - y1) / (x3 - x1);
        return (slopeAB == slopeBC) && (slopeBC == slopeAC);
    }
    public static bool AreCollinearUsingArea(double x1, double y1, double x2, double y2, double x3, double y3){
        double area = 0.5*Math.Abs(x1*(y2 - y3) + x2*(y3 - y1) + x3*(y1 - y2));
        return area == 0;
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
            Console.WriteLine("Enter x3:");
            double x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter y3:");
            double y3 = Convert.ToDouble(Console.ReadLine());
            bool collinearSlope = AreCollinearUsingSlope(x1, y1, x2, y2, x3, y3);
            bool collinearArea = AreCollinearUsingArea(x1, y1, x2, y2, x3, y3);
            Console.WriteLine($"Are the points collinear using slope method? {collinearSlope}");
            Console.WriteLine($"Are the points collinear using area method? {collinearArea}");
    }
}