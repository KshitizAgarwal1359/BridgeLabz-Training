using System;
class Circle
{
        public double radius;
        public Circle() :  this(1.0) //default constructor
        {}
        public Circle(double radius) //parameterized constructor
    {
        this.radius=radius;
    }
    public void DisplayRadius()
    {
        Console.WriteLine("Radius: "+radius);
    }
    public static void Main(String[] args)
    {
        Circle circle1 = new Circle(); //default constructor
        circle1.DisplayRadius();
        Circle circle2 = new Circle(5.67); //parameterized constructor
        circle2.DisplayRadius();

    }
}