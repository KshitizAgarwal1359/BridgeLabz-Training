using System;
class FizzBuzzProgram{
	public static void Main(String[] args){
		Console.Write("Enter a positive integer: ");
		int number = Convert.ToInt32(Console.ReadLine());
		string[] result = new string[number+1];
		for(int i=1;i<=number;i++){
			if(i%3==0 && i%5==0){
				result[i]="FizzBuzz";
			}
			else if(i%3==0){
				result[i]="Fizz";
			}
			else if(i%5==0){
				result[i]="Buzz";
			}
			else{
				result[i]=i.ToString();
			}
		}
		Console.WriteLine("FizzBuzz Output: ");
		for(int i=1;i<=number;i++){
			Console.WriteLine($"Position {i} = {result[i]}");
		}
	}
}
