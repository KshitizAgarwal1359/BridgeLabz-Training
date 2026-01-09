using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.AtmDispenser
{
    public class CurrencyNote //demonstrate encapsulation 
    {
        public int Denomination { get; set; } //stores value of the note
        public CurrencyNote(int denomiantion) { //constructor intializing denomination
        Denomination = denomiantion;
        }

    }
}
