// finding remainder and quotient of two numbers
using System;
class RemainderAndQuotient
{
    public static void Main(String[] args)
    {
        Console.Write("Enetr dividend: ");
        int dividend = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enetr divisor: ");
        int divisor  = Convert.ToInt32(Console.ReadLine());
        int[] result = FindRemainderAndQuotient(dividend,divisor);
        Console.WriteLine($"The remainder is {result[0]} and quotient is {result[1]}");
    }
    public static int[] FindRemainderAndQuotient(int dividend,int divisor)
    {
        int quotient = dividend/divisor;
        int remainder = dividend%divisor;
        return new int[] {remainder,quotient};
    }
}
