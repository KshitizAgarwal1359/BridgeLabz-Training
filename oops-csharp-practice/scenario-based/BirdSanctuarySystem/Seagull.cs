using System; //seagull can both fly and swim
public class Seagull: Bird, IFlyable, ISwimmable
{
    public Seagull(string name) : base(name, "Seagull") { }
    public void Swim()
    {
        Console.WriteLine($"{name} can fly in the sky");
    }
    public void Fly()
    {
        Console.WriteLine($"{name} can also swim in ocean seawater.");
    }
}