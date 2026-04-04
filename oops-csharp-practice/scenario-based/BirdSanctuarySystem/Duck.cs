using System; //duck can swim
public class Duck : Bird, ISwimmable
{
    public Duck(string name) : base(name, "Duck") { }
    public void Swim()
    {
        Console.WriteLine($"{name} can swim in pond.");
    }
}