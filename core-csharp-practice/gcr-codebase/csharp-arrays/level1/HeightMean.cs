using System;
class HeightMean{
	public static void Main(String[] args){
		// calculating the mean height of football team
		double[] height = new double[11];
		Console.WriteLine("Enter the 11 players height in cm: ");
		for(int i=0;i<11;i++){
			height[i] = Convert.ToDouble(Console.ReadLine());
		}
		double total = 0.0;
		for(int j=0;j<11;j++){
			total+=height[j];
		}
		double mean = total/11;   //mean = sum of values/ total no. of values
		Console.WriteLine($"The mean of the football team height is {mean:F2} cm.");
	}
}			