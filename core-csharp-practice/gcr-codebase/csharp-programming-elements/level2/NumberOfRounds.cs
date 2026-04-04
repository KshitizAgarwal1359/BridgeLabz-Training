using System;
class NumberOfRounds
{
    public static void Main(String[] args)
    {
        Console.Write("enter the first side length:");
        int side1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter the second side length:");
        int side2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("enter the third side length:");
        int side3 = Convert.ToInt32(Console.ReadLine());
        int perimeter = side1 + side2 + side3;
        int numberOfRounds = 5000 / perimeter;
        Console.WriteLine($"The no of round the athelete has to run is {numberOfRounds} to complete 5km");
    }
}