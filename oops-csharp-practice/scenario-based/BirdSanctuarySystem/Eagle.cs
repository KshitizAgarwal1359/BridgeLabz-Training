using System; //derived class
public class Eagle : Bird, IFlyable //eagle inherits common attributes of bird and IFlyable
{
    public Eagle(string name) : base(name, "Eagle") { }
    public void Fly()
    {
        Console.WriteLine($"{name} is flying high in the sky.");
    }

}