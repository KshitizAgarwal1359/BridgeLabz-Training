using Newtonsoft.Json.Linq;
using System;
class Program
{
    public static void Main()
    {
        JObject j1 = JObject.Parse(@"{ 'name':'Kshitiz' }");
        JObject j2 = JObject.Parse(@"{ 'age':22 }");
        j1.Merge(j2);
        System.Console.WriteLine(j1);
    }
}
