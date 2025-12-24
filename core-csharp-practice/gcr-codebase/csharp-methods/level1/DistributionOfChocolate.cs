// m chocolates are divided among n students find each student no. of chocolate and remaining chocolates.
using System;
class DistributionOfChocolate
{
    public static void Main(String[] args)
    {
        Console.Write("Enter no. of chocolates: ");
        int chocolates = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter no. of students: ");
        int students  = Convert.ToInt32(Console.ReadLine());
        int[] result = FindRemainderAndQuotient(chocolates,students);
        Console.WriteLine($"Each student gets {result[1]} chocolates and remaining chocolates are {result[0]}");
    }
    public static int[] FindRemainderAndQuotient(int number,int divisor)
    {
        int quotient = number/divisor; //each student chocolates number
        int remainder = number%divisor;  //remaining chocolates
        return new int[] {remainder,quotient};
    } 
}