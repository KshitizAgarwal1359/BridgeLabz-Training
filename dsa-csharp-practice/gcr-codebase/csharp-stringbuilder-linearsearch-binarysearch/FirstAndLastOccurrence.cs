using System;

class FirstAndLastOccurrence
{
    static void Main()
    {
        int[] arr = { 2, 4, 4, 4, 6, 8, 10 };
        int target = 4;
        int first = FindFirstOccurrence(arr, target);
        int last = FindLastOccurrence(arr, target);
        Console.WriteLine("First Occurrence: " + first);
        Console.WriteLine("Last Occurrence: " + last);
    }
    static int FindFirstOccurrence(int[] arr, int target)
    {
        int low = 0, high = arr.Length - 1;
        int result = -1;
        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (arr[mid] == target)
            {
                result = mid;
                high = mid - 1; // search left
            }
            else if (arr[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        return result;
    }
    static int FindLastOccurrence(int[] arr, int target)
    {
        int low = 0, high = arr.Length - 1;
        int result = -1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            if (arr[mid] == target)
            {
                result = mid;
                low = mid + 1; // search right
            }
            else if (arr[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }
        return result;
    }
}
