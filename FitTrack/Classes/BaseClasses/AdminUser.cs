using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitTrack.Classes.BaseClasses
{

    public class AdminUser : User
    {
        public void ManageAllWorkouts(List<Workout> workouts)
        {
            foreach (var workout in workouts)
            {
                Console.WriteLine("Managing workout: " + workout.Notes);
            }
        }
    }
