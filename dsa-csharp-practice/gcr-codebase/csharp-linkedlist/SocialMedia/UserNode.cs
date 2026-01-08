using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.LinkedList.SocialMedia
{
    class UserNode
    {
        public int userId;
        public string name;
        public int age;
        public List<int> friendIds;
        public UserNode next;
        public UserNode(int userId, string name, int age) // Constructor to initialize user details
        {
            this.userId = userId;
            this.name = name;
            this.age = age;
            friendIds = new List<int>();
            next = null;
        }
    }
}
