using System;
class ReverseUsingArray{
	public static void Main(String[] args){
		Console.Write("Enter a number: ");
		int number = Convert.ToInt32(Console.ReadLine());
		int temp= number;
		int digitCount = 0;
		while (temp != 0){
            digitCount++;
            temp = temp / 10;
        }
        int[] digits = new int[digitCount];
        int index=0;
        while(number!=0){
            digits[index] = number % 10;
            number = number / 10;
            index++;
        }
        int[] reverseDigits = new int[digitCount];
        for (int i = 0; i < digitCount; i++){
            reverseDigits[i] = digits[digitCount - 1 - i];
        }
        Console.Write("\nReversed Number: ");
        for (int i = 0; i < digitCount; i++)
        {
            Console.Write(reverseDigits[i]);
        }
	}
}