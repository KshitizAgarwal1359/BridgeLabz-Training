using Newtonsoft.Json;
using System.Xml.Linq;
using System;
class Program
{
    static void Main()
    {
        string json = "{ 'name':'Test','age':25 }";
        XNode xml = JsonConvert.DeserializeXNode(json, "Root");
        System.Console.WriteLine(xml);
    }
}
