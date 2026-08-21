using System;
using System.Collections.Generic;

public class Book
{
    public string Isbn;
    public string Title;
    public bool IsAvailable;
    public Book(string isbn,string title,bool isAvailable)
    {
        Isbn=isbn;
        Title=title;
        IsAvailable=isAvailable;
    }
}
public class Library
{
    private List<Book> books = new List<Book>();
    public void AddBook(Book b)
    {
        int left= 0;
        int right = books.Count;
        while (left < right)
        {
            int mid = left + (right-left)/2;
            if(string.Compare(books[mid].Isbn,b.Isbn)<0)
            left=mid+1;
            else
            right=mid;
        }
        books.Insert(left,b);
    }
    public Book FindByIsbn(string isbn)
    {
        int left = 0;
        int right = books.Count-1;
        while (left <= right)
        {
            int mid = left + (right-left)/2;
            int comparison = string.Compare(books[mid].Isbn,isbn);
            if(comparison==0)
            return books[mid];
            else if(comparison<0)
            left=mid+1;
            else
            right=mid-1;
        }
        return null;
    }
    public bool CheckOut(string isbn)
    {
        Book book = FindByIsbn(isbn);
        if(book == null || !book.IsAvailable)
        {
            return false;
        }
        book.IsAvailable=false;
        return true;
    }
}
class Program
{
    static void Main()
    {
        Library lib = new Library();
        lib.AddBook(new Book("123","Cant Hurt Me",true));
        lib.AddBook(new Book("A56","NCERT SoCIAL SCIENCE",true));
        lib.AddBook(new Book("P90","Money Follows",true));
        Book book = lib.FindByIsbn("P90");
        if (book != null)
        {
            Console.WriteLine(book.Title);
        }
        Console.WriteLine(lib.CheckOut("A56"));
        Console.WriteLine(lib.CheckOut("A56"));
    }
}