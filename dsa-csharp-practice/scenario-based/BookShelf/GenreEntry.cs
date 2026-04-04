using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.BookShelf
{
    class GenreEntry //maps a genre into the custom hash map
    {
        public string genre;
        public BookLinkedList books;
        public GenreEntry next;
        public GenreEntry(string genre)
        {
            this.genre = genre;
            books = new BookLinkedList();
            next = null;
        }
    }
}
