using System;
class PositiveOrNegative{
	public static void Main(String[] args){
		//entering 5 inputs from user
		int[] array = new int[5];
		Console.WriteLine("Enter 5 integer numbers: ");
		for(int i=0;i<array.Length;i++){
			array[i] = Convert.ToInt32(Console.ReadLine());
		}
		for(int j=0;j<array.Length;j++){
			if(array[j]==0){
				Console.WriteLine("The number is zero.");
			}
			else if(array[j]<0){
				Console.WriteLine("The number is negative.");
			}
			else{
				if(array[j]%2==0){
					Console.WriteLine("The number is positive and even.");
				}
				else{
					Console.WriteLine("The number is positive and odd.");
				}
			}
		}
			if(array[0]==array[array.Length-1]){
				Console.WriteLine("The first and last element of are equal.");
			}
			else if(array[0]>array[array.Length-1]){
				Console.WriteLine("The first element is larger than last element of array");
			}
			else{
				Console.WriteLine("The first element is smaller than last element of array");
			}
		
	}
}