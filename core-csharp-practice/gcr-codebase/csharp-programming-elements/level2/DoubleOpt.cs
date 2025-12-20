//Same as Int Operation but for double data type

using System;

public class DoubleOpt{
    public static void Main(string[] args){
        Console.WriteLine("Enter the values of a, b and c");
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        double result1 = a + b * c;
        double result2 = a * b + c;
        double result3 = c + a / b;
        double result4 = a % b + c;
        Console.WriteLine($"The results of Double Operations are {result1}, {result2}, {result3}, {result4}"); 
    }
}