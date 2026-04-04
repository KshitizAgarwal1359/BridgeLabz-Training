using System;
class HeapSortJobApplicants
{
    public static void Main(String[] args)
    {
        int[] salaries = { 60000, 45000, 80000, 35000, 70000, 50000 }; //array of expected salary demands
        Console.WriteLine("Salary Demands Before Sorting:");
        PrintArray(salaries);
        HeapSort(salaries); //call Heap Sort
        Console.WriteLine("\nSalary Demands After Sorting (Ascending Order):");
        PrintArray(salaries);
    }
    public static void HeapSort(int[] arr) //method to perform Heap Sort
    {
        int n = arr.Length;
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(arr, n, i);
        }
        for (int i = n - 1; i > 0; i--)
        {
            int temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;
            Heapify(arr, i, 0);
        }
    }
    static void Heapify(int[] arr, int heapSize, int i)
    {
        int largest = i;       // Initialize largest as root
        int left = 2 * i + 1;  // Left child index
        int right = 2 * i + 2; // Right child index
        if (left < heapSize && arr[left] > arr[largest]) //if left child is larger than root
            largest = left;
        if (right < heapSize && arr[right] > arr[largest])
            largest = right;
        if (largest != i) //if largest is not root
        {
            int swap = arr[i];
            arr[i] = arr[largest];
            arr[largest] = swap;
            Heapify(arr, heapSize, largest); //recursively heapify the affected sub-tree
        }
    }
    public static void PrintArray(int[] arr)
    {
        foreach (int salary in arr)
        {
            Console.Write(salary + " ");
        }
        Console.WriteLine();
    }
}
