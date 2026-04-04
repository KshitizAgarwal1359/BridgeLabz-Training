using System;

class FirstNegativeLinearSearch
{
    static void Main()
    {
        int[] arr = { 5, 3, 0, -4, -2, 7 };
        bool found = false;
        // Linear Search
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < 0)
            {
                Console.WriteLine("First negative number is: " + arr[i]);
                found = true;
                break; // Stop after finding the first negative number
            }
        }
        if (!found)
        {
            Console.WriteLine("No negative number found in the array.");
        }
    }
}
