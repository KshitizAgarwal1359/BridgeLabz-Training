using System;

class Employee
{
    public static string CompanyName = "TechBridge Pvt Ltd"; // static variable (shared by all employees)
    private static int totalEmployees = 0;
    public readonly int Id;  // readonly variable (cannot be changed after initialization)
    public string Name; // instance variables
    public string Designation;
    public Employee(string Name, int Id, string Designation) // Constructor using 'this' keyword
    {
        this.Name = Name;
        this.Id = Id;
        this.Designation = Designation;
        totalEmployees++;
    }
    public static void DisplayTotalEmployees() // static method to display total employees
    {
        Console.WriteLine("Total Employees: " + totalEmployees);
        Console.WriteLine();
    }
    public void DisplayEmployeeDetails(object obj) // Method using 'is' operator for safe type checking
    {
        if (obj is Employee)
        {
            Console.WriteLine("Company Name: " + CompanyName);
            Console.WriteLine("Employee ID : " + Id);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Designation : " + Designation);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Invalid employee object");
        }
    }
}
// Main class
class EmployeeSystem
{
    static void Main(string[] args)
    {
        Employee e1 = new Employee("Kshitiz", 101, "Software Engineer");
        Employee e2 = new Employee("Aman", 102, "QA Analyst");
        e1.DisplayEmployeeDetails(e1);
        e2.DisplayEmployeeDetails(e2);
        Employee.DisplayTotalEmployees();
    }
}
