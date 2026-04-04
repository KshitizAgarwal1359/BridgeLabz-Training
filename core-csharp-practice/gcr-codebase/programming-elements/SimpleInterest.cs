using System;

class SimpleInterest
{
    static void Main()
    {
        // Principal amount
        double principal = 1000;
        
        // Rate of interest per annum
        double rate = 5;
        
        // Time period in years
        double time = 2;
        
        // Calculate simple interest
        double simpleInterest = (principal * rate * time) / 100;
        
        // Calculate total amount
        double totalAmount = principal + simpleInterest;
        
        Console.WriteLine($"Simple Interest: {simpleInterest}");
        Console.WriteLine($"Total Amount: {totalAmount}");
    }
}