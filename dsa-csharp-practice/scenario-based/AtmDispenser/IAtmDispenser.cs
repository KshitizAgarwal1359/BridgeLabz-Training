using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.AtmDispenser
{
    interface IAtmDispenser//defining atm dispensing behavior
    {
        Dictionary<int,int> DispenseAmount(int amount); //method to claculate optimal note distribution
    }
}
