//counrt the digits and store them in array
//reverse using aray
//comapre the two array
//palindrome check
//check of duck number : a number having at least one non zero digit
using System;
class NumberChecker
{
    public static int CountDigits(int number)
    {
        number=Math.Abs(number);
        if(number==0)return 1;
        int count=0;
        while(number>0)
        {
            count++;
            number/=10;
        }
        return count;
    }
    public static int[] GetDigitsArray(int number)
    {
        number=Math.Abs(number);
        int count=CountDigits(number);
        int[] digits=new int[count];
        for(int i=count-1;i>=0;i--)
        {
            digits[i]=number%10;
            number/=10;
        }
        return digits;
    }
    public static int[] ReverseDigitsArray(int[] digits)
    {
        int[] reversed=new int[digits.Length];
        int index=0;
        for(int i=digits.Length-1;i>=0;i--)
        {
            reversed[index++]=digits[i];
        }
        return reversed;
    }
    public static bool AreArraysEqual(int[] a,int[] b)
    {
        if(a.Length!=b.Length)return false;
        for(int i=0;i<a.Length;i++)
        {
            if(a[i]!=b[i])return false;
        }
        return true;
    }
    public static bool IsPalindrome(int[] digits)
    {
        int[] reversed=ReverseDigitsArray(digits);
        return AreArraysEqual(digits,reversed);
    }
    public static bool IsDuckNumber(int[] digits)
    {
        foreach(int d in digits)
        {
            if(d!=0)return true;
        }
        return false;
    }
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number=Convert.ToInt32(Console.ReadLine());
        int[] digits=GetDigitsArray(number);
        Console.Write("Digits: ");
        foreach(int d in digits)
        {
            Console.Write(d+" ");
        }
        Console.WriteLine();
        int[] reversed=ReverseDigitsArray(digits);
        Console.Write("Reversed Digits: ");
        foreach(int d in reversed)
        {
            Console.Write(d+" ");
        }
        Console.WriteLine();
        Console.WriteLine("Is Palindrome: "+IsPalindrome(digits));
        Console.WriteLine("Is Duck Number: "+IsDuckNumber(digits));
    }
}
