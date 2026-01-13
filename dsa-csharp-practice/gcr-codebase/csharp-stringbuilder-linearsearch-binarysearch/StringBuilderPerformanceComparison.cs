using System;
using System.Text;
using System.Diagnostics;

class StringBuilderPerformanceComparison
{
    static void Main()
    {
        int iterations = 100000;
        //string concatenation using +
        Stopwatch swString = Stopwatch.StartNew();
        string normalString = "";
        for (int i = 0; i < iterations; i++)
        {
            normalString += "a";
        }
        swString.Stop();
        Console.WriteLine("String (+) Time: " + swString.ElapsedMilliseconds + " ms");
        //stringBuilder concatenation
        Stopwatch swBuilder = Stopwatch.StartNew();
        StringBuilder sb = new StringBuilder(iterations);
        for (int i = 0; i < iterations; i++)
        {
            sb.Append("a");
        }
        swBuilder.Stop();
        Console.WriteLine("StringBuilder Time: " + swBuilder.ElapsedMilliseconds + " ms");
    }
}
