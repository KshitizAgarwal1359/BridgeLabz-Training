using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Employee_Wage_Calculation
{
    enum EmployeeType
    {
        FULL_TIME=1,
        PART_TIME=2
    }
    class Employee
    {
        public int employeeId { get; set; }
        public string employeeName { get; set; }
        public double hourlyRate { get; set; }
        public EmployeeType EmployeeType { get; set; }
        public void AddEmployee()
        {
            Console.Write("Enetr employee id: ");
            employeeId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name: ");
            employeeName = Console.ReadLine();
            Console.WriteLine("Select Employee Type: 1. Full Time  2. Part Time");
            EmployeeType = (EmployeeType)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEmployee details added successfully.\n");
        }
    }
}
