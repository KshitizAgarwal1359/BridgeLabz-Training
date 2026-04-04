//derived class
public class Sparrow : Bird, IFlyable //sparrow inherits bird and iflyable
{
    public Sparrow(string name) : base(name, "Sparrow") { }
    public void Fly()
    {
        Console.WriteLine($"{name} is flies b/w trees");
    }
}