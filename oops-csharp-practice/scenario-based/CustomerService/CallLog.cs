using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.CustomerService
{
    public class CallLog //showss a single call log entry
    {
            public string phoneNumber {  get; set; }
            public string message { get; set; }
            public DateTime timeStamp { get; set; }

        public CallLog(string PhoneNumber,string Message,DateTime TimeStamp) //constructor intialization  
        {
            phoneNumber = PhoneNumber;
            message = Message;
            timeStamp= TimeStamp;
        }
        public void Display() //dispaly information
        {
            Console.WriteLine($"Phone: {phoneNumber}, Time: {timeStamp}, Message: {message}");
        }
    }
}
