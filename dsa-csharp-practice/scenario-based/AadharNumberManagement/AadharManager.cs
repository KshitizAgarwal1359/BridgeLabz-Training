using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.AadharNumberManagement
{
    public class AadharManager
    {
        private AadharRecord[] records; //stores aadhar records
        private IAadharSorter sorter; //holds sorting logic
        public AadharManager(AadharRecord[] records,IAadharSorter sorter)
        {
            this.records = records; //initializes records
            this.sorter = sorter; //intializes sorter
        }
        public void SortAadharNumbers() //scenarioA sorting aadhar no. using radix sort
        {
            sorter.Sort(records); //sorts aadhar no.
        }
        public void DisplayAadharNumbers()
        {
            for(int i = 0; i < records.Length; i++)
            {
                Console.WriteLine(records[i].AadharNumber);
            }
        }
        public int SearchAadharNumber(long targetAadhar) //scenarioB search aadhar using binary search
        {
            int left = 0; //start index 
            int right = records.Length - 1; //ending index
            while (left <= right)
            {
                int mid = left+(right-left)/2; // prevents overflow
                if (records[mid].AadharNumber == targetAadhar)
                {
                    return mid;
                }
                else if (records[mid].AadharNumber < targetAadhar)
                {
                    left = mid + 1; //search right half
                }
                else
                {
                    right = mid - 1; //search left half
                }
            }
            return -1;
        }
        public void DisplayByPrefix(string prefix) // scenario c
        {
            bool found = false; //tracks if match is found
            for(int i = 0; i < records.Length; i++)
            {
                string aadharString = records[i].AadharNumber.ToString();
                if (aadharString.StartsWith(prefix))
                {
                    Console.WriteLine(records[i].AadharNumber); //stable order
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine($"No matching aadhar found with prefix: {prefix}");
            }
        }
    }
}
