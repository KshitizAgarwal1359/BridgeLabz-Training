using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.AtmDispenser
{
    class AtmDispenceMain
    {
        public static void Main(String[] args)
        {
            AtmUtility atmUtility = new AtmUtility(); //create atm utility object
            atmUtility.Start();// start atm process
            
       }
        
    }
}
