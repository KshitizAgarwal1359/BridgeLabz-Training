/*Library Management System – Book Search and Checkout
Scenario: You’re designing a system for a small library to manage books and track checkouts.
Problem Requirements:
● Store book details (title, author, status) in a Array.
● Allow searching by partial title using String operations.
● Store book data in an Array.
● Use methods for searching, displaying, and updating book status (checked out or
available).*/
using System;
class LibraryManagementSystem
{
    static string[,,] library = new string[100,5,4]; //first dimension 100 max no. of books second dimension books fields like author title status third dimension to store history of check in check out
    static int bookCount=0; //current books in library
    const string ADMIN_KEY="admin123"; //admin passkey
    public static void Main(String[] args)
    {
        MainMenu();
    }
    static void MainMenu() //menu for user or admin login
    {
        while(true){
        Console.WriteLine("\n----Library Management System-----");
        Console.WriteLine("1. Admin Login");
        Console.WriteLine("2. User Login");
        Console.WriteLine("3. Exit");
        Console.Write("Choose Option: ");
        string option = Console.ReadLine();
        switch (option)
        {
            case "1":
            AdminLogin(); //Admin authentication
            break;
            case "2":
            UserMenu(); // user menu options appear
            break;
            case "3":
            Console.WriteLine("goodbye");
            return;
            default:
            Console.WriteLine("Invalid choice.");
            break;
        }
        }
    }
    static void AdminLogin() //admin authentication method
    {
        Console.WriteLine("Enter the passkey for admin: ");
        string key = Console.ReadLine();
        if (key == ADMIN_KEY)
        {
            AdminMenu();  //show admin menus to admin
        }
        else
        {
            Console.WriteLine("Incorrect passkey.");
        }
    }
    static void AdminMenu() //admin menu
    {
        while (true)
        {
            Console.WriteLine("\n---Admin Menu----");
            Console.WriteLine("1. Add book");
            Console.WriteLine("2. view books");
            Console.WriteLine("3. search book");
            Console.WriteLine("4. check out book");
            Console.WriteLine("5. check in book");
            Console.WriteLine("6. logout");
            Console.WriteLine("Choose option");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                AddBook();
                break;
                case "2":
                DisplayBooks();
                break;
                case "3":
                SearchBook();
                break;
                case "4":
                CheckoutBook();
                break;
                case "5":
                CheckinBook();
                return;
                case "6":
                return;
                default:
                Console.WriteLine("Invalid choice");
                break;
            }
        }
    }
    static void UserMenu()
    {
        while (true)
        {
            Console.WriteLine("\n-----User Menu------");
            Console.WriteLine("1. View books");
            Console.WriteLine("2. Search books");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Choose option: ");
            string option = Console.ReadLine();
            switch (option)
            {
                case "1": DisplayBooks(); break;
                case "2": SearchBook(); break;
                case "3": return;
                default: Console.WriteLine("Invalid choice"); break;
            }
        }
    }
        static void AddBook(){
            Console.Write("enter book title: ");
            library[bookCount,0,0]=Console.ReadLine();
            Console.WriteLine("Enter author name:");
            library[bookCount,1,0]= Console.ReadLine();
            library[bookCount,2,0]="Available"; //book status
            library[bookCount,3,0]="n/a";     //checkout time
            library[bookCount,4,0]="n/a";    //checkin time
            bookCount++;
            Console.WriteLine("Book added successfully");
        }
        static void DisplayBooks() //displays all the books in library
    {
        if (bookCount == 0)
        {
            Console.WriteLine("No books Available.");
            return;
        }
        Console.WriteLine("\n---book list----");
        for(int i = 0; i < bookCount; i++)
        {
            Console.WriteLine($"Title: {library[i,0,0]}, Author: {library[i,1,0]}, Status: {library[i,2,0]}");
        }
    }
    static void SearchBook() //find books by text
    {
        Console.WriteLine("enter book title part: ");
        string search=(Console.ReadLine() ?? "").ToLower();
        bool found=false;
        for(int i = 0; i < bookCount; i++)
        {
            if (library[i, 0, 0].ToLower().Contains(search))
            {
                Console.WriteLine($"Title: {library[i,0,0]}, Author: {library[i,1,0]}, Status: {library[i,2,0]}");
                found=true;
            }
        }
        if (!found)
        {
            Console.WriteLine("No matching books found.");
        }
    }
    static void CheckinBook() //when book is returned check in
    {
        Console.Write("Enter exact book title to check in:");
        string title = Console.ReadLine().ToLower();
        for(int i = 0; i < bookCount; i++)
        {
            if (library[i, 0, 0].ToLower() == title)
            {
                if(library[i,2,0]=="Checked Out")
                {
                    library[i,2,0]="Available"; //update status
                    library[i,4,0]=DateTime.Now.ToString();  //set check in time
                    Console.WriteLine("Book checked in successfully.");
                }
                else
                {
                    Console.WriteLine("Book already available");
                }
                return;
            }
        }
        Console.WriteLine("Book not found");
    }
    static void CheckoutBook()
    {
        Console.Write("Enter exact title to check out: ");
        string title = Console.ReadLine().ToLower();
        for(int i = 0;i < bookCount; i++)
        {
            if(library[i,2,0]=="Available")
            {
                library[i,2,0]="Checked Out"; //update status
                library[i,3,0]= DateTime.Now.ToString(); //set check out time
                library[i,4,0]="n/a"; //reset check in time
                Console.WriteLine("Book checked out successfully.");
            }
            else
            {
                Console.WriteLine("Book is already checked out.");
            }
            return;
        }
    }
}