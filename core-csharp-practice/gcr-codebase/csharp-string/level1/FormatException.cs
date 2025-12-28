using System;
class FormatException
{
    public static void Main(String[] args)
    {
        string input = "Kshitiz";
        try
        {
            int number = int.Parse(input);
            Console.WriteLine(number);
        }
        catch(System.FormatException ex)
        {
            Console.WriteLine("FormatException found");
            Console.WriteLine(ex.Message);
        }
    }
}