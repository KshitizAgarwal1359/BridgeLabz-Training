using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.AadharNumberManagement
{
    public class RadixSort : IAadharSorter
    {
        public void Sort(AadharRecord[] records)
        {
            long exp = 1; //starts with least significant digit
            for(int i=1;i<12;i++)
            {
                CountingSort(records, exp); //sorts by current digit
                exp *= 10;
            }
        }
        private void CountingSort(AadharRecord[] records, long exp)
        {
            int length = records.Length;
            AadharRecord[] output = new AadharRecord[length]; //stores sorted result
            int[] count = new int[10]; //stores digit frequency
            for(int i = 0; i < length; i++)
            {
                int digit = (int)((records[i].AadharNumber / exp) % 10); //extractrs digit
                count[digit]++;
            }
            for(int i = 1; i < 10; i++)
            {
                count[i] =count[i] +count[i - 1]; //calculate cumulative count
            }
            for(int i = length - 1; i >= 0; i--)
            {
                int digit = (int)((records[i].AadharNumber / exp) % 10);
                output[count[digit] - 1] = records[i]; //place element in sorted position
                count[digit]--;
            }
            for(int i = 0; i < length; i++)
            {
                records[i] = output[i]; //copies sorted datra back
            }
        }
    }
}
