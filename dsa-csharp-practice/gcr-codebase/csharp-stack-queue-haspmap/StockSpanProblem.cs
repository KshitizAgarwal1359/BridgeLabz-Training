using System;
using System.Collections.Generic;
class StockSpanProblem
{
    public static void Main(String[] args)
    {
        int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
        int[] span = CalculateSpan(prices);
        Console.WriteLine("Stock Prices:");
        foreach (int p in prices)
            Console.Write(p + " ");
        Console.WriteLine("\n\nStock Span:");
        foreach (int s in span)
            Console.Write(s + " ");
    }
    static int[] CalculateSpan(int[] prices)
    {
        int n = prices.Length;
        int[] span = new int[n];
        Stack<int> stack = new Stack<int>(); // stores indices
        for (int i = 0; i < n; i++)
        {
            // Pop elements while stack is not empty
            // and price at stack top is <= current price
            while (stack.Count > 0 && prices[stack.Peek()] <= prices[i])
            {
                stack.Pop();
            }
            // If stack is empty, price is greater than all previous prices
            span[i] = (stack.Count == 0) ? (i + 1) : (i - stack.Peek());
            // Push current index
            stack.Push(i);
        }
        return span;
    }
}
