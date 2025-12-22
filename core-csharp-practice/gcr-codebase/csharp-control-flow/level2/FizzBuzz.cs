using System;
class FizzBuzz
{
    public static void Main(String[] args)
    {
        // for multiplles of 3 and 5 print FizzBuzz
        // for multiples of 3 print Fizz
        // for multiples of 5 print Buzz
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        for(int i=0;i<=number;i++){
        if (i % 3 == 0 && i % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (i % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (i % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(i);
        }
        }
    }
}