using System;
class OddEvenNumbers{
	public static void Main(String[] args){
		Console.Write("Enter a positive integer greater than 1: ");
		int number = Convert.ToInt32(Console.ReadLine());
		// create odd and even numbers array
		int[] odd = new int[number/2+1];
		int[] even = new int[number/2+1];
		int oddIndex = 0;
		int evenIndex =0;
		for(int i=1;i<=number;i++){
			if(i%2==0){
				even[evenIndex]=i;
				evenIndex++;
			}
			else{
				odd[oddIndex]=i;
				oddIndex++;
			}
		}
		Console.WriteLine("Odd Numbers: ");
		for(int i=0;i<oddIndex;i++){
			Console.Write(odd[i]+" ");
		}
		Console.WriteLine("Even numbers: ");
		for(int i=0;i<evenIndex;i++){
			Console.Write(even[i]+" ");
		}
	}
}
