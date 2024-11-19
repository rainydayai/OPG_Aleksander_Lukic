using FitTrack.Classes.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitTrack.Classes.GUIClasses
{
    public class WorkoutsWindowClass { 
    
        public User User { get; set; }
        public List<Workout> WorkoutList { get; set; }

        public WorkoutsWindowClass()
        {
            WorkoutList = new List<Workout>();
        }
        public void AddWorkout(Workout workout)
        {
            WorkoutList.Add(workout);
            Console.WriteLine("Träningspass tillagt.");
        }

        public void RemoveWorkout(Workout workout)
        {
            WorkoutList.Remove(workout);
            Console.WriteLine("Träningspass borttaget.");
        }

        public void OpenDetails(Workout workout)
        {
            // Öppna detaljfönster för det valda träningspasset
            WorkoutDetailsWindow detailsWindow = new WorkoutDetailsWindow(workout);
            detailsWindow.EditWorkout();
        }
    }
}
