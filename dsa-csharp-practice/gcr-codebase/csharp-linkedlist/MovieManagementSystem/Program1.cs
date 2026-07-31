using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.LinkedList.MovieManagementSystem
{
    class Program1
    {
        public static void Main(String[] args)
        {
            MovieDoublyLinkedList movieList = new MovieDoublyLinkedList();

            movieList.AddAtBeginning("Inception", "Christopher Nolan", 2010, 9.0);
            movieList.AddAtEnd("Interstellar", "Christopher Nolan", 2014, 8.6);
            movieList.AddAtPosition(2, "Avatar", "James Cameron", 2009, 7.8);
            Console.WriteLine("\nMovies (Forward Order):");
            movieList.DisplayForward();
            Console.WriteLine("\nMovies (Reverse Order):");
            movieList.DisplayReverse();
            Console.WriteLine("\nSearch by Director:");
            movieList.SearchByDirector("Christopher Nolan");
            Console.WriteLine("\nUpdate Rating:");
            movieList.UpdateRating("Avatar", 8.2);
            Console.WriteLine("\nRemove Movie:");
            movieList.RemoveByTitle("Inception");
            Console.WriteLine("\nFinal Movie List:");
            movieList.DisplayForward();
        }
    }
}
