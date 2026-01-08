using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.Employee_Wage_Calculation
{
    class EmployeeUtilityImpl : IEmployee
    {
        private Random random = new Random();

        // UC1
        public int CheckAttendance(Employee employee)
        {
            int attendance = random.Next(0, 2);

            if (attendance == EmployeeUtility.IS_PRESENT)
                Console.WriteLine($"Employee {employee.employeeName} is Present");
            else
                Console.WriteLine($"Employee {employee.employeeName} is Absent");

            return attendance;
        }

        // UC2
        public void CalculateDailyWage(Employee employee, int attendance)
        {
            if (attendance == EmployeeUtility.IS_PRESENT &&
                employee.EmployeeType == EmployeeType.FULL_TIME)
            {
                int wage =
                    EmployeeUtility.WAGE_PER_HOUR *
                    EmployeeUtility.FULL_DAY_HOURS;

                Console.WriteLine($"UC2: Daily Wage = {wage}");
            }
        }

        // UC3
        public void CalculatePartTimeWage(Employee employee, int attendance)
        {
            if (attendance == EmployeeUtility.IS_PRESENT &&
                employee.EmployeeType == EmployeeType.PART_TIME)
            {
                int wage =
                    EmployeeUtility.WAGE_PER_HOUR *
                    EmployeeUtility.PART_TIME_HOURS;

                Console.WriteLine($"UC3: Part-Time Wage = {wage}");
            }
        }

        // UC4
        public void CalculateWageUsingSwitch(Employee employee, int attendance)
        {
            int hours = 0;

            switch (attendance)
            {
                case EmployeeUtility.IS_PRESENT:
                    switch (employee.EmployeeType)
                    {
                        case EmployeeType.FULL_TIME:
                            hours = EmployeeUtility.FULL_DAY_HOURS;
                            break;

                        case EmployeeType.PART_TIME:
                            hours = EmployeeUtility.PART_TIME_HOURS;
                            break;
                    }
                    break;
            }

            int wage = hours * EmployeeUtility.WAGE_PER_HOUR;
            Console.WriteLine($"UC4: Wage using Switch Case = {wage}");
        }

        // UC5
        public void CalculateMonthlyWage(Employee employee)
        {
            int totalWage = 0;

            for (int day = 1; day <= EmployeeUtility.WORKING_DAYS_PER_MONTH; day++)
            {
                int attendance = random.Next(0, 2);
                int hours = attendance == EmployeeUtility.IS_PRESENT
                    ? (employee.EmployeeType == EmployeeType.FULL_TIME
                        ? EmployeeUtility.FULL_DAY_HOURS
                        : EmployeeUtility.PART_TIME_HOURS)
                    : 0;

                totalWage += hours * EmployeeUtility.WAGE_PER_HOUR;
            }

            Console.WriteLine($"UC5: Monthly Wage = {totalWage}");
        }

        // UC6
        public void CalculateWageTillCondition(Employee employee)
        {
            int totalDays = 0;
            int totalHours = 0;
            int totalWage = 0;

            while (totalDays < EmployeeUtility.MAX_WORKING_DAYS &&
                totalHours < EmployeeUtility.MAX_WORKING_HOURS)
            {
                totalDays++;

                int attendance = random.Next(0, 2);
                int hours = 0;

                if (attendance == EmployeeUtility.IS_PRESENT)
                {
                    hours = employee.EmployeeType == EmployeeType.FULL_TIME
                        ? EmployeeUtility.FULL_DAY_HOURS
                        : EmployeeUtility.PART_TIME_HOURS;
                }

                totalHours += hours;
                totalWage += hours * EmployeeUtility.WAGE_PER_HOUR;
            }

            Console.WriteLine($"UC6: Total Wage = {totalWage}");
            Console.WriteLine($"UC6: Total Days = {totalDays}");
            Console.WriteLine($"UC6: Total Hours = {totalHours}");
        }
    }
}
