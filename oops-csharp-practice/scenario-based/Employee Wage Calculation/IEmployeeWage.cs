using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Employee_Wage_Calculation
{
    interface IEmployeeWage
    {
        void CalculateDailyWage(Employee employee, int attendanceStatus);
    }
}
