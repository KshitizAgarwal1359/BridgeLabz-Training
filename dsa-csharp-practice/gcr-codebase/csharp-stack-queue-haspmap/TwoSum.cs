using System;
using System.Collections.Generic;
class TwoSum
{
    public static void Main(String[] args)
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] result = FindTwoSum(nums, target);
        Console.WriteLine("Indices:");
        Console.WriteLine($"[{result[0]}, {result[1]}]");
    }
    static int[] FindTwoSum(int[] nums, int target)
    {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];
            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }
            // Store current number with its index
            map[nums[i]] = i;
        }
        return new int[] { -1, -1 }; // Should not occur as per assumption
    }
}
