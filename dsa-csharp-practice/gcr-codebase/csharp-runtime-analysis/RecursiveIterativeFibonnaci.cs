using System;
using System.Diagnostics;
class RecursiveIterativeFibonacci
{
    public static void Main(String[] args)
    {
        int[] testValues = {10,30,50};
        foreach (int n in testValues)
        {
            Console.WriteLine($"Fibonacci({n})");
            //recursive Fibonacci(limit to avoid long execution)
            if (n <= 30)
            {
                Stopwatch swRec = Stopwatch.StartNew();
                int recResult = FibonacciRecursive(n);
                swRec.Stop();
                Console.WriteLine($"Recursive Result: {recResult}");
                Console.WriteLine($"Recursive Time: {swRec.ElapsedMilliseconds} ms");
            }
            else
            {
                Console.WriteLine("Recursive Time: Unfeasible (>1 hr)");
            }
            //iterative Fibonacci
            Stopwatch swIter = Stopwatch.StartNew();
            int iterResult = FibonacciIterative(n);
            swIter.Stop();
            Console.WriteLine($"Iterative Result: {iterResult}");
            Console.WriteLine($"Iterative Time: {swIter.ElapsedMilliseconds} ms");
        }
    }
    static int FibonacciRecursive(int n)
    {
        if (n <= 1)
            return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }
    static int FibonacciIterative(int n)
    {
        if (n <= 1)
            return n;
        int a = 0, b = 1, sum = 0;
        for (int i = 2; i <= n; i++)
        {
            sum = a + b;
            a = b;
            b = sum;
        }
        return b;
    }
}
