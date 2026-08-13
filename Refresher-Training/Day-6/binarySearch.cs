using System;
class Program
{
    public static void Main()
    {
        int[] arr = {12,34,44,47,78,89,95,99};
        Console.Write("enter element to search: ");
        int key = int.Parse(Console.ReadLine());
        int left = 0;
        int right = arr.Length-1;
        bool found = false;
        while (left <= right)
        {
            int mid = (left+right)/2;
            if (arr[mid] == key)
            {
                Console.WriteLine($"element {key} found at index {mid}");
                found = true;
                break;
            }
            else if(key<arr[mid]){
                right = mid-1;
            }
            else
            {
                left=mid+1;
            }
        }
        if (!found)
        {
            Console.WriteLine("Element not found");
        }
    }
}