using System;
using System.Collections.Generic;
abstract class Shape
{
    public abstract double CalculateArea();
}
class Circle : Shape
{
    private double radius;
    public Circle(double radius)
    {
        this.radius=radius;
    }
    public override double CalculateArea()
    {
        return Math.PI*radius*radius;
    }
}
class Rectangle : Shape
{
    private double length;
    private double width;
    public Rectangle(double length,double width)
    {
        this.length=length;
        this.width=width;
    }
    public override double CalculateArea()
    {
        return length*width;
    }
}
class Triangle : Shape
{
    private double baseLength;
    private double height;
    public Triangle(double baseLength,double height)
    {
        this.baseLength=baseLength;
        this.height=height;
    }
    public override double CalculateArea()
    {
        return 0.5*baseLength*height;
    }
}
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<Shape> shapes = new List<Shape>();
        for(int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            string type = input[0];
            if (type == "Circle")
            {
                double radius = double.Parse(input[1]);
                shapes.Add(new Circle(radius));
            }
            else if (type == "Rectangle")
            {
                double length = double.Parse(input[1]);
                double width = double.Parse(input[2]);
                shapes.Add(new Rectangle(length,width));
            }
            else if (type == "Triangle")
            {
                double baseLength = double.Parse(input[1]);
                double height = double.Parse(input[2]);
                shapes.Add(new Triangle(baseLength,height));
            }
        }
        foreach(Shape shape in shapes)
        {
            Console.WriteLine("{0:F2}",shape.CalculateArea());
        }
    }
}