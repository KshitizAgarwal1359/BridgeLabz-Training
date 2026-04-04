using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.HospitalManagement
{
    public  class MenuServiceImpl
    {
        public void ShowMenu()
        {
            Console.WriteLine("=============Hospital Management===============");
            Console.WriteLine("1. Doctor Login");
            Console.WriteLine("2. Patient login");
            Console.WriteLine("3. Exit.");
            Console.Write("Choose one option: ");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    DoctorServiceImpl doctorService = new DoctorServiceImpl();
                    if (doctorService.Authenticate())
                        Console.WriteLine("Doctor login successfull");
                    else
                        Console.WriteLine("Invalid credentials.");
                    break;
                    case "2":
                    PatientServiceImpl patientService = new PatientServiceImpl();
                    patientService.HandlePatient();
                    break;
                    case "3":
                    Console.WriteLine("Thank you.");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    return;
            }
        }
    }
}
