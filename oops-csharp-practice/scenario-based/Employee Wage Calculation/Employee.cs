using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Employee_Wage_Calculation
{
    class Employee
    {
        public int employeeId { get; set; }
        public string employeeName { get; set; }
        public double hourlyRate { get; set; }
        public void AddEmployee()
        {
            Console.Write("Enetr employee id: ");
            employeeId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name: ");
            employeeName = Console.ReadLine();
            Console.Write("Enter Hourly Rate: ");
            hourlyRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\nEmployee details added successfully.\n");
        }
    }
}
