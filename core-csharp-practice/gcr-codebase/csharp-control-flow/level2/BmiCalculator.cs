using System;
class BmiCalculator
{
    public static void Main(String[] args)
    {
        //Calculation of BMI
        Console.Write("Enter weight in kgrams: ");
        double weight = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter height in cm: ");
        double height = Convert.ToDouble(Console.ReadLine());
        height = height / 100; // converting cm to meters
        double bmi = weight / (height * height);
        Console.WriteLine($"Your BMI is: {bmi}");
        if (bmi < 18.5)
        {
            Console.WriteLine("You are underweight.");
        }
        else if (bmi >= 18.5 && bmi < 24.9)
        {
            Console.WriteLine("You have a normal weight.");
        }
        else if (bmi >= 25 && bmi < 29.9)
        {
            Console.WriteLine("You are overweight.");
        }
        else
        {
            Console.WriteLine("Obese.");
        }
    }
}