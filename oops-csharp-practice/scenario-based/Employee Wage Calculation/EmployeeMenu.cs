using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Employee_Wage_Calculation
{
    class EmployeeMenu
    {
        public static void Start()
        {
            Console.WriteLine("Employee Wage Computation Program\n");
            Employee employee = new Employee();
            employee.AddEmployee();
            IEmployeeAttendance attendanceService = new EmployeeAttendanceImpl(); //UC1
            int attendanceStatus = ((EmployeeAttendanceImpl)attendanceService).AttendanceStatus;
            IEmployeeWage wageService = new EmployeeDailyWageImpl();
            wageService.CalculateDailyWage(employee, attendanceStatus);
        }
    }
}
