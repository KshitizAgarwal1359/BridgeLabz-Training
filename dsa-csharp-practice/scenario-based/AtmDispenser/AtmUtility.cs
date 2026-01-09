using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.AtmDispenser
{
    public class AtmUtility
    {
        private readonly IAtmDispenser atmDispenser; //reference for losse coupling
        public AtmUtility()
        {
            atmDispenser = new AtmDispenserImpl();
        }
        public void Start() //method to start Atm operation
        {
            Console.Write("Enter amount to withdraw: ");
            int amount = int.Parse(Console.ReadLine());
            Dictionary<int, int> notes = atmDispenser.DispenseAmount(amount);//atm dispense logic
            Console.WriteLine("Dispensed notes: ");
            int totalNotes = 0;
            int fallbackAmount = 0;
            foreach (var item in notes)
            {
                if (item.Key == -1)
                {
                    fallbackAmount = item.Value;
                    continue;
                }
                Console.WriteLine($"{item.Key} x {item.Value}");
                totalNotes += item.Value;
            }
            if (fallbackAmount > 0)
            {
                Console.WriteLine($"Exact change not available. Remaining amount: {fallbackAmount}\n");
            }
            Console.WriteLine($"Total notes Dispenced : {totalNotes}");

        }
    }
}
