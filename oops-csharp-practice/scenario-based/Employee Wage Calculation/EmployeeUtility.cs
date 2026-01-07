using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Employee_Wage_Calculation
{
    sealed class EmployeeUtility
    {
        public const int IS_ABSENT = 0;
        public const int IS_PRESENT = 1;
        public const int WAGE_PER_HOUR = 20;
        public const int FULL_DAY_HOURS = 8;
        public static int GetAttendance()
        {
            Random random = new Random();
            return random.Next(0, 2);
        }
    }
}
