using System;
class Employee
{
    public string Name{get; set;}
    public double Salary{get; set;}
    public Employee(string name,double salary)
    {
        Name=name;
        Salary=salary;
    }
    public virtual double CalculateSalary()
    {
        return Salary;
    }
}
class Developer : Employee
{
    public Developer(string name,double salary) : base(name,salary){}
    public override double CalculateSalary()
    {
        return Salary + (Salary*0.20);
    }
}
class Manager : Employee
{
    public Manager(string name,double salary) : base(name,salary){}
    public override double CalculateSalary()
    {
        return Salary + (Salary*0.30);
    }
}
class Program
{
    static void Main(string[] args)
    {
        string[] input1 = Console.ReadLine().Split();
        string[] input2 = Console.ReadLine().Split();
        Employee employee1;
        if (input1[0] == "Developer")
        {
            employee1= new Developer(input1[1],double.Parse(input1[2]));
        }
        else
        {
            employee1=new Manager(input1[1],double.Parse(input1[2]));
        }
        Employee employee2;
        if (input2[0] == "Developer")
        {
            employee2= new Developer(input2[1],double.Parse(input2[2]));
        }
        else
        {
            employee2=new Manager(input2[1],double.Parse(input2[2]));
        }
        Console.WriteLine(employee1.Name+": "+employee1.CalculateSalary());
        Console.WriteLine(employee2.Name+": "+employee2.CalculateSalary());
    }
}