using Newtonsoft.Json;
using System.Collections.Generic;
using System;
class Program
{
    static void Main()
    {
        var dbData = new List<object> {
            new { Id=1, Name="User1" },
            new { Id=2, Name="User2" }
        };
        System.Console.WriteLine(JsonConvert.SerializeObject(dbData));
    }
}
