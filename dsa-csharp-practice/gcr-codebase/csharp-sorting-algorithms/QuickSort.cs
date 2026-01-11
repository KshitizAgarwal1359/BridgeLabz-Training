using System;
class QuickSortProductPrices
{
    public static void Main(String[] args)
    {
        double[] productPrices = { 1299.99, 499.50, 899.00, 199.99, 749.75, 999.00 }; //array of prices
        Console.WriteLine("Product Prices Before Sorting:");
        PrintArray(productPrices);
        QuickSort(productPrices, 0, productPrices.Length - 1); //call Quick Sort
        Console.WriteLine("\nProduct Prices After Sorting (Ascending Order):");
        PrintArray(productPrices);
    }
    public static void QuickSort(double[] arr, int low, int high) //method to perform Quick Sort
    {
        if (low < high)
        {
            int pivotIndex = Partition(arr, low, high); //partition the array and get pivot index
            QuickSort(arr, low, pivotIndex - 1); //recursively sort left and right partitions
            QuickSort(arr, pivotIndex + 1, high);
        }
    }
    public static int Partition(double[] arr, int low, int high) //partition method using last element as pivot
    {
        double pivot = arr[high];
        int i = low - 1;
        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot) //if current element is smaller than pivot
            {
                i++;
                double temp = arr[i]; //swap arr[i] and arr[j]
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        double tempPivot = arr[i + 1]; // Place pivot in correct position
        arr[i + 1] = arr[high];
        arr[high] = tempPivot;
        return i + 1;
    }
    public static void PrintArray(double[] arr) //method to print array elements
    {
        foreach (double price in arr)
        {
            Console.Write(price + " ");
        }
        Console.WriteLine();
    }
}
