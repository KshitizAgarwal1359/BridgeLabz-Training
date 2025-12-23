using System;
class BMICalculation{
    public static void Main(string[] args){
        Console.Write("Enter number of persons: ");
        int number = Convert.ToInt32(Console.ReadLine());
        double[][] personData = new double[number][];
        string[] weightStatus = new string[number];
        for (int i=0;i<number;i++){
            personData[i] = new double[3];
        }
        // Take input for weight and height with validation
        for (int i=0;i<number;i++){
            Console.WriteLine("Enter details for Person "+(i+1));
            Console.Write("Enter weight(in kg): ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter height(in meters): ");
            double height = Convert.ToDouble(Console.ReadLine());
            // Check for negative or zero values
            if (weight<=0||height<=0){
                Console.WriteLine("Invalid input. Please enter positive values.");
                i--; // retry the same person
                continue;
            }
            personData[i][0] = weight;
            personData[i][1] = height;
        }// Calculate BMI and determine weight status
        for (int i=0;i<number;i++){
            double weight = personData[i][0];
            double height = personData[i][1];
            double bmi = weight / (height * height);
            personData[i][2] = bmi;
            if(bmi<18.5){
                weightStatus[i] = "Underweight";
            }
            else if (bmi>=18.5 && bmi<24.9){
                weightStatus[i] = "Normal weight";
            }
            else if(bmi>=25 && bmi<29.9){
                weightStatus[i] = "Overweight";
            }
            else{
                weightStatus[i] = "Obese";
            }
        }// Display the result
        Console.WriteLine("BMI Report");
        for (int i=0;i<number;i++){
            Console.WriteLine("Person " +(i+1));
            Console.WriteLine("Height: " +personData[i][1] + " m");
            Console.WriteLine("Weight: " +personData[i][0] + " kg");
            Console.WriteLine("BMI: " +personData[i][2]);
            Console.WriteLine("Status: " +weightStatus[i]);
            Console.WriteLine();
        }
    }
}
