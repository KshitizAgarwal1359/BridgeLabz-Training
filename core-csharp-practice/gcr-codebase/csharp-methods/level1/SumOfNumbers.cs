// find the sum of n natural numbers.
using System;
class SumOfNumbers
{
    public static void Main(String[] args)
    {
        Console.Write("Enetr a natural number: ");
        int number  = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"The sum first {number} natural numbers is {CalculateSum(number)}");
    }
    public static int CalculateSum(int number)
    {
        int sum=0;
        while (number > 0)
        {
            sum+=number;
            number--;
        }
        return sum;
    }
}