using System;

class AddDigits
{
    static void Main()
    {
        int num = 9875;   // fixed number

        while (num >= 10)
        {
            int sum = 0;

            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }

            num = sum;
        }

        Console.WriteLine(num);
    }
}
