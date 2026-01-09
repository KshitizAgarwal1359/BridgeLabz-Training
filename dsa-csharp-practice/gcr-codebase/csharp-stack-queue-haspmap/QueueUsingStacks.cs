using System;
using System.Collections.Generic;
class QueueUsingStacks
{
    private Stack<int> inStack = new Stack<int>();
    private Stack<int> outStack = new Stack<int>();
    // Enqueue operation
    public void Enqueue(int value)
    {
        inStack.Push(value);
        Console.WriteLine($"{value} enqueued");
    }
    // Dequeue operation
    public int Dequeue()
    {
        if (outStack.Count == 0)
        {
            while (inStack.Count > 0)
            {
                outStack.Push(inStack.Pop());
            }
        }
        if (outStack.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }
        return outStack.Pop();
    }
    // Display queue elements
    public void Display()
    {
        Console.Write("Queue elements: ");
        foreach (int item in outStack)
            Console.Write(item + " ");
        int[] temp = inStack.ToArray();
        for (int i = temp.Length - 1; i >= 0; i--)
            Console.Write(temp[i] + " ");
        Console.WriteLine();
    }
}
class Program
{
    public static void Main(String[] args)
    {
        QueueUsingStacks queue = new QueueUsingStacks();
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        queue.Display();
        Console.WriteLine("Dequeued: " + queue.Dequeue());
        Console.WriteLine("Dequeued: " + queue.Dequeue());
        queue.Display();
    }
}
