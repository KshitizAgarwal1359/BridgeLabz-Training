using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.BookBuddy
{
    public class BookBuddyMenu
    {
        private IBookManager bookManager; //interface reference
        public BookBuddyMenu()
        {
            bookManager = new BookManager(10); //bookshelf capacity
        }
        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("===============BookBuddy=============");
                Console.WriteLine("1. Add book");
                Console.WriteLine("2. Sort Books Alphabetically");
                Console.WriteLine("3. Search by author");
                Console.WriteLine("4. Display all books");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1": AddBookMenu(); break;
                    case "2": bookManager.SortBooksAlphabetically(); break;
                    case "3": SearchByAuthorMenu(); break;
                    case "4": bookManager.DisplayAllBooks(); break;
                    case "5": Console.WriteLine("Goodbye."); return;
                    default: Console.WriteLine("Invalid option."); break;
                }
            }
        }
        private void AddBookMenu()
        {
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();
            Console.Write("Enter author name: ");
            string author = Console.ReadLine();
            bookManager.AddBook(title, author);
        }
        private void SearchByAuthorMenu() {
            Console.Write("Enter author name: ");
            string author = Console.ReadLine();
            bookManager.SearchByAuthor(author);
        }
    }
}
