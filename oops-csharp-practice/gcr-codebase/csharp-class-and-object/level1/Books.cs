/*Program to Handle Book Details
Problem Statement: Write a program to create a Book class with attributes title, author, and price. Add a method to display the book details.*/

using System;

public class Book{
        public static string title;
        public static string author;
        public static double price;

        public void display(){
                Console.WriteLine("Title of the book : "+title);
                Console.WriteLine("Author of the book : "+author);
                Console.WriteLine("Price of the book : "+price);
        }
}

public class BookDetails{
        public static void Main(string[] args){
        Book book = new Book();
        Console.WriteLine("Enter the title of the book : ");
        Book.title = Console.ReadLine();
        Console.WriteLine("Enter the author of the book : ");
        Book.author = Console.ReadLine();
        Console.WriteLine("Enter the price of the book : ");
        Book.price = Convert.ToDouble(Console.ReadLine());

    book.display();
    }
}