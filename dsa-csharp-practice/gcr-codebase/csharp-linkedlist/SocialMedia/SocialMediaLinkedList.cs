using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.LinkedList.SocialMedia
{
    class SocialMediaLinkedList
    {
        private UserNode head;

       
        public void AddUser(int userId, string name, int age)  // Add a new user
        {
            UserNode newNode = new UserNode(userId, name, age);
            newNode.next = head;
            head = newNode;
        }

        
        public void AddFriendConnection(int userId1, int userId2) // Add friend connection between two users
        {
            UserNode user1 = GetUserById(userId1);
            UserNode user2 = GetUserById(userId2);

            if (user1 == null || user2 == null)
            {
                Console.WriteLine("One or both users not found.");
                return;
            }

            if (!user1.friendIds.Contains(userId2))
                user1.friendIds.Add(userId2);

            if (!user2.friendIds.Contains(userId1))
                user2.friendIds.Add(userId1);

            Console.WriteLine("Friend connection added.");
        }

        
        public void RemoveFriendConnection(int userId1, int userId2) // Remove friend connection
        {
            UserNode user1 = GetUserById(userId1);
            UserNode user2 = GetUserById(userId2);

            if (user1 == null || user2 == null)
            {
                Console.WriteLine("One or both users not found.");
                return;
            }

            user1.friendIds.Remove(userId2);
            user2.friendIds.Remove(userId1);

            Console.WriteLine("Friend connection removed.");
        }

        
        public void FindMutualFriends(int userId1, int userId2) // Find mutual friends between two users
        {
            UserNode user1 = GetUserById(userId1);
            UserNode user2 = GetUserById(userId2);

            if (user1 == null || user2 == null)
            {
                Console.WriteLine("One or both users not found.");
                return;
            }

            Console.WriteLine("Mutual Friends:");
            foreach (int id in user1.friendIds)
            {
                if (user2.friendIds.Contains(id))
                {
                    UserNode mutual = GetUserById(id);
                    if (mutual != null)
                        Console.WriteLine($"{mutual.name} (ID: {mutual.userId})");
                }
            }
        }

        
        public void DisplayFriends(int userId) // Display all friends of a user
        {
            UserNode user = GetUserById(userId);

            if (user == null)
            {
                Console.WriteLine("User not found.");
                return;
            }

            Console.WriteLine($"Friends of {user.name}:");
            foreach (int id in user.friendIds)
            {
                UserNode friend = GetUserById(id);
                if (friend != null)
                    Console.WriteLine($"{friend.name} (ID: {friend.userId})");
            }
        }

        
        public void SearchByUserId(int userId) // Search user by User ID
        {
            UserNode user = GetUserById(userId);

            if (user == null)
            {
                Console.WriteLine("User not found.");
                return;
            }

            DisplayUser(user);
        }

       
        public void SearchByName(string name)  // Search user by Name
        {
            UserNode temp = head;
            bool found = false;

            while (temp != null)
            {
                if (temp.name.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayUser(temp);
                    found = true;
                }
                temp = temp.next;
            }

            if (!found)
                Console.WriteLine("User not found.");
        }

        
        public void CountFriendsForEachUser() // Count number of friends for each user
        {
            UserNode temp = head;

            while (temp != null)
            {
                Console.WriteLine($"{temp.name} has {temp.friendIds.Count} friends.");
                temp = temp.next;
            }
        }

       
        private UserNode GetUserById(int userId)  // Get user by ID
        {
            UserNode temp = head;

            while (temp != null)
            {
                if (temp.userId == userId)
                    return temp;
                temp = temp.next;
            }

            return null;
        }

        
        private void DisplayUser(UserNode user) // Display user details
        {
            Console.WriteLine(
                $"ID: {user.userId}, Name: {user.name}, Age: {user.age}, Friends Count: {user.friendIds.Count}"
            );
        }
    }
}
