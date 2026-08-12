using System;
class Program
{
    public static void Main()
    {
        int[] arr = {1,34,56,90,2,6,7};
        Console.WriteLine("Array is : ");
        Console.WriteLine(string.Join(" ",arr));
        Console.WriteLine("Find the element to find: ");
        int key = int.Parse(Console.ReadLine());
        int index = 0;
        bool find = false;
        for(int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == key)
            {
                index = i;
                find = true;
                break;
            }
            else
            {
                find = false;
            }
        }
        if (find)
        {
            Console.WriteLine($"Element {key} found at index {index}");
        }
        else
        {
            Console.WriteLine($"Element {key} not found.");
        }
    }
}