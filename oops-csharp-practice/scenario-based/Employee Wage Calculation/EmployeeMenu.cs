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

            // Interface reference
            IEmployee employeeService = new EmployeeUtilityImpl();

            int attendance = employeeService.CheckAttendance(employee);

            employeeService.CalculateDailyWage(employee, attendance);
            employeeService.CalculatePartTimeWage(employee, attendance);
            employeeService.CalculateWageUsingSwitch(employee, attendance);
            employeeService.CalculateMonthlyWage(employee);
            employeeService.CalculateWageTillCondition(employee);
        }
    }
}
