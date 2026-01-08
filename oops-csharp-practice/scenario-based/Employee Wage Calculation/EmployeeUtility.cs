using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Employee_Wage_Calculation
{
    sealed class EmployeeUtility
    {
        public const int IS_ABSENT = 0; //uc1
        public const int IS_PRESENT = 1;
        public const int WAGE_PER_HOUR = 20; //uc2
        public const int FULL_DAY_HOURS = 8;
        public const int PART_TIME_HOURS = 8; //uc3
        public const int WORKING_DAYS_PER_MONTH = 20; //uc4
        public const int MAX_WORKING_DAYS = 20; //uc5
        public const int MAX_WORKING_HOURS = 100; //uc6
        public static int GetAttendance()
        {
            Random random = new Random();
            return random.Next(0, 2);
        }
    }
}
