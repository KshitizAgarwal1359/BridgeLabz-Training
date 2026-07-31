using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.CinemaTime
{
    public class CinemaTimeMenu
    {
        private IMovieManager movieManager;
        public CinemaTimeMenu()
        {
            movieManager = new CinemaManager(10);
        }
        public void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("=====Cinema Time=====");
                Console.WriteLine("1. Add Movie.");
                Console.WriteLine("2. Search Movie.");
                Console.WriteLine("3.Display all Movies");
                Console.WriteLine("4. Exit.");
                Console.Write("Enter option: ");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": AddMovieMenu(); break;
                    case "2": SearchMovieMenu(); break;
                    case "3": movieManager.DisplayAllMovies(); break;
                    case "4": Console.WriteLine("Goodbye."); return;
                    default: Console.WriteLine("Invalid Option."); break;
                }
            }
        }
        private void AddMovieMenu()
        {
            Console.Write("Enter movie title: ");
            string title = Console.ReadLine();
            Console.WriteLine("Enter showtime: ");
            string time = Console.ReadLine();
            movieManager.AddMovie(title, time);
        }
        private void SearchMovieMenu() {
            Console.WriteLine("Enter keyword: ");
            string keyword = Console.ReadLine();
            movieManager.SearchMovie(keyword);
        }
    }
}
