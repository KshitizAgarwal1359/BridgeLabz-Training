using System;
class Program
{
    static int count = 0;

    static void merge(int[] arr, int l, int m, int r)
    {
        int n1 = m - l + 1;
        int n2 = r - m;
        int[] L = new int[n1];
        int[] R = new int[n2];
        for (int i = 0; i < n1; i++)
            L[i] = arr[l + i];
        for (int j = 0; j < n2; j++)
            R[j] = arr[m + 1 + j];
        int x = 0, y = 0, k = l;
        while (x < n1 && y < n2)
        {
            if (L[x] <= R[y])
            {
                arr[k] = L[x];
                x++;
            }
            else
            {
                arr[k] = R[y];
                y++;
            }
            k++;
        }
        while (x < n1)
        {
            arr[k] = L[x];
            x++;
            k++;
        }
        while (y < n2)
        {
            arr[k] = R[y];
            y++;
            k++;
        }
    }
    static void mergeSort(int[] arr, int l, int r)
    {
        if (l < r)
        {
            int m = l + (r - l) / 2;
            mergeSort(arr, l, m);
            mergeSort(arr, m + 1, r);
            merge(arr, l, m, r);
            count++;
        }
    }
    public static int countMergeOperations(int[] arr)
    {
        count = 0;
        mergeSort(arr, 0, arr.Length - 1);
        return count;
    }
    static void Main()
    {
        int[] arr = { 4, 2, 1, 3 };
        int result = countMergeOperations(arr);
        Console.WriteLine("Sorted Array: " + string.Join(" ", arr));
        Console.WriteLine("Total Merge Operations: " + result);
    }
}