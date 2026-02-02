using Newtonsoft.Json;
using System.Collections.Generic;
using System;
class Program
{
    public static void Main(String[] args)
    {
        var nums = new List<int> { 1, 2, 3 };
        System.Console.WriteLine(JsonConvert.SerializeObject(nums));
    }
}
