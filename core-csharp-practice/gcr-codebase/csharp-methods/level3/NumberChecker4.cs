//prime number check
//neon number check
//spy number check
//automorphic number
//buzz number divisible by 7
using System;
class NumberChecker
{
    public static bool IsPrime(int number)
    {
        if(number<=1)return false;
        for(int i=2;i<=number/2;i++)
        {
            if(number%i==0)return false;
        }
        return true;
    }
    public static bool IsNeonNumber(int number)
    {
        int square=number*number;
        int sum=0;
        while(square>0)
        {
            sum+=square%10;
            square/=10;
        }
        return sum==number;
    }
    public static bool IsSpyNumber(int number)
    {
        number=Math.Abs(number);
        int sum=0;
        int product=1;
        while(number>0)
        {
            int digit=number%10;
            sum+=digit;
            product*=digit;
            number/=10;
        }
        return sum==product;
    }
    public static bool IsAutomorphicNumber(int number)
    {
        int square=number*number;
        int temp=number;
        while(temp>0)
        {
            if(temp%10!=square%10)return false;
            temp/=10;
            square/=10;
        }
        return true;
    }
    public static bool IsBuzzNumber(int number)
    {
        if(number%7==0)return true;
        if(number%10==7)return true;
        return false;
    }
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Is Prime Number: "+IsPrime(number));
        Console.WriteLine("Is Neon Number: "+IsNeonNumber(number));
        Console.WriteLine("Is Spy Number: "+IsSpyNumber(number));
        Console.WriteLine("Is Automorphic Number: "+IsAutomorphicNumber(number));
        Console.WriteLine("Is Buzz Number: "+IsBuzzNumber(number));
    }
}
