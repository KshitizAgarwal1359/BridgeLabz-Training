using System;

class Armstrong
{
    static void Main()
    {
        int num = 153;

        int original = num;
        int sum = 0;

        while (num > 0)
        {
            int digit = num % 10;
            sum += digit * digit * digit;
            num /= 10;
        }

        if (sum == original)
        {
            Console.WriteLine("Armstrong number");
        }
        else
        {
            Console.WriteLine("Not an Armstrong number");
        }
    }
}
