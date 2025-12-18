using System;

class Palindrome
{
    static void Main()
    {
        int a = 121;   // fixed number to check

        int reversedNumber = 0;

        // base case check
        if (a < 0 || (a % 10 == 0 && a != 0))
        {
            Console.WriteLine("Not a palindrome");
            return;
        }

        // reverse only half of the number
        while (a > reversedNumber)
        {
            reversedNumber = reversedNumber * 10 + a % 10;
            a = a / 10;
        }

        // compare both halves
        if (a == reversedNumber || a == reversedNumber / 10)
        {
            Console.WriteLine("Number is palindrome");
        }
        else
        {
            Console.WriteLine("Not a palindrome");
        }
    }
}
