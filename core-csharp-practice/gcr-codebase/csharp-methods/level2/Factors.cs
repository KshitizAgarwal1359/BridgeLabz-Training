//find the factors of a number
// product of factors
// sum of factors
//sum of sq of factors
using System;
class Factors
{
    static int[] FindingFactors(int number)
    {
        int count = 0;
        for(int i=1;i<=number;i++)
        {
            if (number%i == 0)
            {
                count++;
            }
        }
        int[] factors=new int[count];
        int index=0;
        for(int i=1;i<=number;i++)
        {
            if (number%i == 0)
            {
                factors[index]=i;
                index++;
            }
        }
        return factors;
    }
    static int SumOfFactors(int[] factors)
    {
        int sum=0;
        foreach(int factor in factors)
        {
            sum=sum+factor;
        }
        return sum;
    }
    static long ProductOfFactors(int[] factors)
    {
        long product=1;
        foreach(int factor in factors)
        {
            product=product*factor;
        }
        return product;
    }
    static double SumOfSquare(int[] factors)
    {
        double sum=0;
        foreach(int factor in factors)
        {
            sum=sum+Math.Pow(factor,2);
        }
        return sum;
    }
    static void Main(String[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int[] factors = FindingFactors(number);
        Console.WriteLine($"Factors are: ");
        foreach(int factor in factors)
        {
            Console.Write(factor+" " );
        }
        Console.WriteLine();
        Console.WriteLine($"The sum of factors is: {SumOfFactors(factors)}");
        Console.WriteLine($"The product of factors is: {ProductOfFactors(factors)}");
        Console.WriteLine($"The sum of squares of factors is: {SumOfSquare(factors)}");
    }
}
