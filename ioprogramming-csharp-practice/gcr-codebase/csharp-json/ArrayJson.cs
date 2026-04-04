using Newtonsoft.Json;
using System.Collections.Generic;
using System;
class Program
{
    static void Main()
    {
        var list = new List<string> { "A", "B", "C" };
        string json = JsonConvert.SerializeObject(list);
        System.Console.WriteLine(json);
    }
}
