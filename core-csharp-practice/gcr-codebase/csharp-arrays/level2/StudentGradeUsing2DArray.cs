using System;
class StudentGradeUsing2DArray{
    public static void Main(string[] args){
        // Take input for number of students
        Console.Write("Enter number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());
        int[,] marks = new int[numberOfStudents, 3];
        double[] percentage = new double[numberOfStudents];
        char[] grade = new char[numberOfStudents];
        // Take marks input
        for(int i=0;i<numberOfStudents;i++){
            Console.WriteLine("Enter marks for Student " +(i+1));
            Console.Write("Physics: ");
            int p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Chemistry: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Maths: ");
            int m = Convert.ToInt32(Console.ReadLine());
            // Validate marks
            if(p<0 || c<0 || m<0){
                Console.WriteLine("Marks cannot be negative. Please enter again.");
                i--; // retry same student
                continue;
            }
            marks[i, 0] = p;
            marks[i, 1] = c;
            marks[i, 2] = m;
        }
        // Calculate percentage and grade using 2D array
        for(int i=0;i<numberOfStudents;i++){
            int total = marks[i,0] + marks[i,1] + marks[i,2];
            percentage[i] = total/3.0;

            if(percentage[i]>=80)
                grade[i] = 'A';
            else if(percentage[i]>=70)
                grade[i] = 'B';
            else if(percentage[i]>=60)
                grade[i] = 'C';
            else if(percentage[i]>=50)
                grade[i] = 'D';
            else if(percentage[i]>=40)
                grade[i] = 'E';
            else
                grade[i] = 'R';
        }
        // Display results
        Console.WriteLine("Student Report ");
        for (int i=0;i<numberOfStudents;i++){
            Console.WriteLine("Student " +(i+1));
            Console.WriteLine("Physics: " +marks[i,0]);
            Console.WriteLine("Chemistry: " +marks[i,1]);
            Console.WriteLine("Maths: " + marks[i,2]);
            Console.WriteLine("Percentage: " +percentage[i]);
            Console.WriteLine("Grade: " + grade[i]);
            Console.WriteLine();
        }
    }
}
