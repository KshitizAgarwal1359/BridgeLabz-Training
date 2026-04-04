using System;
class StoreAndSumNumbers{
	public static void Main(String[] args){
		// sum of elements entered till the user iputs 0 or negative integer
		double[] numbers = new double[10];
		double total = 0.0;
		int index =0;
		Console.WriteLine("Enter the number 0 or negative to stop");
		while(true){
			if(index==10){           //if index reaches length of array break the loop.
				break;
			}
			double input = Convert.ToDouble(Console.ReadLine());
			if(input<=0){
				break;             //if the input is lees than or equal to zero break the loop
			}
			numbers[index] = input;   //stores value in array
			index++;
		}
		Console.WriteLine("Numbers entered");
		for(int i=0;i<index;i++){
				Console.WriteLine(numbers[i]);
				total+=numbers[i];
			}
			Console.WriteLine("the total is: "+ total);
	}
}