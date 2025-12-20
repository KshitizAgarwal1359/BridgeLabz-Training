using System;

// PUBLIC class : accessible everywhere
public class BaseClass
{
    // private  only inside baseClass
    private int privateValue = 10;

    // protected baseClass + derivedClass
    protected int protectedValue = 20;

    // internal same project
    internal int internalValue = 30;

    // public accessible everywhere
    public int publicValue = 40;

    // protected internal same project OR derived class
    protected internal int protectedInternalValue = 50;

    // private protected  same class OR derived class in same project
    private protected int privateProtectedValue = 60;

    // public method to show private & private protected members
    public void PrivateMethod()
    {
        Console.WriteLine("Private Value: " + privateValue);
        Console.WriteLine("Private Protected Value: " + privateProtectedValue);
    }
}

// subclass (same assembly)
public class SubClass : BaseClass
{
    public void ShowAccessibleMembers()
    {
        Console.WriteLine("Protected Value: " + protectedValue);
        Console.WriteLine("Internal Value: " + internalValue);
        Console.WriteLine("Protected Internal Value: " + protectedInternalValue);
        Console.WriteLine("Private Protected Value: " + privateProtectedValue);

        //  privateValue not accessible
    }
}

// main class
class AccessModifier
{
    public static void Main(string[] args)
    {
        BaseClass obj = new BaseClass();

        // Accessible
        Console.WriteLine("Public Value: " + obj.publicValue);
        Console.WriteLine("Internal Value: " + obj.internalValue);
        Console.WriteLine("Protected Internal Value: " + obj.protectedInternalValue);

        // Access via method
        obj.PrivateMethod();

        SubClass subObj = new SubClass();
        subObj.ShowAccessibleMembers();
    }
}
