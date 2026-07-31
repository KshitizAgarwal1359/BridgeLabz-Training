using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.FitTrack
{
    class CardioWorkout : Workout //representes cardio workouts
    {
        public double distance { get; set; }
        public override void Track()
        {
            Console.WriteLine("Tracking cardio workout.");
        }
        public override void DisplayWorkout()
        {
            base.DisplayWorkout();
            Console.WriteLine($"Distance : {distance}");

        }
    }
}
