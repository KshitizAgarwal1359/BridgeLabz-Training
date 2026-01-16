using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.BookShelf
{
    class BookLinkedList //making a linked list class  for the book node class 
    {
        private BookNode head;
        public void AddBook(string title,string author) //adding a book in the book shelf
        {
            BookNode newNode = new BookNode(title, author);
            newNode.next = head;
            head = newNode;
        }
        public void RemoveBook(string title) //remove a book from book shelf
        {
            BookNode current = head;
            BookNode previous = null;
            while (current != null)
            {
                if (current.title == title)
                {
                    if (previous == null)
                        head = current.next;
                    else
                        previous.next = current.next;
                    Console.WriteLine("Book removed: " + title);
                    return;
                }
                previous = current;
                current = current.next;
            }
            Console.WriteLine("book not found: " + title);
        }
        public void DisplayBooks() //traversing through linked list and displaying all books
        {
            BookNode temp = head;
            while (temp != null)
            {
                Console.WriteLine($"{temp.title} by {temp.author}");
                temp = temp.next;
            }
        }
        public bool IsEmpty() //checking if linked list is empty
        {
            return head == null;
        }
    }
}
