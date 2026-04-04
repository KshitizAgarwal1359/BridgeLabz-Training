//basic calculator
using System;
class Calculator{
    
    public static double Add(double a, double b){  // Addition
        return a + b;
    }
    public static double Subtract(double a, double b){ // Subtraction
        return a - b;
    }
    public static double Multiply(double a, double b){ // Multiplication
        return a * b;
    }
    public static double Divide(double a, double b){ // Division
        return a / b;
    }
    public static void Main(string[] args){
        Console.WriteLine("Addition");
        Console.WriteLine("Subtraction");
        Console.WriteLine("Multiplication");
        Console.WriteLine("Division");
        Console.Write("Enter your choice: ");
        string choice = Console.ReadLine();
        Console.Write("Enter first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());
        double ans = 0;
        if (choice == "1"){
            ans = Add(number1, number2);
        }else if (choice == "2"){
            ans = Subtract(number1, number2);
        }else if (choice == "3"){
            ans = Multiply(number1, number2);
        }else if (choice == "4"){
            if (number2 == 0){
                Console.WriteLine("Not Valid");
                return;
            }
            ans = Divide(number1, number2);
        }else{
            Console.WriteLine("Not valid");
            return;
        }
        Console.WriteLine($"Result = {ans}");
    }
}