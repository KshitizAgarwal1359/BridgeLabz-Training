using System;
class Book //base class
{
    public string ISBN; //public 
    protected string title; //protected 
    private string author; //private
    public Book(string isbn,string t,string a)
    {
        ISBN=isbn;
        title=t;
        author=a;
    }
    public string GetAuthor() //method to get author
    {
        return author;
    }
    public void SetAuthor(string a) //method to set author
    {
        author=a;
    }
}
class EBook : Book //subclass
{
    public string fileFormat;
    public EBook(string isbn,string t,string a,string format) : base(isbn, t, a) //constructor
    {
        fileFormat=format;
    }
    public void DisplayEBook()
    {
        Console.WriteLine("ISBN: "+ISBN);
        Console.WriteLine("title: "+title);
        Console.WriteLine("Author: "+GetAuthor());
        Console.WriteLine("File Format: "+fileFormat+"\n");
    }
}
class LibrarySystem //main class
{
    public static void Main(String[] args)
    {
        EBook book = new EBook("AJ-760890","Addmentium","Kshitiz","PDF"); //calling constructor
        book.DisplayEBook();
        book.SetAuthor("Kshitiz Agarwal"); //setting new author
        Console.WriteLine("Updated author : "+book.GetAuthor());  // getting new author

    }
}