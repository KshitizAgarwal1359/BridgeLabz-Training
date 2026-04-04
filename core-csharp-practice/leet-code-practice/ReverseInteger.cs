using System;

class ReverseInteger
{
    static void Main()
    {
        int x = 123;   // fixed number
        int reversed = 0;

        while (x != 0)
        {
            int digit = x % 10;

            // Overflow check
            if (reversed > (int.MaxValue - digit) / 10)
            {
                Console.WriteLine(0);
                return;
            }

            reversed = reversed * 10 + digit;
            x /= 10;
        }

        Console.WriteLine(reversed);
    }
}
