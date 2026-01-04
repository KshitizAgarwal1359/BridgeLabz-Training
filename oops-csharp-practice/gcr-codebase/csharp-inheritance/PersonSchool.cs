using System;
class PersonSchool{ // Superclass
    public string Name;
    public int Age;
    public PersonSchool(string name, int age){
    Name = name;
    Age = age;
        }
    public void DisplayDetails(){
    Console.WriteLine("Name: " + Name);
    Console.WriteLine("Age: " + Age);
    }
}
class Teacher : PersonSchool{ // Subclass 1 — Teacher
    public string Subject;
    public Teacher(string name, int age,string subject): base(name, age){
    Subject = subject;
    }
    public void DisplayRole(){
    Console.WriteLine("\nRole: Teacher");
    DisplayDetails();
    Console.WriteLine("Subject: " + Subject);
    }
}
class Student : PersonSchool{ // Subclass 2 — Student
    public string Grade;
    public Student(string name, int age, string grade): base(name, age){
    Grade = grade;
    }
    public void DisplayRole(){
    Console.WriteLine("\nRole: Student");
    DisplayDetails();
    Console.WriteLine("Grade: " + Grade);
    }
}
class Staff : PersonSchool{ // Subclass 3 — Staff
    public string Department;
    public Staff(string name, int age, string department): base(name, age){
    Department = department;
    }
     public void DisplayRole(){
    Console.WriteLine("\nRole: Staff");
    DisplayDetails();
    Console.WriteLine("Department: " + Department);
    }
}
class SchoolSystem{ // Main Class
    public static void Main(string[] args){
    Teacher t1 = new Teacher("Kshitiz", 26, "Science");
    Student s1 = new Student("Kshitiz", 33, "10th Grade");
    Staff st1 = new Staff("Aman", 56, "Administration");
    t1.DisplayRole();
    s1.DisplayRole();
    st1.DisplayRole();
    }
}