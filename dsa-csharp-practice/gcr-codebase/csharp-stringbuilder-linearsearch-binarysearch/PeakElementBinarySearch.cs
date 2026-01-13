using System;

class PeakElementBinarySearch
{
    static void Main()
    {
        int[] arr = { 1, 3, 20, 4, 1, 0 };

        int peakIndex = FindPeakElement(arr);

        Console.WriteLine("Peak element index: " + peakIndex);
        Console.WriteLine("Peak element value: " + arr[peakIndex]);
    }

    static int FindPeakElement(int[] arr)
    {
        int low = 0;
        int high = arr.Length - 1;

        while (low < high)
        {
            int mid = low + (high - low) / 2;

            // If mid is less than next element,
            // peak must be on the right side
            if (arr[mid] < arr[mid + 1])
            {
                low = mid + 1;
            }
            else
            {
                // Peak is on the left side or mid itself
                high = mid;
            }
        }

        // low == high → peak index
        return low;
    }
}
