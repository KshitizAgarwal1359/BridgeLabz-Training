using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.Scenario_Based.CinemaTime
{
    public abstract class MovieManagerBase : IMovieManager
    {
        protected string[] movieTitles;
        protected string[] movieTimes;
        protected int movieCount;
        protected MovieManagerBase(int capacity) {
        movieTitles = new string[capacity];
            movieTimes = new string[capacity];
            movieCount = 0;
        }
        public abstract void AddMovie(string title,string time);
        public abstract void SearchMovie(string keyword);
        public abstract void DisplayAllMovies();
    }
}
