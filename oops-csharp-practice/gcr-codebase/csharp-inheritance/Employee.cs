using System;
class Employee //base class
{
    public string name;
    public int id;
    public double salary;
    public Employee(string Name,int Id,double Salary)
    {
        name = Name;
        id= Id;
        salary=Salary;
    }
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Employee Details: ");
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Id: {id}");
        Console.WriteLine($"Salary: {salary}");
    }
}
class Manager : Employee //manager class
{
    public int teamSize;
    public Manager(string Name,int Id,double Salary,int teamSize) : base(Name, Id, Salary)
    {
        base.DisplayDetails();
        Console.WriteLine($"Team Size: ");
    }
}