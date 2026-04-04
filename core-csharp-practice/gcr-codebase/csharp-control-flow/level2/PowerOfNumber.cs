using System;
class PowerOfNumber
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the Nummber:");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the power: ");
        int power = Convert.ToInt32(Console.ReadLine());
        int result = 1;
        for(int i = 1; i <= power; i++)   //using for loop to compute power
        {
            result*=number;
        }
        Console.WriteLine("Result= "+result);
    }
}