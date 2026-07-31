using System;
class MergeSortBookPrices
{
    public static void Main(string[] args)
    {
        double[] bookPrices = { 499.99, 299.50, 899.00, 150.75, 650.00, 399.25 }; //array of book prices
        Console.WriteLine("Book Prices Before Sorting:");
        PrintArray(bookPrices);
        MergeSort(bookPrices, 0, bookPrices.Length - 1); //call Merge Sort
        Console.WriteLine("\nBook Prices After Sorting (Ascending Order):");
        PrintArray(bookPrices);
    }
    public static void MergeSort(double[] arr, int left, int right) //method to perform Merge Sort
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;
            MergeSort(arr, left, mid); //sort first half
            MergeSort(arr, mid + 1, right); //sort second half
            Merge(arr, left, mid, right); //merge the sorted halves
        }
    }
    public static void Merge(double[] arr, int left, int mid, int right) //method to merge two sorted subArrays
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;
        double[] leftArray = new double[n1]; //temporary arrays
        double[] rightArray = new double[n2];
        for (int i = 0; i < n1; i++)  //copy data to temp arrays
            leftArray[i] = arr[left + i];
        for (int j = 0; j < n2; j++)
            rightArray[j] = arr[mid + 1 + j];
        int iIndex = 0, jIndex = 0;
        int k = left;
        while (iIndex < n1 && jIndex < n2) //merge temp arrays back into original array
        {
            if (leftArray[iIndex] <= rightArray[jIndex])
            {
                arr[k] = leftArray[iIndex];
                iIndex++;
            }
            else
            {
                arr[k] = rightArray[jIndex];
                jIndex++;
            }
            k++;
        }
        while(iIndex < n1) //copy remaining elements of leftArray
        {
            arr[k] = leftArray[iIndex];
            iIndex++;
            k++;
        }
        while (jIndex < n2) //copy remaining elements of rightArray
        {
            arr[k] = rightArray[jIndex];
            jIndex++;
            k++;
        }
    }
    static void PrintArray(double[] arr) //method to print array elements
    {
        foreach (double price in arr)
        {
            Console.Write(price + " ");
        }
        Console.WriteLine();
    }
}
