using System;
using System.Collections.Generic;
class ZeroSumSubarrays
{
    public static void Main(String[] args)
    {
        int[] arr = { 3, 4, -7, 1, 3, 3, 1, -4 };
        FindZeroSumSubarrays(arr);
    }
    static void FindZeroSumSubarrays(int[] arr)
    {
        // HashMap to store prefix sum and list of indices
        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
        int prefixSum = 0;
        // Initialize for prefixSum = 0 at index -1
        map[0] = new List<int> { -1 };
        Console.WriteLine("Zero Sum Subarrays:");
        for (int i = 0; i < arr.Length; i++)
        {
            prefixSum += arr[i];
            if (map.ContainsKey(prefixSum))
            {
                // Found zero-sum subarrays
                foreach (int startIndex in map[prefixSum])
                {
                    Console.WriteLine($"Subarray found from index {startIndex + 1} to {i}");
                }
            }
            // Add current index to the map
            if (!map.ContainsKey(prefixSum))
                map[prefixSum] = new List<int>();
            map[prefixSum].Add(i);
        }
    }
}
