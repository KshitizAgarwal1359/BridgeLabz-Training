using System;
using System.Runtime.CompilerServices;
class SmallestNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number:");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number:");
        int secondNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third number:");
        int thirdNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Is the first number the smallest? {firstNumber < secondNumber && firstNumber < thirdNumber}");
    }
}