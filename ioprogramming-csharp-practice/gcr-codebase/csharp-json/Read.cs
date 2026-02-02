using Newtonsoft.Json.Linq;
using System;
class Program
{
    public static void Main()
    {
        string json = @"{ 'name':'Ravi', 'email':'ravi@gmail.com', 'age':30 }";
        JObject obj = JObject.Parse(json);
        System.Console.WriteLine(obj["name"]);
        System.Console.WriteLine(obj["email"]);
    }
}
