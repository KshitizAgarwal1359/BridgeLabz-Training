using System;
class BelowHunderedMultiples
{
    public static void Main(String[] args)
    {
        Console.Write("Enter a number:");
        int number=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Multiples of {number} below 100 are: ");
        for(int i = 100; i >= 1; i--) //calculating multiples below 100 using for loop
        {
            if (i % number == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}