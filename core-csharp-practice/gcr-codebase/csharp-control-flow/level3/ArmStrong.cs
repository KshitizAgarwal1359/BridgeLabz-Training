using System;
class ArmStrong
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a nummber:");
        int number = Convert.ToInt32(Console.ReadLine());
        int originalNumber = number;
        int sum=0;
        while (originalNumber != 0)
        {
            int remainder=originalNumber%10;
            sum+=remainder*remainder*remainder;
            originalNumber/=10;
        }
        if (sum == number)
        {
            Console.WriteLine($"{number} is an Armstrong number");
        }
        else
        {
            Console.WriteLine($"{number} is not armstrong");
        }
    }
}