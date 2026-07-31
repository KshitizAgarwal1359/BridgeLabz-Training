using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.BookBuddy
{
    public abstract class BookManagerBase : IBookManager
    {
        protected string[] books; //stores book in "Title-author" format
        protected int bookCount; //tracks number of books added
        protected BookManagerBase(int capacity)
        {
            books = new string[capacity];
            bookCount = 0;
        }
        public abstract void AddBook(string title, string author);
        public abstract void SortBooksAlphabetically();
        public abstract void SearchByAuthor(string author);
        public abstract void DisplayAllBooks();
    }
}
