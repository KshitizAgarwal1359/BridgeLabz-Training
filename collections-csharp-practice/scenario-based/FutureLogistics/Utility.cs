using System;
using System.Text.RegularExpressions;
//utility class for validation and object creation
public class Utility
{
    //validates transportId format (RTS + 3 digits + uppercase letter)
    public bool validateTransportId(string transportId)
    {
        return Regex.IsMatch(transportId, "^RTS[0-9]{3}[A-Z]$");
    }
    //parses input string and returns appropriate GoodsTransport object
    public GoodsTransport parseDetails(string input)
    {
        string[] data = input.Split(':');
        //validate transportId before processing
        if (!validateTransportId(data[0]))
        {
            Console.WriteLine($"Transport id {data[0]} is invalid");
            Console.WriteLine("Please provide a valid record");
            Environment.Exit(0);
        }
        //create BrickTransport object
        if (data[3].Equals("BrickTransport", StringComparison.OrdinalIgnoreCase))
        {
            return new BrickTransport(
                data[0], data[1], int.Parse(data[2]),
                float.Parse(data[4]), int.Parse(data[5]), float.Parse(data[6])
            );
        }
        //create TimberTransport object
        return new TimberTransport(
            data[0], data[1], int.Parse(data[2]),
            float.Parse(data[4]), float.Parse(data[5]),
            data[6], float.Parse(data[7])
        );
    }
    //identifies transport object type
    public string findObjectType(GoodsTransport gt)
    {
        return gt is TimberTransport ? "TimberTransport" : "BrickTransport";
    }
}
