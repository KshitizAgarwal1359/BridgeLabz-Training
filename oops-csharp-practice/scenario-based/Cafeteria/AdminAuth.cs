using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Cafeteria
{
    internal class AdminAuth   //admin authentication method
    {
        public string adminKey = "admin123";
        public bool Login()
        {
            Console.WriteLine("Enter Admin Passkey: ");
            return Console.ReadLine() == adminKey;
        }
    }
}
