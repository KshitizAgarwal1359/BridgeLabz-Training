using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.CustomerService
{
    public  class CallLogManager //manages all call log operations
    {
        private CallLog[] logs;
        private int count;
        public CallLogManager(int size)
        {
            logs = new CallLog[size];
            count = 0;
        }
        public void AddCallLog(string phoneNumber,string message) //adds new call log in array
        {
            if (count >= logs.Length)
            {
                Console.WriteLine("Log storage is full.");
                return;
            }
            logs[count] = new CallLog(phoneNumber, message, DateTime.Now);
            count++;
            Console.WriteLine("call log added.");
        }
        public void SearchByKeyword(string keyword) //search meesage by keyword
        {
            Console.WriteLine($"Searching logs for keyword: '{keyword}'");
            bool found = false;
            for(int i = 0; i < count; i++)
            {
                if (logs[i].message.Contains(keyword, StringComparison.OrdinalIgnoreCase))
                {
                    logs[i].Display();
                    found = true;
                }
            }
            if (!true)
            {
                Console.WriteLine("No logs for given keyword.");
            }
        }
        public void FilterByTime(DateTime startTime,DateTime endTime) //filter logs with start and end time
        {
            Console.WriteLine($"logs b/w {startTime} and {endTime}");
            bool found = false;
            for(int i = 0; i < count; i++)
            {
                if (logs[i].timeStamp>=startTime && logs[i].timeStamp <= endTime)
                {
                    logs[i].Display();
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("No logs in the given time range.");
            }
        }
    }
}
