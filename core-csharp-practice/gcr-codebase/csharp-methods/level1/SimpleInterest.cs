using System;
class SimpleInterest
{
    public static void Main(String[] args)
    {
        Console.Write("Enter Principal amount: ");
        double principal  = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Rate of interest: ");
        double rate  = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter Time (in years): ");
        double time  = Convert.ToDouble(Console.ReadLine());
        double simpleInterest = CalCulateSI(principal,rate,time);
        Console.WriteLine($"The Simple Interest is {simpleInterest} for Principal {principal}, Rate of Interest {rate} and Time {time} years.");
    }
    public static double CalCulateSI(double principal, double rate, double time)
    {
        double simpleInterest = (principal*rate*time)/100;
        return simpleInterest;
    }
}