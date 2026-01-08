using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Employee_Wage_Calculation
{
    interface IEmployee
    {
        // UC1
        int CheckAttendance(Employee employee);

        // UC2
        void CalculateDailyWage(Employee employee, int attendance);

        // UC3
        void CalculatePartTimeWage(Employee employee, int attendance);

        // UC4
        void CalculateWageUsingSwitch(Employee employee, int attendance);

        // UC5
        void CalculateMonthlyWage(Employee employee);

        // UC6
        void CalculateWageTillCondition(Employee employee);
    }
}
