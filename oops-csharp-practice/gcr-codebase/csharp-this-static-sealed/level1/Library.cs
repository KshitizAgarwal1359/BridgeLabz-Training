using System;
class Book
{
    public static string libraryName="Central Library"; //static variable
    public readonly string ISBN; 
    public string title;
    public string author;
    public Book(string title,string author,string ISBN)
    {
        this.title=title;
        this.author=author;
        this.ISBN=ISBN;
    }
    public static void DisplayLibraryName()
    {
        Console.WriteLine("Library name: "+libraryName+"\n");
    }
    public void DisplayBookDetails(object obj)
    {
        if(obj is Book)
        {
            Console.WriteLine("Title: "+title);
            Console.WriteLine("Author: "+author);
            Console.WriteLine("ISBN: "+ISBN+"\n");
        }
        else
        Console.WriteLine("Invalid book obj.");
    }
}
class Library
{
    public static void Main(String[] args)
    {
        Book.DisplayLibraryName();
        Book book1 = new Book("Addmentium","Kshitiz","978-4567890");
        Book book2 = new Book("Cant Hurt Me","David Goggins","956-4567890");
        book1.DisplayBookDetails(book1);
        book2.DisplayBookDetails(book2);
    }
}