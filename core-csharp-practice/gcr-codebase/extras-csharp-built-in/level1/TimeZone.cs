//Problem 1: Time Zones and DateTimeOffset
using System;
class TimeZone{
    public static void Main(string[] args){
    DateTimeOffset utcTime = DateTimeOffset.UtcNow;      // Get current UTC time
    Console.WriteLine("Current UTC Time: " + utcTime);
    TimeZoneInfo gmtZone = TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time");        // GMT (Greenwich Mean Time)
    DateTimeOffset gmtTime = TimeZoneInfo.ConvertTime(utcTime, gmtZone);
    Console.WriteLine("GMT Time: " + gmtTime);
    TimeZoneInfo istZone = TimeZoneInfo.FindSystemTimeZoneById("India Standard Time");      // IST (Indian Standard Time)
    DateTimeOffset istTime = TimeZoneInfo.ConvertTime(utcTime, istZone);     // IST (Indian Standard Time)
    Console.WriteLine("IST Time: " + istTime);
    TimeZoneInfo pstZone = TimeZoneInfo.FindSystemTimeZoneById("Pacific Standard Time");   // PST (Pacific Standard Time)
    DateTimeOffset pstTime = TimeZoneInfo.ConvertTime(utcTime, pstZone); // PST (Pacific Standard Time)
    Console.WriteLine("PST Time: " + pstTime);
}
}