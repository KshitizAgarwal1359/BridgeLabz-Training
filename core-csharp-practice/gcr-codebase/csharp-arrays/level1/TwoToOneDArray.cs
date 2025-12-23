using System;
class TwoToOneDArray{
	public static void Main(String[] args){
		Console.Write("Enter the no. of rows: ");
		int rows = Convert.ToInt32(Console.ReadLine());
		Console.Write("Enter the no. of columns: ");
		int columns = Convert.ToInt32(Console.ReadLine());
		int[,] matrix = new int[rows,columns];
		Console.WriteLine("Enter the elements of matrix: ");
		for(int i=0;i<rows;i++){
			for(int j=0;j<columns;j++){
				Console.Write($"Element[{i},{j}]: ");
				matrix[i,j]=Convert.ToInt32(Console.ReadLine());
			}
		}
		int[] array = new int[rows*columns];
		int index = 0;
		for(int i=0;i<rows;i++){
			for(int j=0;j<columns;j++){
				array[index]=matrix[i,j];
				index++;
			}
		}
		//2d array
		for(int i=0;i<rows;i++){
			for(int j=0;j<columns;j++){
				Console.Write(matrix[i,j]+" ");
			}
			Console.WriteLine();
		}
		//1d array
		for(int i=0;i<array.Length;i++){
			Console.Write(array[i]+" ");
		}
	}
}