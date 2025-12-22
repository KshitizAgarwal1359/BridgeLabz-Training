using System;
class DivisibleBy5
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Is the {number} divisible by 5? {number % 5 == 0}");
        
    }
}