using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.BookBuddy
{
    public class BookManager : BookManagerBase
    {
        public BookManager(int capacity) : base(capacity) { }
        public override void AddBook(string title, string author)
        {
            if (bookCount >= books.Length)
            {
                Console.WriteLine("Bookshelf is full");
                return;
            }
            books[bookCount] = title + "-" + author;
            bookCount++;
            Console.WriteLine("Book added.");
        }
        public override void SortBooksAlphabetically()
        {
            for(int i = 0; i < bookCount-1; i++)
            {
                for(int j = 0; j < bookCount - i - 1; j++)
                {
                    string title1 = books[j].Split("-")[0]; //extracts title
                    string title2 = books[j + 1].Split("-")[0];
                    if (string.Compare(title1, title2, true) > 0)
                    {
                        string temp = books[j]; //swapping books
                        books[j] = books[j+1];
                        books[j+1] = temp;
                    }
                }
            }
            Console.WriteLine("Books sorted alphabetically.");
        }
        public override void SearchByAuthor(string author)
        {
            bool found = false;
            for(int i = 0; i < bookCount; i++)
            {
                string[] parts = books[i].Split("-"); //splits title and author
                if (parts[1].Equals(author, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(books[i]);
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("No books found for this author.");
            }
        }
        public override void DisplayAllBooks()
        {
            if (bookCount == 0)
            {
                Console.WriteLine("No books in shelf.");
                return;
            }
            Console.WriteLine("----Digital BookShelf----");
            for(int i = 0; i < bookCount; i++)
            {
                Console.WriteLine(books[i]);
            }
        }
    }
}
