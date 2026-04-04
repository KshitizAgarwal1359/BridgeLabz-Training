using System;

class NumberChecker
{
    //Method to count digits
    public static int CountDigits(int number)
    {
        number = Math.Abs(number);
        if(number==0) return 1;

        int count = 0;
        while(number>0)
        {
            count++;
            number /= 10;
        }
        return count;
    }

    //Method to store digits in an array
    public static int[] GetDigitsArray(int number)
    {
        number = Math.Abs(number);
        int count = CountDigits(number);
        int[] digits = new int[count];

        for (int i=count-1;i>=0;i--)
        {
            digits[i] = number % 10;
            number /= 10;
        }

        return digits;
    }

    // c. Method to check Duck number
    // Duck number: contains at least one non-zero digit
    public static bool IsDuckNumber(int[] digits)
    {
        foreach (int d in digits)
        {
            if (d != 0)
                return true;
        }
        return false;
    }

    // d. Method to check Armstrong number
    public static bool IsArmstrongNumber(int number,int[] digits)
    {
        int power=digits.Length;
        int sum=0;

        foreach (int d in digits)
        {
            sum+=(int)Math.Pow(d, power);
        }

        return sum==Math.Abs(number);
    }

    // e. Method to find largest and second largest digit
    public static void FindLargestAndSecondLargest(int[] digits,out int largest,out int secondLargest)
    {
        largest = Int32.MinValue;
        secondLargest = Int32.MinValue;

        foreach (int d in digits)
        {
            if (d>largest)
            {
                secondLargest=largest;
                largest=d;
            }
            else if (d>secondLargest && d!=largest)
            {
                secondLargest =d;
            }
        }
    }

    // f. Method to find smallest and second smallest digit
    public static void FindSmallestAndSecondSmallest(int[] digits,out int smallest,out int secondSmallest)
    {
        smallest = Int32.MaxValue;
        secondSmallest = Int32.MaxValue;

        foreach(int d in digits)
        {
            if(d<smallest)
            {
                secondSmallest = smallest;
                smallest = d;
            }
            else if(d<secondSmallest && d != smallest)
            {
                secondSmallest = d;
            }
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int digitCount = CountDigits(number);
        int[] digits = GetDigitsArray(number);

        Console.WriteLine("\nDigits:");
        foreach (int d in digits)
            Console.Write(d + " ");

        Console.WriteLine("Count of digits: " + digitCount);
        Console.WriteLine("Is Duck Number: " + IsDuckNumber(digits));
        Console.WriteLine("Is Armstrong Number: " + IsArmstrongNumber(number, digits));

        FindLargestAndSecondLargest(digits, out int largest, out int secondLargest);
        Console.WriteLine($"Largest Digit: {largest}");
        Console.WriteLine($"Second Largest Digit: {secondLargest}");

        FindSmallestAndSecondSmallest(digits, out int smallest, out int secondSmallest);
        Console.WriteLine($"Smallest Digit: {smallest}");
        Console.WriteLine($"Second Smallest Digit: {secondSmallest}");
    }
}
