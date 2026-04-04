using System;
class NoOfRounds
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the first side length of the triangular feild: ");
        double side1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the second side length of the triangular field: ");
        double side2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the third side length of the triangular field: ");
        double side3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"The no. of rounds an athlete has to run to complete 5km in the triangular field are {CalculateRounds(side1,side2,side3)}");

    }
    public static double CalculateRounds(double side1,double side2,double side3)
    {
        double perimeter = side1+side2+side3;
        double rounds = 5000/perimeter;   // rounds to run 5km in the triangular field
        return rounds;
    }
}