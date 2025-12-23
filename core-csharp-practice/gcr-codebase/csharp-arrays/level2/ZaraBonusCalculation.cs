using System;
class ZaraBonusCalculation{
	public static void Main(String[] args){
		const int EMP_Count = 10;
		double[] salary = new double[EMP_Count];
		double[] yearsOfService = new double[EMP_Count];
		double[] bonus = new double[EMP_Count];
		double[] newSalary = new double[EMP_Count];
		double totalBonus = 0.0;
		double totalOldSalary = 0.0;
		double totalNewSalary = 0.0;
		Console.WriteLine("Enetr salary and years of service for 10 employees: ");
		for(int i=0;i<EMP_Count;i++){
			Console.WriteLine($"Employee {i+1}: ");
			Console.Write("Enter Salary: ");
			double sal = Convert.ToDouble(Console.ReadLine());
			Console.Write("Enter years: ");
			double service = Convert.ToDouble(Console.ReadLine());
			if(sal<=0 || service<0){
				Console.Write("Invalid input.");
				i--;
				continue;
			}
			salary[i]=sal;
			yearsOfService[i]=service;
		}
		for(int i=0;i<EMP_Count;i++){
			if(yearsOfService[i]>5){
				bonus[i]=salary[i]*0.05;
			}
			else{
				bonus[i]=salary[i]*0.02;
			}
			newSalary[i] = salary[i]+bonus[i];
			totalBonus+=bonus[i];
			totalOldSalary+=salary[i];
			totalNewSalary+=newSalary[i];
		}
		Console.WriteLine("Zara bonus Calculation: ");
		Console.WriteLine($"Total old salary: {totalOldSalary} ");
		Console.WriteLine($"total bonus paid: {totalBonus} ");
		Console.WriteLine($"total new salary: {totalNewSalary}");
	}
}