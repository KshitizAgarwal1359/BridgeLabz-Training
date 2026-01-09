using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz.FitTrack
{
    class FitMenu  //dispalys menu
    {
        public static void Start()
        {
            UserProfile user = new UserProfile();
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("FitTrack Menu");
                Console.WriteLine("1. create user profile");
                Console.WriteLine("2. Add Cardio Workout");
                Console.WriteLine("3.Add strength Workout");
                Console.WriteLine("4. View Workouts");
                Console.WriteLine("5.Exit");
                Console.Write("Enter choice: ");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.Write("Enter Name: ");
                        user.name = Console.ReadLine();
                        Console.Write("Enter Age: ");
                        user.age=int.Parse(Console.ReadLine());
                        Console.WriteLine("Profile created succesfully\n");
                        break;
                    case "2":
                        CardioWorkout cardio = new CardioWorkout();
                        Console.Write("Workout Name: ");
                        cardio.workoutName = Console.ReadLine();
                        Console.Write("Duration(minutes): ");
                        cardio.duration= int.Parse(Console.ReadLine());
                        Console.Write("Distance(km)");
                        cardio.distance= int.Parse(Console.ReadLine());
                        cardio.date=DateTime.Now;
                        cardio.Track();
                        user.workouts.Add(cardio);
                        Console.WriteLine("Cardio added successfully\n");
                        break;
                    case "3":
                        StrengthWorkout strength = new StrengthWorkout();
                        Console.Write("Workout Name: ");
                        strength.workoutName = Console.ReadLine();
                        Console.Write("Duration(minutes): ");
                        strength.duration = int.Parse(Console.ReadLine());
                        Console.Write("Sets: ");
                        strength.sets= int.Parse(Console.ReadLine());
                        Console.Write("Reps: ");
                        strength.reps = int.Parse(Console.ReadLine());
                        strength.date= DateTime.Now;
                        strength.Track();
                        user.workouts.Add(strength);
                        Console.WriteLine("Strength training added successfully\n");
                        break;
                    case "4":
                        Console.Write("\n");
                        user.DispalyProfile();
                        if (user.workouts.Count == 0) Console.WriteLine("No records here.\n");
                        else
                        {
                            Console.WriteLine("Workout history\n");
                            foreach(var workout in user.workouts)
                            {
                                workout.DisplayWorkout();
                                Console.WriteLine("==========");
                            }
                        }
                        break;
                    case "5":
                        exit = true;
                        Console.WriteLine("Thank you for visting FIT_TRACK.");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice.");
                        return;
                }
            }
        }
    }
}
