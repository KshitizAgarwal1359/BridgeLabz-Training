//find the max of three numbers
using System;
class MaxOfThreeNumber{
    public static void Main(string[] args){
    int num1 = GetInput("Enter first number: ");
    int num2 = GetInput("Enter second number: ");
    int num3 = GetInput("Enter third number: ");
    int maximum = FindMax(num1, num2, num3);
    Console.WriteLine($"The maximum number is: {maximum}");
    }
    public static int GetInput(string msg){
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}
    public static int FindMax(int a, int b, int c){ //method to find maximum of three numbers
    int maximum=a;
    if(b>maximum){
    maximum = b;
    }if(c>maximum){
    maximum = c;
    }
    return maximum;
}
}
