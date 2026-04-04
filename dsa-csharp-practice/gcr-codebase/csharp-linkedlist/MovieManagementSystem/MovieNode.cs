using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzDSA.LinkedList.MovieManagementSystem
{
    class MovieNode
    {
        public string title;
        public string director;
        public int year;
        public double rating;
        public MovieNode next;
        public MovieNode prev;
        public MovieNode(string title, string director, int year, double rating) //constructor to initialize movie details
        {
            this.title = title;
            this.director = director;
            this.year = year;
            this.rating = rating;
            next = null;
            prev = null;
        }
    }
}
