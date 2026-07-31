using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BridgeLabzDSA.Scenario_Based.FitnessTracker
{
    class BubbleSort
    {
        public static void Sort(User[] users) //method of sort for bubble sort
        {
            int n = users.Length;
            bool swapped;
            for(int i = 0; i < n - 1; i++)
            {
                swapped = false;
                for(int j = 0; j < n - i-1; j++)
                {
                    if (users[j].steps < users[j + 1].steps)
                    {
                        Swap(users, j, j + 1); //descending
                        swapped = true;
                    }
                }
                if (!swapped)
                    return;
            }
        }
        public static void Swap(User[] users,int i,int j)
        {
            User temp = users[i];
            users[i] = users[j];
            users[j] = temp;
        }
    }
}
