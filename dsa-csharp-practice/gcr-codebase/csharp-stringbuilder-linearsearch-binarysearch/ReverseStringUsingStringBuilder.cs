using System;
using System.Text;

class ReverseStringUsingStringBuilder
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();
        // Initialize StringBuilder with known capacity
        StringBuilder reversed = new StringBuilder(input.Length);
        // Append characters from end to start
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed.Append(input[i]);
        }
        Console.WriteLine("Reversed string: " + reversed.ToString());
    }
}
