using System;
class SumOfNaturalNumber
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a natural number:");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number <= 0)
        {
            Console.WriteLine("Please enter a valid natural number");
            return;
        }
        int sumFor = 0;
        for(int i = 1; i <= number; i++)
        {
            sumFor += i;
        }
        int sumFormula = (number * (number + 1)) / 2;
        Console.WriteLine("Sum using for loop: " + sumFor);
        Console.WriteLine("Sum using formula: " + sumFormula);
        if(sumFor == sumFormula)
        {
            Console.WriteLine("Result is same. Both computations are correct.");
        }
        else
        {
            Console.WriteLine("Result is incorrect. Computations does not match");
        }
    }
}