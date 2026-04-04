using System;
using System.Collections.Generic;
interface IDepartment //defines department related behavior
{
    void AssignDepartment(string departmentName);
    string GetDepartmentDetails();
}
abstract class Employee //abstract base class for all employees
{
    private int employeeId; //private fields (Encapsulation)
    private string name;
    protected double baseSalary;

    public int EmployeeId
    {
        get{return employeeId;}
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Employee Id must be positive.");}
                employeeId=value;
            
        }
    }
    public string Name
    {
        get{return name;}
        private set
        {
            if(string.IsNullOrWhiteSpace(value))
            throw new ArgumentException("Name cannot be empty");
            name=value;
        }
    }
    protected Employee(int employeeId,string name,double baseSalary) //constructor
    {
        EmployeeId=employeeId;
        Name=name;
        this.baseSalary=baseSalary;
    }
    public abstract double CalculateSalary();
    public virtual void DisplayDetails()
    {
        Console.WriteLine($"ID: {EmployeeId}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Salary: {CalculateSalary()}");
    }
}
class FullTimeEmployee : Employee, IDepartment
{
    private string department;
    public FullTimeEmployee(int id,string name,double fixedSalary) : base(id,name,fixedSalary){}
    public override double CalculateSalary()
    {
        return baseSalary; //fixed monthly salary
    }
    public void AssignDepartment(string departmentName)
    {
        department=departmentName;
    }
    public string GetDepartmentDetails()
    {
        return department;
    }
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Department: {department}");
        Console.WriteLine($"Employee type: Full-Time\n");
    }
}
class PartTimeEmployee : Employee, IDepartment
{
    private int hoursWorked;
    private double hourlyRate;
    private string department;
    public PartTimeEmployee(int id,string name,int hoursWorked,double hourlyRate) : base(id, name, 0)
    {
        this.hoursWorked=hoursWorked;
        this.hourlyRate=hourlyRate;
    }
    public void AssignDepartment(string departmentName)
    {
        department=departmentName;
    }
    public string GetDepartmentDetails()
    {
        return department;
    }
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Department: {department}");
        Console.WriteLine($"Employee Type: Part-Time\n");
    }
    public override double CalculateSalary()
    {
        return hoursWorked*hourlyRate;
    }
}
class EmployeeManagement
{
    public static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>();
        Employee employee1= new FullTimeEmployee(106,"Kshitiz",56000);
        Employee employee2 =new PartTimeEmployee(345,"Ramesh",345,300);
        ((IDepartment)employee1).AssignDepartment("ITR");
        ((IDepartment)employee2).AssignDepartment("Help Desk");
        employees.Add(employee1);
        employees.Add(employee2);
        foreach(Employee emp in employees)
        {
            emp.DisplayDetails();
        }
    }
}
