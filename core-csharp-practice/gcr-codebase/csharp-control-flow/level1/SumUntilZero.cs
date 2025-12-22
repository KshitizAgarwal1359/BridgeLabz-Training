using System;
class SumUntilZero
{
    public static void Main(String[] args)
    {
        double sum = 0;
        double number;
        Console.Write("Enter a number (0 to stop): ");
        number = Convert.ToDouble(Console.ReadLine());
        while(number != 0)
        {
            sum += number;
            Console.Write("Enter a number (0 to stop): ");
            number = Convert.ToDouble(Console.ReadLine());
        }
        Console.WriteLine("The sum: " + sum);
    }
}