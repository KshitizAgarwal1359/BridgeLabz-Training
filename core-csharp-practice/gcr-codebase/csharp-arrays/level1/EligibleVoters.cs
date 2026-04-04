using System;
class EligibleVoters{
	public static void Main(String[] args){
		//making an array of 10 student age for vote eligibility
		int[] ageOfStudents = new int[10];
		Console.WriteLine("Enter the age of students: ");
		for(int i=0;i<ageOfStudents.Length;i++){
			ageOfStudents[i] = Convert.ToInt32(Console.ReadLine());
		}
		for(int j=0;j<ageOfStudents.Length;j++){
			if(ageOfStudents[j]<=0){
				Console.WriteLine("Invalid Age");
			}
			else if(ageOfStudents[j]>=18){
				Console.WriteLine($"the student with age {ageOfStudents[j]} can vote.");
			}
			else{
				Console.WriteLine($"The student with age {ageOfStudents[j]} cannot vote.");
			}
		}
	}
}
