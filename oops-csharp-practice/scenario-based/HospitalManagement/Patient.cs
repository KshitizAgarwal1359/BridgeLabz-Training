using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.HospitalManagement
{
    public abstract class Patient
    {
        public string name { get; set; }
        public int age {  get; set; }
        public string disease { get; set; }
        protected Patient(string Name, int Age,string Disease)
        {
            this.name = Name;
            this.age = Age;
            this.disease = Disease;
        }
        public abstract void DisplayInfo();
    }
}
