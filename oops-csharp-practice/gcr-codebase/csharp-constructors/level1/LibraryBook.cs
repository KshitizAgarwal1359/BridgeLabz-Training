using System;
class LibraryBook
{
    public string title; //global variables
    public string author;
    public double price;
    public bool available;
    public LibraryBook(string t,string a,double p) //constructor
    {
        title=t;
        author=a;
        price=p;
        available=true;
    }
    public void Borrow() //method to borrow
    {
        if (available)
        {
            available=false;
            Console.WriteLine("Book borrowed");
        }
        else
        {
            Console.WriteLine("Book already borrowed");
        }
    }
    public void Display()  //method to display book stats
    {
        Console.WriteLine("Title: "+title);
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Price: {price}");
        Console.WriteLine("Available: "+(available ? "Available" : "No"));
    }
    public static void Main(string[] args)
    {
        LibraryBook b = new LibraryBook("Addmentium","Kshitiz",967.91);
        b.Display();
        b.Borrow(); //borrow the book
        b.Display();
        b.Borrow(); //borrowing again
    }

}