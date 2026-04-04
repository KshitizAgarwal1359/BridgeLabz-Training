using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.HospitalManagement
{
    public  class PatientServiceImpl
    {
        public void HandlePatient()
        {
            Console.WriteLine("Enter your name: ");
            string patientName = Console.ReadLine();
            Console.WriteLine("Enter patient age: ");
            int patientAge = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter disease: ");
            string Disease = Console.ReadLine();
            Patient patient = new OutPatient(patientName,patientAge,Disease,DateTime.Now.ToShortDateString());
            patient.DisplayInfo();
            Bill bill = new Bill
            {
                patientName = patientName,
                doctorName = "Dr. Kukreja",
                disease = Disease,
                prescription = "Paracetamol+Rest",
                nextAppointmentDate = DateTime.Now.AddDays(7).ToShortDateString(),
            };
            bill.DisplayBill();
        }
    }
}
