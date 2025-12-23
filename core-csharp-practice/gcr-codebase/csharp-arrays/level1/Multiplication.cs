using System;
class Multiplication{
	public static void Main(String[] args){
		//doing multiplication of a number from 6 to 9 and storing it in an array
		Console.Write("Enter the number: ");
		int number = Convert.ToInt32(Console.ReadLine());
		int[] table = new int[4];
		for(int i=0;i<4;i++){
			table[i]=number*(6+i);
		}
		Console.WriteLine("the multiplication from 6 to 9 for a number is: ");
		for(int j=0;j<4;j++){
			Console.WriteLine(number+" * "+(6+j)+" = "+table[j]);
		}
		
	}
}
