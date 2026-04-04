/*Write a program that:
● Takes two date inputs and compares them to check if the first date is
before, after, or the same as the second date.

Hint: Use DateTime.Compare(), DateTime.CompareTo(), or direct comparison
using DateTime methods.*/
using System;
class ComparingDate{
    public static void Main(String[] args){
    DateTime date1 = Convert.ToDateTime(Console.ReadLine());
    DateTime date2 = Convert.ToDateTime(Console.ReadLine());
    int ans = DateTime.Compare(date1, date2); 
    if (ans < 0){    //checking which date is previous
    Console.WriteLine("First date is previous of the second date");
    }
    else if (ans > 0){
    Console.WriteLine("First date is post second date");
    }
    {
    Console.WriteLine("Both dates are same");
    }
}
}