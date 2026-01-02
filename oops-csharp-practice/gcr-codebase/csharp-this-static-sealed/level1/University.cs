using System;
class Student
{
    public static string UniversityName = "ABC University";     // static variable (shared by all students)
    private static int totalStudents = 0;
    public readonly int RollNumber;     // readonly variable (cannot be changed after initialization)
    public string Name;     // instance variables
    public string Grade;
    public Student(string Name, int RollNumber, string Grade)     // Constructor using 'this' keyword
    {
        this.Name = Name;
        this.RollNumber = RollNumber;
        this.Grade = Grade;
        totalStudents++;
    }
    public static void DisplayTotalStudents()     // static method to display total students
    {
        Console.WriteLine("Total Students Enrolled: " + totalStudents);
        Console.WriteLine();
    }
    public void UpdateGrade(object obj, string newGrade)     // Method to update grade (with type check)
    {
        if (obj is Student)
        {
            Grade = newGrade;
            Console.WriteLine("Grade updated successfully.\n");
        }
        else
        {
            Console.WriteLine("Invalid student object.\n");
        }
    }
    public void DisplayStudentDetails(object obj) // Method to display student details (with type check)
    {
        if (obj is Student)
        {
            Console.WriteLine("University Name: " + UniversityName);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Roll Number : " + RollNumber);
            Console.WriteLine("Grade : " + Grade);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid student object.\n");
        }
    }
}
// Main class
class UniversitySystem
{
    static void Main(string[] args)
    {
        Student s1 = new Student("Kshitiz", 101, "A");
        Student s2 = new Student("Aman", 102, "B");
        s1.DisplayStudentDetails(s1);
        s2.DisplayStudentDetails(s2);
        // Update grade using is operator check
        s1.UpdateGrade(s1, "A+");
        s1.DisplayStudentDetails(s1);
        Student.DisplayTotalStudents();
    }
}
