using System;
class Person
{
    public string name;
    public int age;
    public Person(string n,int a) //parameterized constr.
    {
        name = n;
        age =a;
    }
    public Person(Person p) //copy constructor
    {
        name=p.name;
        age=p.age;
    }
    public void Display()
    {
        Console.WriteLine("Name: "+name);
        Console.WriteLine("Age: "+age);
        Console.WriteLine();
    }
    public static void Main(String[] args)
    {
        Person p = new Person("Kshitiz",22);
        p.Display();
        Person p1 = new Person(p);
        p1.Display();
    }

}