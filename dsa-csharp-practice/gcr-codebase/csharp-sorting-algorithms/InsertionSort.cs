using System;
class InsertionSortEmployeeIds
{
    public static void Main(String[] args)
    {
        int[] employeeIds = { 1045, 1021, 1090, 1012, 1056, 1033 }; //unsorted array of employee ids
        Console.WriteLine("Employee IDs Before Sorting:");
        PrintArray(employeeIds);
        InsertionSort(employeeIds); //call insertion Sort method
        Console.WriteLine("\nEmployee IDs After Sorting (Ascending Order):");
        PrintArray(employeeIds);
    }
    public static void InsertionSort(int[] arr) //method to perform Insertion Sort
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++) //start from second element
        {
            int key = arr[i]; //element to be inserted
            int j = i - 1;
            //shift elements of sorted part to the right until correct position for key is found
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key; //insert the key at correct position
        }
    }
    public static void PrintArray(int[] arr) //method to print array elements
    {
        foreach (int id in arr)
        {
            Console.Write(id + " ");
        }
        Console.WriteLine();
    }
}
