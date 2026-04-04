using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.CustomerService
{
    class CallLogService
    {
        public static void Main(String[] args)
        {
            CallLogManager manager = new CallLogManager(10);
            manager.AddCallLog("9856700114", "Isssue of network in my area."); //adding call logs
            manager.AddCallLog("8904566473", "Lets go to park.");
            manager.AddCallLog("7865309876", "Breakout of network");
            manager.SearchByKeyword("network"); // search by keyword
            DateTime startTime = DateTime.Now.AddMinutes(-10);
            DateTime endTime = DateTime.Now;
            manager.FilterByTime(startTime, endTime);
        }
    }
}
