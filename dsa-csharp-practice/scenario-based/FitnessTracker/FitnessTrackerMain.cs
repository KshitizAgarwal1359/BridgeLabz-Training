using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.FitnessTracker
{
    class FitnessTrackerMain
    {
        public static void Main(String[] args)
        {
            User[] users =
            {
                new User{userId = 343,userName="Ravi",steps=2345},
                new User{userId=456,userName="Aarush",steps=6790},
                new User{userId=455,userName="Dhruv",steps=5600},
                new User{userId=245,userName="Kshitiz",steps=8900},
                new User{userId=1222,userName="Sameer",steps=1500},
                new User{userId=2367,userName="Shashi",steps=8872},
                new User{userId=567,userName="Anshika",steps=908},
            };
            Console.WriteLine("Before Sorting: \n");
            PrintUsers(users);
            BubbleSort.Sort(users);
            Console.WriteLine("After sorting: \n");
            PrintUsers(users);

        }
        static void PrintUsers(User[] users)
        {
            foreach(var user in users)
            {
                Console.WriteLine(user);
            }
            Console.WriteLine();
        }
    }
}
