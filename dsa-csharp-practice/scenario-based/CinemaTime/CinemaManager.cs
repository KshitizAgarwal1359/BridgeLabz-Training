using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.CinemaTime
{
    public class CinemaManager : MovieManagerBase
    {
        public CinemaManager(int capacity) : base(capacity) { }
        public override void AddMovie(string title, string time)
        {
            if (movieCount >= movieTitles.Length)
            {
                Console.WriteLine("Movie list ids full.");
                return;
            }
            movieTitles[movieCount] = title;
            movieTimes[movieCount] = time;
            movieCount++;
            Console.WriteLine("Movie Added.");
        }
        public override void SearchMovie(string keyword)
        {
            bool found = false;
            for (int i = 0; i < movieCount; i++) {
                if (movieTitles[i].Contains(keyword, StringComparison.OrdinalIgnoreCase)) {
                    Console.WriteLine(string.Format(
                        "Title: {0}, ShowTime: {1}",
                        movieTitles[i],
                        movieTimes[i]));
                    found = true;
                }

            }
            if (!found) {
                Console.WriteLine("No matching movie found.");
            }
        }
        public override void DisplayAllMovies()
        {
            if (movieCount == 0)
            {
                Console.WriteLine("No movies available."); return;
            }
            Console.WriteLine("------Movie Schedule-------");
            for(int i = 0; i < movieCount; i++)
            {
                Console.WriteLine(string.Format("Title: {0}, Showtime: {1}",
                    movieTitles[i],
                    movieTimes[i]));
            }
        }
    }
}
