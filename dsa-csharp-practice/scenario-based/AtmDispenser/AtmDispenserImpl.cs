using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.AtmDispenser
{
    public class AtmDispenserImpl : IAtmDispenser //greedy algorithm
    {
        //For scenario A the denominations are:
     //   private readonly int[] denominations = {500, 200, 100, 50, 20, 10, 5, 2, 1 }; //available indian currency
        //for scenario b the denominations are:
     //   private readonly int[] denominations = { 200, 100, 50, 20, 10, 5, 2, 1 }; //available indian currency
        //for scenario c the denomiantions are:
        private readonly int[] denominations = { 200, 100, 50, 20, 10  }; //available indian currency

        public Dictionary<int,int> DispenseAmount(int amount)
        {
            Dictionary<int, int> result = new Dictionary<int, int>(); //to store denomination and its count
            int remainingAmount = amount;//gives remaining amount
            foreach(int note in denominations)
            {
                int count = remainingAmount / note;
                if (count > 0)
                {
                        result.Add(note, count);
                        remainingAmount %= note; //reduce remaining amount   
                }
            }
            if (remainingAmount > 0) { 
            result.Add(-1, remainingAmount);
            }
            return result;
        }
    }
}
