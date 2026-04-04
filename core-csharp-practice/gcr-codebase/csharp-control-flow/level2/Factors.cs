// Calculating factors of a user inputed number using for loop
using System;
class Factors
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Factors for the Number {number} are:");
        for(int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
