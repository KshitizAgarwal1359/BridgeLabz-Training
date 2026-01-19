using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.ExamProctor
{
    public class MapNode
    {
        public int key;
        public string value;
        public MapNode next;
        public MapNode(int key,string value)
        {
            this.key = key;
            this.value = value;
            next = null;
        }
    }
    public class CustomHashMap
    {
        private MapNode[] buckets;
        private int size = 10;
        public CustomHashMap()
        {
            buckets = new MapNode[size];
        }
        private int GeTIndex(int key) //hash function
        {
            return key % size;
        }
        public void Put(int key,string value) //insert or update answer
        {
            int index = GeTIndex(key);
            MapNode head = buckets[index];
            while (head != null)
            {
                if (head.key == key)
                {
                    head.value = value;
                    return;
                }
                head = head.next;
            }
            MapNode newNode = new MapNode(key, value);
            newNode.next = buckets[index];
            buckets[index] = newNode;
        }
        public string Get(int key) //retrieve answer
        {
            int index = GeTIndex(key);
            MapNode head = buckets[index];
            while (head != null)
            {
                if (head.key == key)
                    return head.value;
                head = head.next;
            }
            return null;
        }
        public MapNode[] GetBuckets() //used for scoring
        {
            return buckets;
        }
    }
}
