using Newtonsoft.Json;
using System;
class Program
{
    static void Main()
    {
        var student = new
        {
            name = "Kshitiz Agarwal",
            age = 22,
            subjects = new[] { "Maths", "Physics", "CS" }
        };
        string json = JsonConvert.SerializeObject(student, Formatting.Indented);
        System.Console.WriteLine(json);
    }
}
