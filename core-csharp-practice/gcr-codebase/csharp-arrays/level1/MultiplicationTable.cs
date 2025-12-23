using System;
class MultiplicationTables{
	public static void Main(String[] args){
		Console.WriteLine("Enter the Number for its table: ");
		int number = Convert.ToInt32(Console.ReadLine());
		int[] table = new int[10];
		for(int i=1;i<=10;i++){
			table[i-1]=number*i;
		}
		Console.WriteLine($"The table from 1 to 10 for the number {number} is: ");
		for(int j=1;j<=10;j++){
			Console.WriteLine(number+" * "+j+" = "+table[j-1]);
		}
	}
}