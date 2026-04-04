//calculate the bonus of employees on the basis of years of service
//5% for more than 5 years 2% for less than 5 years
using System;
public class BonusOfEmployees{
    public static void EmployeeData(int[,] data, int empCount){
        Random rnd=new Random();
        for (int i=0;i<empCount;i++){
            data[i,0]=rnd.Next(10000, 100000); 
            data[i,1]=rnd.Next(1, 11);         
        }
    }
    public static void CalculateBonus(int[,] oldData,int[,] newData,int empCount){
        for (int i = 0; i < empCount; i++){
            int oldSalary = oldData[i, 0];
            int years = oldData[i, 1];
            int bonus;
            if (years > 5){
                bonus = (int)(oldSalary * 0.05);
            }
            else{
                bonus = (int)(oldSalary * 0.02);
            }
            newData[i, 0] = oldSalary;
            newData[i, 1] = bonus;
            newData[i, 2] = oldSalary + bonus;
        }
    }
    public static void DisplayTotal(int[,] data, int empCount){
        int totalOld=0,totalBonus=0,totalNew=0;
        Console.WriteLine("Emp\tOld Salary\tBonus\tNew Salary");
        for (int i = 0; i < empCount; i++){
            Console.WriteLine($"{i + 1}\t{data[i, 0]}\t\t{data[i, 1]}\t{data[i, 2]}");
            totalOld += data[i, 0];
            totalBonus += data[i, 1];
            totalNew += data[i, 2];
        }
        Console.WriteLine($"TOTAL\t{totalOld}\t\t{totalBonus}\t{totalNew}");
    }
    public  static void Main(){
        int employeeCount = 10;
        int[,] employeeData = new int[employeeCount, 2]; 
        int[,] salaryData = new int[employeeCount, 3];
        EmployeeData(employeeData, employeeCount);
        CalculateBonus(employeeData, salaryData, employeeCount);
        DisplayTotal(salaryData, employeeCount);
    }
}