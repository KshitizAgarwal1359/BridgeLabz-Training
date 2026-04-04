using System;
class CountOfDigits
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());
        int count =0;
        if (number == 0)
        {
            Console.WriteLine(1);
        }
        else
        {
            while (number != 0)
            {
                number=number/10;
                count++;
            }
            Console.WriteLine(count);
        }
    }
}