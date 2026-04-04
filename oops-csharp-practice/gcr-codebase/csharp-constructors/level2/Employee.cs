using System;
class Employee
{
    public int employID; //public
    protected string department; //protected
    private double salary; //protected
    public Employee(int empID,string dept,double sal)
    {
        employID=empID;
        department=dept;
        salary=sal;
    }
    public double GetSalary() //method to get salary
    {
        return salary;
    }
    public void SetSalary(double newSalary)
    {
        if (newSalary > 0)
        {
            salary=newSalary;
        }
        else
        Console.WriteLine("Invalid Salary.");
    }
}
class Manager : Employee //subclass
{
    public string designation;
    public Manager(int empID,string dept,double sal,string desi) : base(empID, dept, sal)
    {
        designation=desi;
    }
    public void Display()
    {
        Console.WriteLine($"Employee ID: "+employID);
        Console.WriteLine($"$Department : {department}");
        Console.WriteLine($"Designation "+designation);
        Console.WriteLine($"salary : {GetSalary()}\n");
    }
}
class EmployeeRecord
{
    public static void Main(String[] args)
    {
        Manager mr = new Manager(567,"Development",35000,"Intern"); //constructor
        mr.Display();
        mr.SetSalary(100000);
        Console.WriteLine("Updated salary: "+mr.GetSalary());
    }
}
