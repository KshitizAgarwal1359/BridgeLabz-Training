using System;
using System.Collections.Generic;
class SortStackRecursion
{
    public static void Main(String[] args)
    {
        Stack<int> stack = new Stack<int>();
        // Push elements into stack
        stack.Push(30);
        stack.Push(10);
        stack.Push(50);
        stack.Push(20);
        stack.Push(40);
        Console.WriteLine("Original Stack:");
        PrintStack(stack);
        SortStack(stack);
        Console.WriteLine("Sorted Stack (Ascending):");
        PrintStack(stack);
    }
    // Function to sort the stack
    static void SortStack(Stack<int> stack)
    {
        if (stack.Count == 0)
            return;
        int temp = stack.Pop();
        SortStack(stack);
        InsertInSortedOrder(stack, temp);
    }
    // Helper function to insert element in sorted order
    static void InsertInSortedOrder(Stack<int> stack, int value)
    {
        if (stack.Count == 0 || stack.Peek() <= value)
        {
            stack.Push(value);
            return;
        }
        int temp = stack.Pop();
        InsertInSortedOrder(stack, value);
        stack.Push(temp);
    }
    // Utility function to print stack
    static void PrintStack(Stack<int> stack)
    {
        foreach (int item in stack)
            Console.Write(item + " ");
        Console.WriteLine();
    }
}
