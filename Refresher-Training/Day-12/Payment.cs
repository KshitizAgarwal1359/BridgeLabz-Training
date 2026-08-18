using System;
using System.Collections.Generic;

interface IPayment
{
    void Pay(double amount);
}
class CreditCardPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine("Paid: "+ amount + " using credit card");
    }
}
class UpiPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine("Paid: "+ amount +" using upi app");
    }
}
class CashPayment : IPayment
{
    public void Pay(double amount)
    {
        Console.WriteLine("Paid "+amount+" using cash.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<IPayment> payments = new List<IPayment>();
        List<double> amounts = new List<double>();
        for(int i = 0; i < nameof; i++)
        {
            string[] input = Console.ReadLine().Split();
            string type = input[0];
            double amount = double.Parse(input[1]);
            if (type == "UPI")
            {
                payments.Add(new UpiPayment());
            }
            else if (type == "CARD")
            {
                payments.Add(new CreditCardPayment());
            }
            else if (type == "CASH")
            {
                payments.Add(new CashPayment());
            }
            amounts.Add(amount);
        }
        for(int i = 0; i < payments.Count; i++)
        {
            payments[i].Pay(amounts[i]);
        }
    }
}