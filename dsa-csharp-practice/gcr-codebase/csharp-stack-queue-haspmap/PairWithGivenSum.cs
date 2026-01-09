using System;
using System.Collections.Generic;
class PairWithGivenSum
{
    public static void Main(String[] args)
    {
        int[] arr = { 8, 4, 1, 6, 2, 9 };
        int target = 10;
        bool exists = HasPairWithSum(arr, target);
        if (exists)
            Console.WriteLine("Pair with given sum exists");
        else
            Console.WriteLine("No pair with given sum found");
    }
    static bool HasPairWithSum(int[] arr, int target)
    {
        HashSet<int> visited = new HashSet<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            int required = target - arr[i];
            if (visited.Contains(required))
            {
                Console.WriteLine($"Pair found: {arr[i]} + {required} = {target}");
                return true;
            }
            visited.Add(arr[i]);
        }
        return false;
    }
}
