using System;
class Book
{
    public string title;
    public string author;
    public double price;
    public Book() //default cons
    {
        title = "Unknown";
        author="Unknown";
        price=0.0;
    }
    public Book(string title,string author,double price) //parameterized constructor
    {
        this.title=title;
        this.author=author;
        this.price=price;
    }
    public void DisplayBook()
    {
        Console.WriteLine("Title: "+title);
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Price: {price}");
    }
    public static void Main(String[] args)
    {
        Book book1 = new Book(); ///use of default constructor
        book1.DisplayBook();
        Book book2 = new Book("Addmentium","Kshitiz",467.58); //use of paramatezied constructor
        book2.DisplayBook();
    }
}