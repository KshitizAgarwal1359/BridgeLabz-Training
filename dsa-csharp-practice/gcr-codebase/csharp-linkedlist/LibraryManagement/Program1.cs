using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.LinkedList.LibraryManagement
{
    class Program1
    {
        public static void Main(String[] args)
        {
            LibraryDoublyLinkedList library = new LibraryDoublyLinkedList();

            library.AddAtBeginning(1, "1984", "George Orwell", "Dystopian", true);
            library.AddAtEnd(2, "The Hobbit", "J.R.R. Tolkien", "Fantasy", true);
            library.AddAtEnd(3, "Clean Code", "Robert C. Martin", "Programming", false);
            library.AddAtPosition(2, 4, "Atomic Habits", "James Clear", "Self Help", true);

            Console.WriteLine("\nLibrary (Forward):");
            library.DisplayForward();

            Console.WriteLine("\nLibrary (Reverse):");
            library.DisplayReverse();

            Console.WriteLine("\nSearch by Author:");
            library.SearchByAuthor("George Orwell");

            Console.WriteLine("\nUpdate Availability:");
            library.UpdateAvailability(3, true);

            Console.WriteLine("\nRemove Book:");
            library.RemoveByBookId(1);

            Console.WriteLine("\nFinal Library:");
            library.DisplayForward();

            Console.WriteLine("\nBook Count:");
            library.CountBooks();
        }
    }

}
