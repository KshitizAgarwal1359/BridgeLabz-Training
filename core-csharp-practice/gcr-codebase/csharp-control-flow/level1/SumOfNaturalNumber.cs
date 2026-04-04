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
        int sumWhile  = 0;
        int i=1;
        while (i <= number)
        {
            sumWhile += i;
            i++;
        }
        int sumFormula = number * (number + 1) / 2;
        Console.WriteLine("Sum using while loop: " + sumWhile);
        Console.WriteLine("Sum using formula: " + sumFormula);
        if(sumWhile == sumFormula)
        {
            Console.WriteLine("Result is same. Both computations are correct.");
        }
        else
        {
            Console.WriteLine("Result is incorrect. Computations does not match");
        }
    }
}