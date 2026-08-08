using System;
class Program
{
    static void Main()
    {
        int[] arr = {12,56,89,23,34,5,10,8};
        Console.Write("Original array: ");
        Console.Write(string.Join(" ",arr));
        int n = arr.Length;
        for(int i = 1; i < n; ++i)
        {
            int key = arr[i];
            int j=i-1;
            while(j>=0 && arr[j] > key)
            {
                arr[j+1]=arr[j];
                j=j-1;
            }
            arr[j+1]=key;
        }
        Console.WriteLine();
        Console.Write("Sorted Array: ");
        Console.WriteLine(string.Join(" ",arr));
    }
}