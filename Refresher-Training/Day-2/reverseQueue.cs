// using System;
// using System.Collections.Generic;
// class Program
// {
//     public static void Main(string[] args)
//     {
//         Queue<int> queue = new Queue<int>();
//         Console.Write("Enter no. of elements in the queue: ");
//         int n = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Enter elements: ");
//         for(int i = 0; i < n; i++)
//         {
//             int ele = Convert.ToInt32(Console.ReadLine());
//             queue.Enqueue(ele);
//         }
//         Console.WriteLine("Original Queue: ");
//         foreach(int item in queue)
//         {
//             Console.Write(item + " ");
//         }
//         Console.WriteLine();
//         Stack<int> stack = new Stack<int>();
//         while (queue.Count > 0)
//         {
//             stack.Push(queue.Dequeue());
//         }
//         while (stack.Count > 0)
//         {
//             queue.Enqueue(stack.Pop());
//         }
//         Console.WriteLine("Reversed Queue: ");
//         foreach(int i in queue)
//         {
//             Console.Write(i + " ");
//         }
//         Console.WriteLine();
//     }
// }