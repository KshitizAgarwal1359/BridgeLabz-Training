using System;
class Calculator
{
    public static void Main(String[] args)
    {
        Console.Write("Enter the first number:");
        double firstNumber=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the second number:");
        double secondNumber=Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter an operator (+, -, *, /):");
        string operation=Console.ReadLine();
        switch (operation)
        {
            case "+":
            Console.WriteLine("result:"+ (firstNumber+secondNumber));
            break;
            case "-":
            Console.WriteLine("result:"+ (firstNumber-secondNumber));
            break;
            case "*":
            Console.WriteLine("result:"+ (firstNumber*secondNumber));
            break;
            case "/":
            if(secondNumber!=0)
            {
                Console.WriteLine("result:"+ (firstNumber/secondNumber));
            }
            else
            {
                Console.WriteLine("Division by zero is not allowed.");
            }
            break;
            default:
            Console.WriteLine("Invalid operator.");
            break;
        }

    }
}