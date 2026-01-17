using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.FitnessTracker
{
    class User
    {
        public int userId { get; set; }
        public string userName { get; set; }
        public int steps { get; set; }
        public override string ToString()
        {
            return $"Name: {userName}, Steps: {steps}";
        }
    }
}
