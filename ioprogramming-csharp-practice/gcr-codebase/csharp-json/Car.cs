using Newtonsoft.Json;
using System;
class Car
{
    public string Brand { get; set; }
    public int Year { get; set; }
}
class Program
{
    static void Main()
    {
        Car car = new Car { Brand = "Toyota", Year = 2022 };
        string json = JsonConvert.SerializeObject(car);
        System.Console.WriteLine(json);
    }
}
