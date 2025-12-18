using System;

class Fibonacci
{
    static void Main()
    {
        int n = 10; // fixed value (example)

        int a = 0, b = 1;

        if (n == 0)
        {
            Console.WriteLine(a);
            return;
        }

        for (int i = 2; i <= n; i++)
        {
            int next = a + b;
            a = b;
            b = next;
        }

        Console.WriteLine(b);
    }
}
