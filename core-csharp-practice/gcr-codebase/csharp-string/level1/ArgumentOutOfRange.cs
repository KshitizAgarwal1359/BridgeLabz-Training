using System;
class ArgumentOutOfRange
{
    public static void DemoArgument(string str,int start,int end)
    {
        try
        {
            string result= str.Substring(start, end-start);
            Console.WriteLine("Substring: "+result);
        }
        catch(ArgumentOutOfRangeException e)
        {
            Console.WriteLine("Exception Caught: Argument out of range exception");
            Console.WriteLine("Message "+e.Message);
        }
    }
    public static void Main(string[] args)
    {
        Console.Write("Enetr a string: ");
        string input=Console.ReadLine();
        Console.Write("enter start index: ");
        int start=int.Parse(Console.ReadLine());
        Console.Write("Enter end index: ");
        int end = int.Parse(Console.ReadLine());
        DemoArgument(input,start,end);
    }
}