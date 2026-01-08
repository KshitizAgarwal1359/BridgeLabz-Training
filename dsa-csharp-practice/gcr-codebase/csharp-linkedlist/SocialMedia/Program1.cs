using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.LinkedList.SocialMedia
{
    class Program1
    {
        public static void Main(string[] args)
        {
            SocialMediaLinkedList socialMedia = new SocialMediaLinkedList();

            socialMedia.AddUser(1, "Aman", 22);
            socialMedia.AddUser(2, "Riya", 21);
            socialMedia.AddUser(3, "Kunal", 23);
            socialMedia.AddUser(4, "Neha", 22);

            socialMedia.AddFriendConnection(1, 2);
            socialMedia.AddFriendConnection(1, 3);
            socialMedia.AddFriendConnection(2, 3);
            socialMedia.AddFriendConnection(3, 4);

            Console.WriteLine("\nDisplay Friends:");
            socialMedia.DisplayFriends(1);

            Console.WriteLine("\nMutual Friends between Aman & Riya:");
            socialMedia.FindMutualFriends(1, 2);

            Console.WriteLine("\nSearch by Name:");
            socialMedia.SearchByName("Kunal");

            Console.WriteLine("\nFriend Count:");
            socialMedia.CountFriendsForEachUser();

            Console.WriteLine("\nRemove Friend Connection:");
            socialMedia.RemoveFriendConnection(1, 3);

            Console.WriteLine("\nUpdated Friends:");
            socialMedia.DisplayFriends(1);
        }
    }

}
