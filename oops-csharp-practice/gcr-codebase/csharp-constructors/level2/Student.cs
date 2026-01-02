using System;
class Student //base class
{
    public int rollNumber; //public
    protected string name; //protected
    private double cgpa; //private
    public Student(int roll,string n,double cpi)//constructor
    {
        rollNumber=roll;
        name=n;
        cgpa=cpi;
    }
    public double GetCgpa() //public method to get cgpa
    {
        return cgpa;
    }
    public void SetCgpa(double newCgpa) //public method to set cgpa
    {
        if(newCgpa>0 && newCgpa <= 10)
        {
            cgpa=newCgpa;
        }
        else
        {
            Console.WriteLine("Invalid Cgpa");
        }
    }
}
class PostgraduateStudent : Student //subclass
{
    public string specialization;
    public PostgraduateStudent(int roll,string n,double cpi,string special) : base(roll, n, cpi)
    {
        specialization=special;
    }
    public void DisplayPGStudent()
    {
        Console.WriteLine("Roll Number : " + rollNumber);
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Cgpa : " + GetCgpa()); //access by public method
        Console.WriteLine("Specialization : " + specialization);
    }
}
class Management //main class
{
    public static void Main(String[] args)
    {
        PostgraduateStudent pg = new PostgraduateStudent(221500,"Kshitiz",7.5,"Computer Science");
        pg.DisplayPGStudent();
        pg.SetCgpa(7.8);
        Console.WriteLine("updated cgpa: "+pg.GetCgpa());
    }
}