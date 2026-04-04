using System;
class SumUntilZero2
{
    public static void Main(String[] args)
    {
        double sum = 0;
        double number;
        while (true)
        {
            Console.Write("Enter a number (0 to stop): ");
            number = Convert.ToDouble(Console.ReadLine());
            if (number <= 0)
            {
                break;
            }
            sum += number;
        }
        Console.WriteLine("The sum: " + sum);
    }
}