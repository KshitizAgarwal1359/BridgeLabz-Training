using System;
class BubbleSortStudentMarks
{
    public static void Main(String[] args)
    {
        int[] marks = { 78, 45, 90, 32, 67, 88, 54 }; //array of student marks
        Console.WriteLine("Student marks before sorting:");
        PrintArray(marks);
        BubbleSort(marks); // Call Bubble Sort method
        Console.WriteLine("\nStudent Marks After Sorting (Ascending Order):");
        PrintArray(marks);
    }
    public static void BubbleSort(int[] arr) //method to perform Bubble Sort
    {
        int n = arr.Length;
        bool swapped;
        for (int i = 0; i < n - 1; i++) //outer loop for number of passes
        {
            swapped = false;
            for (int j = 0; j < n - i - 1; j++)  //inner loop for comparisons
            {
                if (arr[j] > arr[j + 1]) //compare adjacent elements
                {
                    int temp = arr[j]; //swap if they are in wrong order
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }
            if (!swapped) //if no swaps occurred, array is already sorted
                break;
        }
    }
    public static void PrintArray(int[] arr) // Method to print array elements
    {
        foreach (int mark in arr)
        {
            Console.Write(mark + " ");
        }
        Console.WriteLine();
    }
}
