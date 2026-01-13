using System;
using System.IO;

class WriteUserInputToFile
{
    static void Main()
    {
        string filePath = "output.txt";
        try
        {
            Console.WriteLine("Enter text to write to the file:");
            string userInput = Console.ReadLine();
            // Write user input to file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(userInput);
            }
            Console.WriteLine("Data written to file successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("I/O Error: " + ex.Message);
        }
    }
}
