using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.HospitalManagement
{
    public sealed class Bill : IPayable
    {
        public static double consultationFees = 450;
        public string patientName {  get; set; }
        public string doctorName { get; set; }
        public string disease {  get; set; }
        public string prescription { get; set; }
        public string nextAppointmentDate { get; set; }
        public double CalculateBill()
        {
            return consultationFees; 
        }
        public void DisplayBill()
        {
            Console.WriteLine($"Patient Name: {patientName}");
            Console.WriteLine($"Doctor Name: {doctorName}");
            Console.WriteLine($"Disease: {disease}");
            Console.WriteLine($"Prescription: {prescription}");
            Console.WriteLine($"Next Appointment Date: {nextAppointmentDate}");
            Console.WriteLine($"Total Amount: {CalculateBill()}");
        }
    }
}
