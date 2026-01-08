using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.LinkedList.LibraryManagement
{
    class BookNode
    {
        public int bookId;
        public string title;
        public string author;
        public string genre;
        public bool isAvailable;
        public BookNode next;
        public BookNode prev;
        public BookNode(int bookId, string title, string author, string genre, bool isAvailable) //constructor to initialize book details
        {
            this.bookId = bookId;
            this.title = title;
            this.author = author;
            this.genre = genre;
            this.isAvailable = isAvailable;
            next = null;
            prev = null;
        }
    }

}
