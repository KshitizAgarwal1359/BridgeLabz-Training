using System;

class SearchIn2DMatrix
{
    static void Main()
    {
        int[,] matrix =
        {
            { 1, 3, 5, 7 },
            { 10, 11, 16, 20 },
            { 23, 30, 34, 60 }
        };
        Console.Write("Enter target value: ");
        int target = int.Parse(Console.ReadLine());
        bool found = SearchMatrix(matrix, target);
        if (found)
            Console.WriteLine("Target found in the matrix.");
        else
            Console.WriteLine("Target not found in the matrix.");
    }
    static bool SearchMatrix(int[,] matrix, int target)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int low = 0;
        int high = rows * cols - 1;
        while (low <= high)
        {
            int mid = low + (high - low) / 2;
            int row = mid / cols;
            int col = mid % cols;
            int midValue = matrix[row, col];
            if (midValue == target)
                return true;
            else if (midValue < target)
                low = mid + 1;
            else
                high = mid - 1;
        }
        return false;
    }
}
