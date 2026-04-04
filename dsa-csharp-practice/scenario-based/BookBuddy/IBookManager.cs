using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.BookBuddy
{
    public interface IBookManager
    {
        void AddBook(string title, string author); //adds a new book
        void SortBooksAlphabetically();        //sorts books by title
        void SearchByAuthor(string author); //Searches books by author
        void DisplayAllBooks(); // display all books
    }
}
