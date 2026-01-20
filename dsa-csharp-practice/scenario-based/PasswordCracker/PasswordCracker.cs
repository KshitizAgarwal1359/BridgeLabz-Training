using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BridgeLabzDSA.Scenario_Based.PasswordCracker
{
    public class PasswordCracker
    {
        private char[] characterSet; //allowed characters
        private int passwordLength; //length of password
        private string targetPassword; //actual password to crack
        private bool isFound = false;
        private int attemptCount = 0; //time complexity
        public PasswordCracker(char[] characterSet,int passwordLength, string targetPassword)
        {
            this.characterSet = characterSet;
            this.passwordLength = passwordLength;
            this.targetPassword = targetPassword;
        }
        public void StartCracking()
        {
            char[] current = new char[passwordLength]; //temp holds password
            Backtrack(0, current);
            Console.WriteLine("\nTotal Attempts: " + attemptCount);
        }
        private void Backtrack(int index, char[] current)
        {
            if (isFound)
                return; ///stops further recursion once password is found
            if (index == passwordLength)
            {
                attemptCount++;
                string attempt = new string(current);
                Console.WriteLine(attempt);
                if (attempt.Equals(targetPassword))
                {
                    Console.WriteLine("\n password cracked succesfully");
                    isFound = true; //stopping from further attempts
                }
                return;
            }
            for(int i = 0; i < characterSet.Length; i++)
            {
                current[index] = characterSet[i];
                Backtrack(index + 1, current); //move to next position
            }
        }
    }
}
