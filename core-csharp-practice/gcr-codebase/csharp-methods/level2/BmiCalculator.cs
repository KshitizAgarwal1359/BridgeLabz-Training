using System;
class BmiCalculator
{
    static void CalculateBmi(double[,] data)
    {
        for(int i = 0; i < data.GetLength(0); i++)
        {
            double weight=data[i,0];
            double heightCm=data[i,1];
            double heightMeter=heightCm/100;
            double bmi=weight/(heightMeter*heightMeter);
            data[i,2]=bmi;
        }
    }
    static string[] GetBmiStatus(double[,] data)
    {
        string[] status = new string[data.GetLength(0)];
        for(int i = 0;i < data.GetLength(0);i++)
        {
            double bmi = data[i,2];
            if (bmi < 18.5)
            {
                status[i]="underweight";
            }
            else if(bmi<25)
            status[i]="normal";
            else if(bmi<30)
            status[i]="overweight";
            else
            status[i]="obese";
        }
        return status;
    }
    public static void Main(String[] args)
    {
        double[,] data = new double[10,3];
        for(int i = 0; i < 10; i++)
        {
            Console.WriteLine($"enter details for person {i+1}");
            Console.Write("Weight(kg): ");
            data[i,0]=Convert.ToDouble(Console.ReadLine());
            Console.Write("Enetr height(cm)");
            data[i,1]=Convert.ToDouble(Console.ReadLine());
        }
        CalculateBmi(data);
        string[] bmiStatus=GetBmiStatus(data);
        Console.WriteLine("BMI status: ");
        Console.WriteLine("Person\tWeight\tHeight\tBMi\tStatus");
        for(int i = 0;i < 10; i++)
        {
            Console.WriteLine($"{data[i+1]}\t{data[i,1]}\t{data[i,2]:F2}\t{bmiStatus[i]}");
        }
    }
}
