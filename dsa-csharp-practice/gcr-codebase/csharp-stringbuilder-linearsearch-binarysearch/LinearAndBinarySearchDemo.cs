using System;

class LinearAndBinarySearchDemo
{
    static void Main()
    {
        int[] arr = { 3, 4, -1, 1, 7 };
        int target = 4;
        int missingPositive = FindFirstMissingPositive(arr);
        Console.WriteLine("First Missing Positive Integer: " + missingPositive);
        Array.Sort(arr); // Required for Binary Search
        int targetIndex = BinarySearch(arr, target);
        Console.WriteLine("Index of target " + target + ": " + targetIndex);
    }
    // part1: Linear Search for First Missing Positive Integer
    static int FindFirstMissingPositive(int[] arr)
    {
        int n = arr.Length;
        bool[] visited = new bool[n + 1];
        // Mark visited positive numbers
        for (int i = 0; i < n; i++)
        {
            if (arr[i] > 0 && arr[i] <= n)
            {
                visited[arr[i]] = true;
            }
        }
        // Find first unvisited positive number
        for (int i = 1; i <= n; i++)
        {
            if (!visited[i])
            {
                return i;
            }
        }
        return n + 1;
    }
    //part 2: Binary Search for Target Index
    static int BinarySearch(int[] arr, int target)
    {
        int low = 0, high = arr.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }

        return -1;
    }
}
