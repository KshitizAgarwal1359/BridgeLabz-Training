using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.PasswordCracker
{
    public class PasswordCrackerMain
    {
        public static void Main(string[] args)
        {
            char[] characterset = {'k','s','h','i','t','z'};
            int passwordLength = 7;
            string targetPassword = "kshitzz";
            PasswordCracker cracker = new PasswordCracker(characterset, passwordLength, targetPassword);
            cracker.StartCracking(); //starts backtracking
        }
    }
}
