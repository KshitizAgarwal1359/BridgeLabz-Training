using System;
using System.Security.Cryptography;
class IndexOutOfRange
{
    public static void CauseIndexOutOfRange(string str)
    {
        Console.WriteLine("CAhrater at invalid index: "+str[str.Length]);
    }
    public static void HandleIndexOutOfRange(string str)
    {
        try
        {
            Console.WriteLine("Character at invalid index: "+str[str.Length]);
        }
        catch(IndexOutOfRangeException e)
        {
            Console.WriteLine("Exception caught: IndexOutOfRangeException");
            Console.WriteLine("Message: "+e.Message);
        }
    }
    public static void Main(String[] args)
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        Console.WriteLine("Without exception handling: ");
        try
        {
            CauseIndexOutOfRange(input);
        }
        catch
        {
            Console.WriteLine("Program crashed due to index out of range exception.");
        }
        Console.WriteLine("With Exception Handling");
        HandleIndexOutOfRange(input);
    }
}