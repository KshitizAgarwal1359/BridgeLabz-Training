using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
class Program
{
    public static void Main()
    {
        string schemaJson = @"{'type':'object','properties': {'email': { 'type':'string', 'format':'email' }}}";
        string json = @"{ 'email':'kshitiz@gmail.com' }";
        JSchema schema = JSchema.Parse(schemaJson);
        JObject obj = JObject.Parse(json);
        System.Console.WriteLine(obj.IsValid(schema));
    }
}
