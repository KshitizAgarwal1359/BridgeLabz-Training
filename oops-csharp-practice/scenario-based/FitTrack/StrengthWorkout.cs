using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.FitTrack
{
    class StrengthWorkout : Workout //represents strength workouts
    {
        public int sets { get; set; }
        public int reps { get; set; }
        public override void Track()
        {
            Console.WriteLine("Tracking your strength training.");
        }
        public override void DisplayWorkout()
        {
            base.DisplayWorkout();
            Console.WriteLine($"Sets: {sets}");
            Console.WriteLine($"Reps: {reps}");
        }
    }
}
