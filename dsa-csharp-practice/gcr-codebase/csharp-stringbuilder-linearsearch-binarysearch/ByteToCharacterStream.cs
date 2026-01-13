using System;
using System.IO;
using System.Text;

class ByteToCharacterStream
{
    static void Main()
    {
        string filePath = "binarydata.dat"; // File containing byte data
        try
        {
            // Open file as byte stream
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                // Convert byte stream to character stream using encoding
                using (StreamReader reader = new StreamReader(fileStream, Encoding.UTF8))
                {
                    int character;
                    // Read character by character
                    while ((character = reader.Read()) != -1)
                    {
                        Console.Write((char)character);
                    }
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
