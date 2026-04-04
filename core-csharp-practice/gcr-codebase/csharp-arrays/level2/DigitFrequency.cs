using System;
class DigitFrequency{
    public static void Main(string[] args){
        // Take number input from user
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int temp = number;
        int digitCount = 0;
        // Find the count of digits
        while(temp!=0){
            digitCount++;
            temp = temp / 10;
        }
        // Array to store digits
        int[] digits = new int[digitCount];
        int index = 0;
        // Extract digits and store them in array
        while(number!=0){
            digits[index] = number % 10;
            number = number / 10;
            index++;
        }
        // Frequency array for digits 0 to 9
        int[] frequency = new int[10];
        // Calculate frequency of each digit
        for(int i=0;i<digitCount;i++){
            int digit = digits[i];
            frequency[digit]++;
        }
        // Display digit frequency
        Console.WriteLine("Digit Frequency: ");
        for(int i=0;i<10;i++){
            if (frequency[i]>0){
                Console.WriteLine("Digit "+i+" occurs "+frequency[i]+" time(s)");
            }
        }
    }
}
