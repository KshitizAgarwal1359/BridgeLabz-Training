using System;
class OddEvenNumbers
{
    public static void Main(String[] args)
    {
        // check odd even no. from 1 to number provided by user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i + "  is an Even number");
            }
            else
            {
                Console.WriteLine(i + "  is an Odd number");
            }
        }
    }
}