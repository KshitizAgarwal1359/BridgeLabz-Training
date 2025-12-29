//fibonacci sequence
using System;
class Fibonacci{
    public static void Main(string[] args){
        Console.Write("Enter the number of terms ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Fibonacci sequence up to {n} terms:");
        PrintFibonacci(n);
}
    public static void PrintFibonacci(int terms){
    int a = 0, b = 1;
    for (int i = 1; i <= terms; i++){
        Console.Write(a + " ");
        int temp = a + b;
        a = b;
        b = temp;
    }
    Console.WriteLine();
}
}