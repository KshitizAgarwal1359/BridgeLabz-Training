using System;
using System.Collections.Generic;
// Defines reservation-related behavior
interface IReservable
{
    void ReserveItem(string borrowerName);
    bool CheckAvailability();
}
// Base class for all library items
abstract class LibraryItem
{
    // Encapsulated fields
    private int itemId;
    private string title;
    private string author;

    // Protected borrower data (secured)
    protected string borrowerName;
    protected bool isAvailable = true;

    // Properties (controlled access)
    public int ItemId
    {
        get { return itemId; }
        private set
        {
            if (value <= 0)
                throw new ArgumentException("Item ID must be positive");
            itemId = value;
        }
    }

    public string Title
    {
        get { return title; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Title cannot be empty");
            title = value;
        }
    }

    public string Author
    {
        get { return author; }
        private set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Author cannot be empty");
            author = value;
        }
    }

    // Constructor
    protected LibraryItem(int itemId, string title, string author)
    {
        ItemId = itemId;
        Title = title;
        Author = author;
    }

    // Abstract method
    public abstract int GetLoanDuration();

    // Concrete method
    public virtual void GetItemDetails()
    {
        Console.WriteLine($"Item ID: {ItemId}");
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Available: {isAvailable}");
    }
}
class Book : LibraryItem, IReservable
{
    public Book(int id, string title, string author)
        : base(id, title, author) { }

    public override int GetLoanDuration()
    {
        return 14; // 14 days
    }

    public void ReserveItem(string borrower)
    {
        if (!isAvailable)
        {
            Console.WriteLine("Book already reserved.");
            return;
        }

        borrowerName = borrower;
        isAvailable = false;
        Console.WriteLine($"Book reserved by {borrower}");
    }

    public bool CheckAvailability()
    {
        return isAvailable;
    }
}
class Magazine : LibraryItem, IReservable
{
    public Magazine(int id, string title, string author)
        : base(id, title, author) { }

    public override int GetLoanDuration()
    {
        return 7; // 7 days
    }

    public void ReserveItem(string borrower)
    {
        borrowerName = borrower;
        isAvailable = false;
        Console.WriteLine($"Magazine reserved by {borrower}");
    }

    public bool CheckAvailability()
    {
        return isAvailable;
    }
}
class DVD : LibraryItem, IReservable
{
    public DVD(int id, string title, string author)
        : base(id, title, author) { }

    public override int GetLoanDuration()
    {
        return 3; // 3 days
    }

    public void ReserveItem(string borrower)
    {
        borrowerName = borrower;
        isAvailable = false;
        Console.WriteLine($"DVD reserved by {borrower}");
    }

    public bool CheckAvailability()
    {
        return isAvailable;
    }
}
class LibraryManagementSystem
{
    static void Main()
    {
        List<LibraryItem> items = new List<LibraryItem>
        {
            new Book(101, "Addenmentiem", "Ramesh"),
            new Magazine(102, "Cant hurt me", "david goggins"),
            new DVD(103, "Inception", "Christopher Nolan")
        };

        foreach (LibraryItem item in items)
        {
            item.GetItemDetails();
            Console.WriteLine($"Loan Duration: {item.GetLoanDuration()} days");

            if (item is IReservable reservable)
            {
                Console.WriteLine($"Available: {reservable.CheckAvailability()}");
                reservable.ReserveItem("Kshitiz");
            }

            Console.WriteLine("----------------------------------");
        }
    }
}
