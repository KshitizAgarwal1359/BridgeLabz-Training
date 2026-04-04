using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.FitTrack
{
    class UserProfile //stores user details
    {
        public string name {  get; set; }
        public int age { get; set; }
        public List<Workout> workouts { get; set; } = new List<Workout>(); // lsit to store workouts
        public void DispalyProfile()
        {
            Console.WriteLine("User profile");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
        }
    }
}
