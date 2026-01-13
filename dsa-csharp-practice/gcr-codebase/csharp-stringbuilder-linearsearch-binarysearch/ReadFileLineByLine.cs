using System;
using System.IO;

class ReadFileLineByLine
{
    static void Main()
    {
        string filePath = "sample.txt"; // Ensure file exists in project folder

        try
        {
            // Using ensures the file is closed properly
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;

                // Read file line by line
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Error: File not found.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("I/O Error: " + ex.Message);
        }
    }
}
