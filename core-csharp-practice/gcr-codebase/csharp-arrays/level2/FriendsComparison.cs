using System;
class FriendsComparison{
	public static void Main(String[] args){
		string[] friends = {"Amar","Akbar","Anthony"};
		int[] ages = new int[3];
		double[] heights = new double[3];
		for(int i=0;i<3;i++){
			Console.WriteLine("Enter details for "+friends[i]);
			Console.Write("Age: ");
			ages[i] = Convert.ToInt32(Console.ReadLine());
			Console.Write("Height(in cm): ");
			heights[i] = Convert.ToDouble(Console.ReadLine());
		}
		int youngestIndex = 0;
		int tallestIndex = 0;
		for(int i=1;i<3;i++){
			if(ages[i]<ages[youngestIndex]){
				youngestIndex=i;
			}
			if(heights[i]>heights[tallestIndex]){
				tallestIndex=i;
			}
		}
		Console.WriteLine("Result: ");
		Console.WriteLine("Youngest friend: "+friends[youngestIndex]+" Age: "+ages[youngestIndex]);
		Console.WriteLine("Tallest friend: "+friends[tallestIndex]+" Height: "+ heights[tallestIndex]);
	}
}