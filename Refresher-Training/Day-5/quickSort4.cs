using System;
class Program
{
    static int count = 0;
    static int partition(int[] arr, int low, int high)
    {
        int pivot = arr[high];
        int i = low;
        for (int j = low; j < high; j++)
        {
            count++;
            if (arr[j] <= pivot)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
            }
        }
        int temp2 = arr[i];
        arr[i] = arr[high];
        arr[high] = temp2;
        return i;
    }
    static void quickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int p = partition(arr, low, high);
            quickSort(arr, low, p - 1);
            quickSort(arr, p + 1, high);
        }
    }
    static int quicksortComparisons(int[] arr)
    {
        count = 0;
        quickSort(arr, 0, arr.Length - 1);
        return count;
    }
    static void Main()
    {
        int[] arr = { 3, 1, 2 };
        int result = quicksortComparisons(arr);
        Console.WriteLine("Sorted Array: " + string.Join(" ", arr));
        Console.WriteLine("Comparisons: " + result);
    }
}