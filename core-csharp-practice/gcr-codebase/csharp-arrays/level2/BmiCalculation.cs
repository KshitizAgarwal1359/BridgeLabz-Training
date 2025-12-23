using System;
class BmiCalculation{
    public static void Main(string[] args){
        Console.Write("Enter number of persons: ");
        int count = Convert.ToInt32(Console.ReadLine());
        double[] weight = new double[count];
        double[] height = new double[count];
        double[] bmi = new double[count];
        string[] status = new string[count];
        for (int i=0;i<count;i++){   //BMI stadard formula and classification
            Console.WriteLine("Enter details for Person " +(i+1));
            Console.Write("Weight(in kg): ");
            weight[i] = Convert.ToDouble(Console.ReadLine());
            Console.Write("Height(in meters): ");
            height[i] = Convert.ToDouble(Console.ReadLine());
        }
        for(int i=0;i<count;i++){
            bmi[i] = weight[i]/(height[i]*height[i]);
            if (bmi[i]<18.5){
                status[i] = "Underweight";
            }
            else if(bmi[i]>=18.5 && bmi[i]<24.9){
                status[i] = "Normal weight";
            }
            else if(bmi[i]>=25 && bmi[i]<29.9){
                status[i] = "Overweight";
            }
            else{
                status[i] = "Obese";
            }
        }
        Console.WriteLine("BMI Report");
        for (int i=0;i<count;i++)
        {
            Console.WriteLine("Person " + (i+1));
            Console.WriteLine("Height: " +height[i]+" m");
            Console.WriteLine("Weight: " +weight[i]+" kg");
            Console.WriteLine("BMI: "+bmi[i]);
            Console.WriteLine("Status: "+status[i]);
            Console.WriteLine();
        }
    }
}
