// //Reversing a string using stack
// using System;
// using System.Collections.Generic;
// using System.Text;
// class Program
// {
//     public static void Main(String[] args)
//     {
//         Console.Write("Enter a string: ");
//         string str = Console.ReadLine();
//         Stack<char> stack = new Stack<char>();
//         foreach(char ch in str)
//         {
//             stack.Push(ch);
//         }
//         string reversed = "";
//         while (stack.Count > 0)
//         {
//             reversed+=stack.Pop();
//         }
//         Console.WriteLine($"Reversed String: {reversed}");
//     }
// }