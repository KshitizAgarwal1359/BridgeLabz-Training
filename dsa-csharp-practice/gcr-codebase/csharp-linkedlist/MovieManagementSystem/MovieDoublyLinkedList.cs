using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.LinkedList.MovieManagementSystem
{
    class MovieDoublyLinkedList
    {
        private MovieNode head;
        private MovieNode tail;
        public void AddAtBeginning(string title, string director, int year, double rating) // Add movie at beginning
        {
            MovieNode newNode = new MovieNode(title, director, year, rating);
            if (head == null)
            {
                head = tail = newNode;
                return;
            }
            newNode.next = head;
            head.prev = newNode;
            head = newNode;
        }
        public void AddAtEnd(string title, string director, int year, double rating) // Add movie at end
        {
            MovieNode newNode = new MovieNode(title, director, year, rating);
            if (tail == null)
            {
                head = tail = newNode;
                return;
            }
            tail.next = newNode;
            newNode.prev = tail;
            tail = newNode;
        }
        public void AddAtPosition(int position, string title, string director, int year, double rating) // Add movie at specific position (1-based index)
        {
            if (position <= 0)
            {
                Console.WriteLine("Invalid position.");
                return;
            }
            if (position == 1)
            {
                AddAtBeginning(title, director, year, rating);
                return;
            }
            MovieNode temp = head;
            for (int i = 1; i < position - 1 && temp != null; i++)
            {
                temp = temp.next;
            }
            if (temp == null)
            {
                Console.WriteLine("Position out of range.");
                return;
            }
            MovieNode newNode = new MovieNode(title, director, year, rating);
            newNode.next = temp.next;
            newNode.prev = temp;

            if (temp.next != null)
                temp.next.prev = newNode;
            else
                tail = newNode;
            temp.next = newNode;
        }
        public void RemoveByTitle(string title) // Remove movie by title
        {
            if (head == null)
            {
                Console.WriteLine("Movie list is empty.");
                return;
            }
            MovieNode temp = head;
            while (temp != null && temp.title != title)
            {
                temp = temp.next;
            }
            if (temp == null)
            {
                Console.WriteLine("Movie not found.");
                return;
            }
            if (temp == head)
                head = temp.next;
            if (temp == tail)
                tail = temp.prev;
            if (temp.prev != null)
                temp.prev.next = temp.next;
            if (temp.next != null)
                temp.next.prev = temp.prev;
            Console.WriteLine("Movie removed successfully.");
        }
        public void SearchByDirector(string director)    //search movie by director
        {
            MovieNode temp = head;
            bool found = false;
            while (temp != null)
            {
                if (temp.director.Equals(director, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayMovie(temp);
                    found = true;
                }
                temp = temp.next;
            }
            if (!found)
                Console.WriteLine("No movies found for this director.");
        }
        public void SearchByRating(double rating) // Search movie by rating
        {
            MovieNode temp = head;
            bool found = false;
            while (temp != null)
            {
                if (temp.rating == rating)
                {
                    DisplayMovie(temp);
                    found = true;
                }
                temp = temp.next;
            }
            if (!found)
                Console.WriteLine("No movies found with this rating.");
        }
        public void UpdateRating(string title, double newRating) // Update movie rating by title
        {
            MovieNode temp = head;
            while (temp != null)
            {
                if (temp.title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    temp.rating = newRating;
                    Console.WriteLine("Rating updated successfully.");
                    return;
                }
                temp = temp.next;
            }
            Console.WriteLine("Movie not found.");
        }
        public void DisplayForward() // Display movies in forward order
        {
            if (head == null)
            {
                Console.WriteLine("No movies to display.");
                return;
            }
            MovieNode temp = head;
            while (temp != null)
            {
                DisplayMovie(temp);
                temp = temp.next;
            }
        }
        public void DisplayReverse()  // Display a single movie
        {
            if (tail == null)
            {
                Console.WriteLine("No movies to display.");
                return;
            }
            MovieNode temp = tail;
            while (temp != null)
            {
                DisplayMovie(temp);
                temp = temp.prev;
            }
        }
        private void DisplayMovie(MovieNode movie)  // Display a single movie
        {
            Console.WriteLine(
                $"Title: {movie.title}, Director: {movie.director}, Year: {movie.year}, Rating: {movie.rating}"
            );
        }
    }
}
