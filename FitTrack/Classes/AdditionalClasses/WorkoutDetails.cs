using FitTrack.Classes.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitTrack.Classes
{
    // WorkoutDetailsWindow hanterar visning och redigering av detaljer för träningspass
    //    public class WorkoutDetailsWindowClass
    //    {
    //        private Workout workout;

    //        public WorkoutDetailsWindow(Workout selectedWorkout)
    //        {
    //            workout = selectedWorkout;
    //        }

    //        public void EditWorkout()
    //        {
    //            // Logik för att redigera träningspasset
    //            Console.WriteLine("Redigering av träningspass.");
    //        }
    //    }
    //}

    public class WorkoutDetailsWindow
    {
        public Workout Workout { get; set; }

        public WorkoutDetailsWindow(Workout workout)
        {
            Workout = workout;
        }

        public void EditWorkout()
        {
            // Logik för att redigera träningspasset
            Console.WriteLine("Redigering av träningspasset");
        }

        public void SaveWorkout()
        {
            // Logik för att spara träningspasset
            Console.WriteLine("Workout details saved.");
        }
    }

}
