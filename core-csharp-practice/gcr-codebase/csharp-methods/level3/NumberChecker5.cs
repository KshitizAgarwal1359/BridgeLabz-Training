//count of factors and finding factors
//greatest factor
//sum of factor
//product of factors
//product of cube of array
//perfect number check
//abundant number check
//deficient number check
//strong number check
using System;
class NumberChecker
{
    public static int[] FindFactors(int number)
    {
        int count=0;
        for(int i=1;i<=number;i++)
        {
            if(number%i==0)count++;
        }
        int[] factors=new int[count];
        int index=0;
        for(int i=1;i<=number;i++)
        {
            if(number%i==0)
            {
                factors[index]=i;
                index++;
            }
        }
        return factors;
    }

    public static int GreatestFactor(int[] factors)
    {
        int max=factors[0];
        foreach(int f in factors)
        {
            if(f>max)max=f;
        }
        return max;
    }

    public static int SumOfFactors(int[] factors)
    {
        int sum=0;
        foreach(int f in factors)
        {
            sum+=f;
        }
        return sum;
    }

    public static long ProductOfFactors(int[] factors)
    {
        long product=1;
        foreach(int f in factors)
        {
            product*=f;
        }
        return product;
    }

    public static double ProductOfCubeOfFactors(int[] factors)
    {
        double product=1;
        foreach(int f in factors)
        {
            product*=Math.Pow(f,3);
        }
        return product;
    }

    public static bool IsPerfectNumber(int number,int[] factors)
    {
        int sum=0;
        foreach(int f in factors)
        {
            if(f!=number)sum+=f;
        }
        return sum==number;
    }

    public static bool IsAbundantNumber(int number,int[] factors)
    {
        int sum=0;
        foreach(int f in factors)
        {
            if(f!=number)sum+=f;
        }
        return sum>number;
    }

    public static bool IsDeficientNumber(int number,int[] factors)
    {
        int sum=0;
        foreach(int f in factors)
        {
            if(f!=number)sum+=f;
        }
        return sum<number;
    }

    public static bool IsStrongNumber(int number)
    {
        int temp=number;
        int sum=0;
        while(temp>0)
        {
            int digit=temp%10;
            int fact=1;
            for(int i=1;i<=digit;i++)
            {
                fact*=i;
            }
            sum+=fact;
            temp/=10;
        }
        return sum==number;
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number=Convert.ToInt32(Console.ReadLine());

        int[] factors=FindFactors(number);

        Console.Write("Factors: ");
        foreach(int f in factors)
        {
            Console.Write(f+" ");
        }
        Console.WriteLine();

        Console.WriteLine("Greatest Factor: "+GreatestFactor(factors));
        Console.WriteLine("Sum of Factors: "+SumOfFactors(factors));
        Console.WriteLine("Product of Factors: "+ProductOfFactors(factors));
        Console.WriteLine("Product of Cube of Factors: "+ProductOfCubeOfFactors(factors));
        Console.WriteLine("Is Perfect Number: "+IsPerfectNumber(number,factors));
        Console.WriteLine("Is Abundant Number: "+IsAbundantNumber(number,factors));
        Console.WriteLine("Is Deficient Number: "+IsDeficientNumber(number,factors));
        Console.WriteLine("Is Strong Number: "+IsStrongNumber(number));
    }
}
