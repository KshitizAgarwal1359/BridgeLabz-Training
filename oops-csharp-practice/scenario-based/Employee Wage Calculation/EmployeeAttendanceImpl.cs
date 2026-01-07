using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Employee_Wage_Calculation
{
    class EmployeeAttendanceImpl : IEmployeeAttendance
    {
        public int AttendanceStatus { get; set; }
        //UC1: this version check employee presence or absence
        public void CheckEmployeeAttendance(Employee employee) {
            AttendanceStatus = EmployeeUtility.GetAttendance();
            if(AttendanceStatus == EmployeeUtility.IS_PRESENT)
            {
                Console.WriteLine($"Employee {employee.employeeName} is present");
            }
            else
            {
                Console.WriteLine($"Employee {employee.employeeName} is absent");
            }
        }
    }
}
