// calculating different trigonometry functions
using System;
class Trigonometry
{
    public static void Main(String[] args)
    {
        Console.Write("ENter the angle in degree: ");
        double angle = Convert.ToDouble(Console.ReadLine());
        Trigonometry obj = new Trigonometry();
        double[] result = obj.calculateTrigonometry(angle);
        Console.WriteLine($"The sine for angle {angle} is {result[0]}, cosine is {result[1]} and tangent is {result[2]}");
    }
    public double[] calculateTrigonometry(double angle)
    {
        double radians = angle*Math.PI/100;
        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);
        return new double[] {sine,cosine,tangent};
    }
}