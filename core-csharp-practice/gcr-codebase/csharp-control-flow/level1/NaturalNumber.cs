using System;
class NaturalNumber
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        if(number > 0)
        {
            Console.WriteLine("The sum of {number} natural numbers is: " + (number * (number + 1)) / 2);
        }
        else
        {
            Console.WriteLine($"The number {number} is not a natural number");
        }
    }
}