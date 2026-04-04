using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.BookShelf
{
    class BookNode //making a node class for the book
    {
        public string title;
        public string author;
        public BookNode next;
        public BookNode(string title, string author)
        {
            this.title = title;
            this.author = author;
            next = null;
        }
    }
}
