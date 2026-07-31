using System;
class AbundantNumber
{
    public static void Main(String[] args)
    {
        //Abundant number check
        Console.Write("Enter the number:");
        int number= Convert.ToInt32(Console.ReadLine());
        int sum=0;
        for(int i = 1; i < number; i++)
        {
            if (number % i == 0)
            {
                sum+=i;
            }
        }
        if (sum > number)
        {
            Console.WriteLine($"{number} is an abundant number");
        }
        else
        {
            Console.WriteLine($"{number} is not an abundant number");
        }
    }
}