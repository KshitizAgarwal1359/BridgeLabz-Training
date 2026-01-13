using System;

class RotationPointBinarySearch
{
    static void Main()
    {
        int[] arr = { 15, 18, 2, 3, 6, 12 };
        int index = FindRotationPoint(arr);
        Console.WriteLine("Rotation point index: " + index);
        Console.WriteLine("Smallest element: " + arr[index]);
    }
    static int FindRotationPoint(int[] arr)
    {
        int low = 0;
        int high = arr.Length - 1;
        while (low < high)
        {
            int mid = low + (high - low) / 2;
            // If mid element is greater than last element,
            // the rotation point is to the right
            if (arr[mid] > arr[high])
            {
                low = mid + 1;
            }
            else
            {
                high = mid;
            }
        }
        // low points to the smallest element
        return low;
    }
}
