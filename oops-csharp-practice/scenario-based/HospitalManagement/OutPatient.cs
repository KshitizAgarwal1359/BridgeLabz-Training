using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.HospitalManagement
{
    public  class OutPatient : Patient
    {
        public string visitDate {  get; set; }
        public OutPatient(string Name,int Age,string Disease,string VisitDate) : base(Name, Age, Disease)
        {
            this.visitDate= VisitDate;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"[OutPatient] {name}, Age: {age}, Disease: {disease}, Visit Date: {visitDate}");
        }

    }
}
