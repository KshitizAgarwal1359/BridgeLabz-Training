using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.HospitalManagement
{
    public  class InPatient : Patient
    {
        public int daysAdmitted { get; set; }
        public InPatient(string Name,int Age,string Disease,int DaysAdmitted) : base(Name, Age, Disease)
        {
            this.daysAdmitted = DaysAdmitted;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"[InPatient] {name}, Age: {age}, Disease: {disease}, Days Admitted: {daysAdmitted}");
        }
    }
}
