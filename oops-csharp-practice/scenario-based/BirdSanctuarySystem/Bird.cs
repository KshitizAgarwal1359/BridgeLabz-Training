using System; //base class having birds containing common attributes
public abstract class Bird
{
    protected string name;
    protected string species;
    public Bird(string name, string species) //constructor intialization for bird
    {
        this.name = name;
        this.species = species; 
    }
    public virtual void DisplayInfo() //virtual method to display bird info
    {
        Console.WriteLine($"Bird name: {name}, Species: {species}");
    }
}