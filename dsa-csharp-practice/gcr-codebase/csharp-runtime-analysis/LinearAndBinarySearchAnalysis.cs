using System;
using System.Diagnostics;
class LinearAndBinarySearchAnalysis
{
    public static void Main(String[] args)
    {
        int[] datasetSizes = { 1000, 10000, 1000000 };
        foreach (int size in datasetSizes)
        {
            Console.WriteLine($"\nDataset Size: {size}");
            int[] data = GenerateDataset(size);
            int target = size; // worst-case target
            // Linear Search
            Stopwatch stopwatch = Stopwatch.StartNew();
            LinearSearch(data, target);
            stopwatch.Stop();
            Console.WriteLine($"Linear Search Time: {stopwatch.ElapsedMilliseconds} ms");
            // Sort before Binary Search
            Array.Sort(data);
            // Binary Search
            stopwatch.Restart();
            BinarySearch(data, target);
            stopwatch.Stop();
            Console.WriteLine($"Binary Search Time: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
    static int[] GenerateDataset(int size)
    {
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
        {
            arr[i] = i + 1;
        }
        return arr;
    }
    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
                return i;
        }
        return -1;
    }
    static int BinarySearch(int[] arr, int target)
    {
        int left = 0;
        int right = arr.Length - 1;
        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            if (arr[mid] == target)
                return mid;
            else if (arr[mid] < target)
                left = mid + 1;
            else
                right = mid - 1;
        }
        return -1;
    }
}
