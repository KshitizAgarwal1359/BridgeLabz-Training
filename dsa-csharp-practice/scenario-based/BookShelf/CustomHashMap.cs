using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.BookShelf
{
    class CustomHashMap //using array+linked list for custom hash map
    {
        private GenreEntry[] table;
        private int size = 100;
        public CustomHashMap()
        {
            table = new GenreEntry[size];
        }
        private int GetHash(string key) //converts string key into integer using Ascii sumation and modulo operation
        {
            int hash = 0;
            foreach (char c in key)
                hash += c;
            return hash % size;
        }
        public GenreEntry GetOrCreateGenre(string genre) //create genre and not if genre already exist 
        {
            int index = GetHash(genre);
            GenreEntry entry = table[index];
            while (entry != null)
            {
                if (entry.genre == genre)
                    return entry;
                entry = entry.next;
            }
            GenreEntry newEntry = new GenreEntry(genre);
            newEntry.next = table[index];
            table[index] = newEntry;
            return newEntry;
        }
        public void DisplayLibrary() //dispalying all books in library
        {
            for(int i = 0; i < size; i++)
            {
                GenreEntry entry = table[i];
                while (entry != null)
                {
                    Console.WriteLine("Genre: " + entry.genre);
                    entry.books.DisplayBooks();
                    entry = entry.next;
                }
            }
        }
    }
}
