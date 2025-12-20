using System;
class SimpleInterest
{
    public static void Main()
    {
        Console.Write("Enter the principal amount: ");
        double principal = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the rate of interest: ");
        double rate = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the time in years: ");
        double time = Convert.ToDouble(Console.ReadLine());
        double simpleInterest = (principal * rate * time) / 100;
        Console.WriteLine($"The Simple Interest is {simpleInterest} for Principal: {principal}, Rate of Interest {rate}, Time {time} years");
    }
}