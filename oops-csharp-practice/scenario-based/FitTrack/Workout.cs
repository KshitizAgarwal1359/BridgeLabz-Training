using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.FitTrack
{
     abstract class Workout :ITrackable
    {
       
            public string workoutName { get; set; }
            public int duration { get; set; } //in minutes
            public DateTime date { get; set; }
            public abstract void Track(); //implemented by child classes
            public virtual void DisplayWorkout() //common display function
            {
                Console.WriteLine($"Workout name: {workoutName}");
                Console.WriteLine($"Duration: {duration} minutes");
                Console.WriteLine($"Date: {date.ToShortDateString()}");
            }
        
    }
}
