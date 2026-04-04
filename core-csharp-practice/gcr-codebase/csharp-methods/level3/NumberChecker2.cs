//count of digit
//sum of square of digit
//check of harshad number
//frequency of each digit int the number
using System;
class NumberChecker2
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

    public static int SumOfDigits(int[] digits)
    {
        int sum=0;
        foreach(int d in digits)
        {
            sum+=d;
        }
        return sum;
    }

    public static int SumOfSquaresOfDigits(int[] digits)
    {
        int sum=0;
        foreach(int d in digits)
        {
            sum+=(int)Math.Pow(d,2);
        }
        return sum;
    }

    public static bool IsHarshadNumber(int number,int[] digits)
    {
        int sum=SumOfDigits(digits);
        if(sum==0)return false;
        return number%sum==0;
    }

    public static int[,] FindDigitFrequency(int[] digits)
    {
        int[,] freq=new int[10,2]; 
        for(int i=0;i<10;i++)
        {
            freq[i,0]=i; 
            freq[i,1]=0; 
        }
        foreach(int d in digits)
        {
            freq[d,1]++; //
        }
        return freq; 
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

        Console.WriteLine("Count of digits: "+CountDigits(number));
        Console.WriteLine("Sum of digits: "+SumOfDigits(digits));
        Console.WriteLine("Sum of squares of digits: "+SumOfSquaresOfDigits(digits));
        Console.WriteLine("Is Harshad Number: "+IsHarshadNumber(number,digits));

        int[,] frequency=FindDigitFrequency(digits);

        Console.WriteLine("Digit Frequency:");
        Console.WriteLine("Digit\tCount");
        for(int i=0;i<10;i++)
        {
            if(frequency[i,1]>0)
            {
                Console.WriteLine(frequency[i,0]+"\t"+frequency[i,1]); 
            }
        }
    }
}
