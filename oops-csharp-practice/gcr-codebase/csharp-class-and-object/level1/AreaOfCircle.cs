/*Program to Compute Area of a Circle
Problem Statement: Write a program to create a Circle class with an attribute radius. Add methods to calculate 
and display the area and circumference of the circle.*/

using System;

public class Circle{
        static double pi = 3.14;
        static double radius;
        static double area; 

        public double areaOfCircle(double radius){
             area = pi * radius * radius;
                return area;
    }
    public void displayAreaOfCircle(double area){
            Console.WriteLine("Area of Circle is: "+area);
    }
}
public class AreaOfCircle{
    public static void Main(string[] args){
        Console.Write("Enter a radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());

            Circle arc = new Circle();

            double area = arc.areaOfCircle(radius);
            arc.displayAreaOfCircle(area);
    }
}
