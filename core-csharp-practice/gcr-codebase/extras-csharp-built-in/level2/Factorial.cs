//factorial using recursion
using System;
class Factorial{
    public static void Main(string[] args){
    int number = getNumber();
    long ans = calculateFactorial(number); // Calculate the factorial
    displayAns(number, ans);
}
    public static int getNumber(){ // Function to get user input
    Console.Write("Please enter non-negative integer: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
    }
    public static long calculateFactorial(int n){ // function to calculate factorial
    if (n == 0 || n == 1){
        return 1;
    }else{
        return n * calculateFactorial(n - 1);
    }
    }
    public static void displayAns(int number, long factorial){
    Console.WriteLine($"The factorial of {number} is {factorial}");
}
}