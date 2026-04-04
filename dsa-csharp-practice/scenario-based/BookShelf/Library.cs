using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.BookShelf
{
    class Library
    {
        private CustomHashMap catalog;
        public Library()
        {
            catalog = new CustomHashMap();
        }
        public void AddBook(string genre,string title,string author)
        {
            GenreEntry entry = catalog.GetOrCreateGenre(genre);
            entry.books.AddBook(title, author);
        }
        public void BorrowBook(string genre,string title)
        {
            GenreEntry entry = catalog.GetOrCreateGenre(genre);
            entry.books.RemoveBook(title);
        }
        public void DisplayAll()
        {
            catalog.DisplayLibrary();
        }
    }
}
