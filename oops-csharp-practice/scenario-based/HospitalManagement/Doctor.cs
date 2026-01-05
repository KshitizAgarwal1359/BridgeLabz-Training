using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.HospitalManagement
{
    public  class Doctor
    {
        public string name {  get; set; }
        public string specialization { get; set; }
        public Doctor(string Name,string Specialization)
        {
            this.name = Name;
            this.specialization = Specialization;
        }
        
    }
}
