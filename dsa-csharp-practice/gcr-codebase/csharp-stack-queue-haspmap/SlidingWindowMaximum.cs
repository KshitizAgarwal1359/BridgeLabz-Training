using System;
using System.Collections.Generic;
class SlidingWindowMaximum
{
    public static void Main(String[] args)
    {
        int[] arr = { 1, 3, -1, -3, 5, 3, 6, 7 };
        int k = 3;
        int[] result = MaxSlidingWindow(arr, k);
        Console.WriteLine("Sliding Window Maximums:");
        foreach (int val in result)
        {
            Console.Write(val + " ");
        }
    }
    static int[] MaxSlidingWindow(int[] arr, int k)
    {
        if (arr.Length == 0 || k == 0)
            return new int[0];
        int n = arr.Length;
        int[] result = new int[n - k + 1];
        LinkedList<int> deque = new LinkedList<int>(); // stores indices
        int resultIndex = 0;
        for (int i = 0; i < n; i++)
        {
            // Remove indices out of current window
            if (deque.Count > 0 && deque.First.Value <= i - k)
            {
                deque.RemoveFirst();
            }
            // Remove smaller elements from back
            while (deque.Count > 0 && arr[deque.Last.Value] <= arr[i])
            {
                deque.RemoveLast();
            }
            // Add current index
            deque.AddLast(i);
            // Store maximum for window
            if (i >= k - 1)
            {
                result[resultIndex++] = arr[deque.First.Value];
            }
        }
        return result;
    }
}
