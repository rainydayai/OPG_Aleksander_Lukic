﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitTrack
{
    // WorkoutDetailsWindow hanterar visning och redigering av detaljer för träningspass
    public class WorkoutDetailsWindowClass
    {
        private Workout workout;

        public WorkoutDetailsWindow(Workout selectedWorkout)
        {
            workout = selectedWorkout;
        }

        public void EditWorkout()
        {
            // Logik för att redigera träningspasset
            Console.WriteLine("Redigering av träningspass.");
        }
    }
}