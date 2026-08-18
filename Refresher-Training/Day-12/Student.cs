using System;
class Student
{
    public string Name{get; set;}
    public int RollNumber{get; set;}
    public int Marks{get; set;}
    public Student(string name,int rollNumber,int marks)
    {
        Name=name;
        RollNumber=rollNumber;
        Marks=marks;
    }
    public char CalculateGrade()
    {
        if (Marks >= 90)
        {
            return 'A';
        }
        else if(Marks>=80)
        return 'B';
        else if(Marks>=70)
        return 'C';
        else if(Marks>=60)
        return 'D';
        else
        return 'F';
    }
    public void DisplayDetails()
    {
        Console.WriteLine("Name: "+ Name);
        Console.WriteLine("Roll Number: "+RollNumber);
        Console.WriteLine("Marks: "+Marks);
        Console.WriteLine("Grade: "+CalculateGrade());
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the no of students: ");
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            Console.Write("enter name: ");
            string name = Console.ReadLine();
            Console.Write("Enter roll number: ");
            int roll = int.Parse(Console.ReadLine());
            Console.Write("enter marks: ");
            int marks = int.Parse(Console.ReadLine());
            Student student = new Student(name,roll,marks);
            Console.WriteLine("\nStudent Details: ");
            student.DisplayDetails();
        }
    }
}