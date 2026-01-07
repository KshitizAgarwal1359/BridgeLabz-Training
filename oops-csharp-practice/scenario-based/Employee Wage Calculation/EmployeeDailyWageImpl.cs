using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Employee_Wage_Calculation
{
    class EmployeeDailyWageImpl : IEmployeeWage
    {
        //UC2 : calculate employee daily wage 
        //wage per hour is fixed as 20
        //full day working hours are 8
        //calculated only if employee is present
        public void CalculateDailyWage(Employee employee,int attendanceStatus)
        {
            if (attendanceStatus == EmployeeUtility.IS_PRESENT)
            {
                int dailyWage = EmployeeUtility.WAGE_PER_HOUR * EmployeeUtility.FULL_DAY_HOURS;
                Console.WriteLine($"Daily wage of {employee.employeeName} is {dailyWage}");
            }
            else
            {
                Console.WriteLine($"Employee {employee.employeeName} is absent");
            }
        }
    }
}
