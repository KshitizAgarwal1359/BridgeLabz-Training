using System;
class LargestNumber
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number:");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number:");
        int secondNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter third number:");
        int thirdNumber = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Is the first number the largest? {firstNumber > secondNumber && firstNumber > thirdNumber}");
        Console.WriteLine($"Is the second number the largest? {secondNumber > firstNumber && secondNumber > thirdNumber}");
        Console.WriteLine($"Is the third number the largest? {thirdNumber > secondNumber && thirdNumber > firstNumber}");
    }
}