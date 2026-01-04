using System;
class Animal // Superclass
{
    public string Name;
    public int Age;
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public virtual void MakeSound()    // Virtual method
    {
        Console.WriteLine("Animal makes a sound");
    }
}
class Dog : Animal // Subclass Dog
{
    public Dog(string name, int age) : base(name, age) { }
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}
class Cat : Animal // Subclass Cat
{
    public Cat(string name, int age) : base(name, age) { }
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }
}
class Bird : Animal // Subclass Bird
{
    public Bird(string name, int age) : base(name, age) { }

    public override void MakeSound()
    {
        Console.WriteLine("Bird chirps");
    }
}
class Program // Main Class
{
    public static void Main(string[] args)
    {
        Animal animal1 = new Dog("Buddy", 3);
        Animal animal2 = new Cat("Whiskers", 2);
        Animal animal3 = new Bird("Tweety", 1);
        animal1.MakeSound();
        animal2.MakeSound();
        animal3.MakeSound();
    }
}
