//sum of n natural number
//using recursion and formula and compare both of result
using System;
class NaturalNumberSum
{
    static int SumUsingRecursion(int number)
    {
        if (number == 1)
        {
            return 1;
        }
        return number+SumUsingRecursion(number-1);
    }
    static int SumUsingFormula(int number)
    {
        return (number*(number+1))/2;
    }
    public static void Main(String[] args)
    {
        Console.Write("Enter a natural number: ");
        int number= Convert.ToInt32(Console.ReadLine());
        if (number <= 0)
        {
            Console.Write("please enter a natural no. greater than zero");
            return;
        }
        int sumRecursion = SumUsingRecursion(number);
        int sumFormuula = SumUsingFormula(number);
        Console.WriteLine($"The sum using recursion is {sumRecursion} and using formula is {sumFormuula}");
        if (sumFormuula == sumRecursion)
        {
            Console.WriteLine("Result is same.");
        }
        else
        {
            Console.WriteLine("Result differs.");
        }
    }
}
