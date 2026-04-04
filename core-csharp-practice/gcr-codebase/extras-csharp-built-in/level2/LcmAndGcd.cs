//calculate gcd and lcm
using System;
class LcmAndGcd
{
    public static void Main(string[] args){
    int num1 = NumberGet("Enter the first number: ");
    int num2 = NumberGet("Enter the second number: ");
    int gcd = CalculateGcd(num1, num2);
    int lcm = CalculateLcm(num1, num2, gcd);
        Console.WriteLine($"GCD of {num1} and {num2} is: {gcd}");
        Console.WriteLine($"LCM of {num1} and {num2} is: {lcm}");
    }
    public static int NumberGet(string message){ //function to get integer input from user
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
    }
    public static int CalculateGcd(int a, int b){ //function to calculate GCD
        while (b != 0){
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    public static int CalculateLcm(int a, int b, int gcd){ //function to calculate LCM
        return (a * b) / gcd;
    }
}
