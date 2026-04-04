using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.LinkedList.LibraryManagement
{
    class LibraryDoublyLinkedList
    {
        private BookNode head;
        private BookNode tail;
        public void AddAtBeginning(int bookId, string title, string author, string genre, bool isAvailable) // Add book at beginning
        {
            BookNode newNode = new BookNode(bookId, title, author, genre, isAvailable);
            if (head == null)
            {
                head = tail = newNode;
                return;
            }
            newNode.next = head;
            head.prev = newNode;
            head = newNode;
        }
        public void AddAtEnd(int bookId, string title, string author, string genre, bool isAvailable) // Add book at end
        {
            BookNode newNode = new BookNode(bookId, title, author, genre, isAvailable);
            if (tail == null)
            {
                head = tail = newNode;
                return;
            }
            tail.next = newNode;
            newNode.prev = tail;
            tail = newNode;
        }
        public void AddAtPosition(int position, int bookId, string title, string author, string genre, bool isAvailable) // Add book at specific position (1-based index)
        {
            if (position <= 0)
            {
                Console.WriteLine("Invalid position.");
                return;
            }
            if (position == 1)
            {
                AddAtBeginning(bookId, title, author, genre, isAvailable);
                return;
            }
            BookNode temp = head;
            for (int i = 1; i < position - 1 && temp != null; i++)
                temp = temp.next;
            if (temp == null)
            {
                Console.WriteLine("Position out of range.");
                return;
            }
            BookNode newNode = new BookNode(bookId, title, author, genre, isAvailable);
            newNode.next = temp.next;
            newNode.prev = temp;
            if (temp.next != null)
                temp.next.prev = newNode;
            else
                tail = newNode;
            temp.next = newNode;
        }
        public void RemoveByBookId(int bookId) // Remove book by Book ID
        {
            if (head == null)
            {
                Console.WriteLine("Library is empty.");
                return;
            }
            BookNode temp = head;
            while (temp != null && temp.bookId != bookId)
                temp = temp.next;
            if (temp == null)
            {
                Console.WriteLine("Book not found.");
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
            Console.WriteLine("Book removed successfully.");
        }
        public void SearchByTitle(string title) // Search book by title
        {
            BookNode temp = head;
            bool found = false;
            while (temp != null)
            {
                if (temp.title.Equals(title, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayBook(temp);
                    found = true;
                }
                temp = temp.next;
            }
            if (!found)
                Console.WriteLine("No book found with this title.");
        }
        public void SearchByAuthor(string author) // Search book by author
        {
            BookNode temp = head;
            bool found = false;
            while (temp != null)
            {
                if (temp.author.Equals(author, StringComparison.OrdinalIgnoreCase))
                {
                    DisplayBook(temp);
                    found = true;
                }
                temp = temp.next;
            }
            if (!found)
                Console.WriteLine("No books found by this author.");
        }
        public void UpdateAvailability(int bookId, bool isAvailable) // Update availability status by Book ID
        {
            BookNode temp = head;

            while (temp != null)
            {
                if (temp.bookId == bookId)
                {
                    temp.isAvailable = isAvailable;
                    Console.WriteLine("Availability status updated.");
                    return;
                }
                temp = temp.next;
            }
            Console.WriteLine("Book not found.");
        }
        public void DisplayForward() // Display books in forward order
        {
            if (head == null)
            {
                Console.WriteLine("No books to display.");
                return;
            }
            BookNode temp = head;
            while (temp != null)
            {
                DisplayBook(temp);
                temp = temp.next;
            }
        }
        public void DisplayReverse() // Display books in reverse order
        {
            if (tail == null)
            {
                Console.WriteLine("No books to display.");
                return;
            }

            BookNode temp = tail;
            while (temp != null)
            {
                DisplayBook(temp);
                temp = temp.prev;
            }
        }
        public void CountBooks() // Count total number of books
        {
            int count = 0;
            BookNode temp = head;

            while (temp != null)
            {
                count++;
                temp = temp.next;
            }

            Console.WriteLine($"Total number of books: {count}");
        }
        private void DisplayBook(BookNode book) // Display single book details
        {
            Console.WriteLine(
                $"ID: {book.bookId}, Title: {book.title}, Author: {book.author}, Genre: {book.genre}, Available: {book.isAvailable}"
            );
        }
    }

}
