using System;
class Book{ // Superclass — Book
    public string title;
    public int publicationYear;
    public Book(string Title, int Year){
        title = Title;
        publicationYear = Year;
    }
    public virtual void DisplayInfo(){
        Console.WriteLine($"Book Title: {title}");
        Console.WriteLine($"Publication Year: {publicationYear}");
    }
}
class Author : Book{ // Subclass — Author
    public string name;
    public string bio;

    public Author(string Title, int Year, string Name, string Bio): base(Title, Year){
        name = Name;
        bio = Bio;
    }
    public override void DisplayInfo(){
        Console.WriteLine("\n--- Book & Author Details ---");
        base.DisplayInfo();
        Console.WriteLine($"Author Name: {name}");
        Console.WriteLine($"Author Bio: {bio}");
    }
}
class LibrarySystem{ // Main Class
    static void Main(string[] args){
        Author author1 = new Author("Addenmentium",2004,"Rohan Mehta","Indian novelist and fiction writer.");
        author1.DisplayInfo();
    }
}