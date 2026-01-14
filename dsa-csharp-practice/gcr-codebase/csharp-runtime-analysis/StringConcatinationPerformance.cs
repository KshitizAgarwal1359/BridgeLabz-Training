using System;
using System.Diagnostics;
using System.Text;
class StringConcatenationPerformance
{
    public static void Main(String[] args)
    {
        int[] operationCounts = {1000,10000,1000000};
        foreach (int n in operationCounts)
        {
            Console.WriteLine($"\nOperations Count: {n}");
            //string concatenation
            if (n <= 10000) // avoid extreme delay
            {
                Stopwatch swString = Stopwatch.StartNew();
                ConcatenateUsingString(n);
                swString.Stop();
                Console.WriteLine($"string Time: {swString.ElapsedMilliseconds} ms");
            }
            else
            {
                Console.WriteLine("string Time: Unusable (O(N²))");
            }
            //stringBuilder concatenation
            Stopwatch swBuilder = Stopwatch.StartNew();
            ConcatenateUsingStringBuilder(n);
            swBuilder.Stop();
            Console.WriteLine($"StringBuilder Time: {swBuilder.ElapsedMilliseconds} ms");
        }
    }
    static void ConcatenateUsingString(int n)
    {
        string result = "";
        for (int i = 0; i < n; i++)
        {
            result += "a";
        }
    }
    static void ConcatenateUsingStringBuilder(int n)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
        {
            sb.Append("a");
        }
        string result = sb.ToString();
    }
}
