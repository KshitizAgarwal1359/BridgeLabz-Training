using System;
using Newtonsoft.Json;
using System;
class Program
{
    static void Main()
    {
        string[] csv = { "id,name", "1,Kshitiz", "2,Aman" };
        var list = new[] {
            new { id = 1, name = "Kshitiz" },
            new { id = 2, name = "Aman" }
        };
        Console.WriteLine(JsonConvert.SerializeObject(list));
    }
}
