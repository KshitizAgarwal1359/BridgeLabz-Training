using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        for(int i = 0; i < n; i++)
        {
            string ip = Console.ReadLine();
            if (IsIPv4(ip))
            {
                Console.WriteLine("IPv4");
            }
            else if(IsIPv6(ip))
            Console.WriteLine("IPv6");
            else
            Console.WriteLine("neither");
        }
    }
    static bool IsIPv4(string ip)
    {
        string pattern=@"^(\d{1,3}\.){3}\d{1,3}$";
        if(!Regex.IsMatch(ip,pattern))
        return false;
        string[] parts = ip.Split('.');
        foreach(string part in parts)
        {
            int number = int.Parse(part);
            if(number<0||number>255)
            return false;
        }
        return true;
    }
        static bool IsIPv6(string ip)
    {
        string pattern = @"^([0-9a-fA-F]{1,4}:){7}[0-9a-fA-F]{1,4}$";
        return Regex.IsMatch(ip, pattern);
    }
}
