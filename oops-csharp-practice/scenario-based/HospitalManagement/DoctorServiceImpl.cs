using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.HospitalManagement
{
    public  class DoctorServiceImpl
    {
        private const string doctorPassword = "doc.octopus@123";
        public bool Authenticate()
        {
            Console.WriteLine("Enter the doctor password: ");
            string input = Console.ReadLine();
            return input==doctorPassword;
        }
    }
}
