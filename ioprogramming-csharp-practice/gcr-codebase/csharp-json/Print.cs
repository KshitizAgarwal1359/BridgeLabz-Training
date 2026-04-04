using Newtonsoft.Json.Linq;
using System;
class Program
{
    static void Main()
    {
        JObject obj = JObject.Parse(@"{ 'id':1, 'name':'Test' }");
        foreach (var p in obj.Properties())
            System.Console.WriteLine($"{p.Name} : {p.Value}");
    }
}
