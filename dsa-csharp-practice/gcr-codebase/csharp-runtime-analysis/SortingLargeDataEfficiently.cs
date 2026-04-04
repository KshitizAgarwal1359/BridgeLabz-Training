using System;
using System.Diagnostics;
class SortingLargeDataEfficiently
{
    public static void Main(String[] args)
    {
        int[] datasetSizes = { 1000, 10000, 1000000 };
        foreach (int size in datasetSizes)
        {
            Console.WriteLine($"\nDataset Size: {size}");
            int[] data = GenerateDataset(size);
            //bubble sort(skipping for very large input)
            if (size <= 10000)
            {
                int[] bubbleData = (int[])data.Clone();
                MeasureSortTime("Bubble Sort", bubbleData, BubbleSort);
            }
            else
            {
                Console.WriteLine("Bubble Sort:unfeasible(>1hr)");
            }
            // Merge Sort
            int[] mergeData = (int[])data.Clone();
            MeasureSortTime("Merge Sort", mergeData, MergeSort);
            // Quick Sort
            int[] quickData = (int[])data.Clone();
            MeasureSortTime("Quick Sort", quickData, arr => QuickSort(arr, 0, arr.Length - 1));
        }
    }
    static int[] GenerateDataset(int size)
    {
        Random random = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++)
            arr[i] = random.Next(size);
        return arr;
    }
    static void MeasureSortTime(string sortName, int[] data, Action<int[]> sortMethod)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        sortMethod(data);
        stopwatch.Stop();
        Console.WriteLine($"{sortName} Time: {stopwatch.ElapsedMilliseconds} ms");
    }
    //bubble Sort
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
    //merge Sort
    static void MergeSort(int[] arr)
    {
        if (arr.Length <= 1)
            return;
        int mid = arr.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[arr.Length - mid];
        Array.Copy(arr, left, mid);
        Array.Copy(arr, mid, right, 0, arr.Length - mid);
        MergeSort(left);
        MergeSort(right);
        Merge(arr, left, right);
    }
    static void Merge(int[] arr, int[] left, int[] right)
    {
        int i = 0, j = 0, k = 0;

        while (i < left.Length && j < right.Length)
            arr[k++] = (left[i] <= right[j]) ? left[i++] : right[j++];

        while (i < left.Length)
            arr[k++] = left[i++];

        while (j < right.Length)
            arr[k++] = right[j++];
    }
    //quick Sort
    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(arr, low, high);
            QuickSort(arr, low, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, high);
        }
    }
    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        int swap = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = swap;
        return i + 1;
    }
}
