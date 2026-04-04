using System;
class StudentGradeCalculator{
    public static void Main(string[] args){
        // Take input for number of students
        Console.Write("Enter number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());
        // Arrays to store marks, percentage, and grade
        int[] physics = new int[numberOfStudents];
        int[] chemistry = new int[numberOfStudents];
        int[] maths = new int[numberOfStudents];
        double[] percentage = new double[numberOfStudents];
        char[] grade = new char[numberOfStudents];
        // Taking marks input
        for(int i=0;i<numberOfStudents;i++){
            Console.WriteLine("Enter marks for Student " +(i+1));
            Console.Write("Physics: ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Chemistry: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Maths: ");
            int m = Convert.ToInt32(Console.ReadLine());
            // Validate marks
            if(p<0 || c<0|| m<0){
                Console.WriteLine("Marks cannot be negative. Please enter again.");
                i--; // decrement index to retry same student
                continue;
            }
            physics[i] = p;
            chemistry[i] = c;
            maths[i] = m;
        }
        // Calculate percentage and grade
        for (int i=0;i<numberOfStudents;i++){
            percentage[i] = (physics[i]+chemistry[i]+maths[i])/3.0;
            if(percentage[i]>=80)
                grade[i] = 'A';
            else if(percentage[i]>=70)
                grade[i] = 'B';
            else if(percentage[i]>=60)
                grade[i] = 'C';
            else if (percentage[i]>=50)
                grade[i] = 'D';
            else if (percentage[i]>=40)
                grade[i] = 'E';
            else
                grade[i] = 'R';
        }
        // Display result
        Console.WriteLine("Student Repor");
        for (int i=0;i<numberOfStudents;i++){
            Console.WriteLine("Student " +(i+1));
            Console.WriteLine("Physics: " +physics[i]);
            Console.WriteLine("Chemistry: " +chemistry[i]);
            Console.WriteLine("Maths: " +maths[i]);
            Console.WriteLine("Percentage: " +percentage[i]);
            Console.WriteLine("Grade: " +grade[i]);
            Console.WriteLine();
        }
    }
}

