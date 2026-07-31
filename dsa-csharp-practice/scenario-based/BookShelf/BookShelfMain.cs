using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.BookShelf
{
    class BookShelfMain
    {
        public static void Main(String[] args)
        {
            Library library = new Library();
            library.AddBook("Self-Help", "Cant Hurt Me", "David Goggins");
            library.AddBook("Fiction", "SpiderMan", "Stan Lee");
            library.AddBook("Personal Finance", "Rich Dad Poor Dad", "Robert Kiyosaki");
            library.AddBook("Personal Finance", "The Psychology of Money", "Morgan Housel");
            library.AddBook("Self-Help", "Never Finished", "David Goggins");
            library.AddBook("Fiction", "IronMan", "Stan Lee");
            Console.WriteLine("Library Catalog");
            library.DisplayAll();
            Console.WriteLine("\n");
            library.BorrowBook("Fiction", "IronMan");
            Console.WriteLine("\n");
            Console.WriteLine("After Borrowing");
            library.DisplayAll();

        }
    }
}
