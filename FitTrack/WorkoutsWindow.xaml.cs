using FitTrack.Classes.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace FitTrack
{
    /// <summary>
    /// Interaction logic for WorkoutsWindow.xaml
    /// </summary>
    //public partial class WorkoutsWindow : Window
    //{
    //    public WorkoutsWindow()
    //    {
    //        InitializeComponent();
    //    }
    //        public User CurrentUser { get; private set; }
    //        public List<Workout> WorkoutList { get; private set; }

    //        public WorkoutsWindow(User user)
    //        {
    //            InitializeComponent();
    //            CurrentUser = user;
    //            WorkoutList = new List<Workout>(); // Initiell lista av träningspass
    //            UpdateWorkoutList();
    //        }

    //        // Uppdaterar visningen av träningslistan (t.ex. i en ListView eller liknande)
    //        private void UpdateWorkoutList()
    //        {
    //            // Här skulle du uppdatera din ListView eller annan kontroll som visar träningspassen
    //            // Exempel: WorkoutsListView.ItemsSource = WorkoutList;
    //        }

    //        // Öppna fönstret för att lägga till ett nytt träningspass
    //        private void AddWorkout_Click(object sender, RoutedEventArgs e)
    //        {
    //            var addWorkoutWindow = new AddWorkoutsWindow(); // Skapar nytt AddWorkoutWindow
    //            addWorkoutWindow.Owner = this;

    //            if (addWorkoutWindow.ShowDialog() == true) // Om användaren sparar träningspasset
    //            {
    //                if (addWorkoutWindow.NewWorkout != null) // Kontrollera om ett träningspass skapades
    //                {
    //                    WorkoutList.Add(addWorkoutWindow.NewWorkout); // Lägg till träningspasset i listan
    //                    UpdateWorkoutList(); // Uppdatera träningslistan
    //                }
    //            }
    //        }

    //        // Tar bort ett träningspass (om du har en knapp för detta)
    //        private void RemoveWorkout_Click(object sender, RoutedEventArgs e)
    //        {
    //            // Här kan du implementera logiken för att ta bort ett träningspass från WorkoutList
    //        }

    //        // Öppnar ett fönster för att se detaljer om ett valt träningspass
    //        private void OpenDetails_Click(object sender, RoutedEventArgs e)
    //        {
    //      /*  var selectedWorkout =*/ /* logik för att få det valda träningspasset */
    //            //if (selectedWorkout != null)
    //            {
    //                var workoutDetailsWindow = new WorkoutDetailsWindow(selectedWorkout);
    //                workoutDetailsWindow.Owner = this;
    //                workoutDetailsWindow.ShowDialog();
    //            }
    //        }
    //    }
    //}

    public partial class WorkoutsWindow : Window
    {
        public User CurrentUser { get; private set; }
        public List<Workout> WorkoutList { get; private set; }

        public WorkoutsWindow()
        {
            InitializeComponent();
        }

        public WorkoutsWindow(User user) : this() // Anropar parameterlös konstruktor
        {
            CurrentUser = user;
            WorkoutList = new List<Workout>(); // Initierar listan av träningspass
            UpdateWorkoutList();
        }

        // Uppdaterar visningen av träningslistan (t.ex. i en ListView eller liknande)
        private void UpdateWorkoutList()
        {
            //WorkoutsListView.ItemsSource = null;  // Rensa befintliga objekt
            //WorkoutsListView.ItemsSource = WorkoutList;  // Sätt om datakällan
        }

        // Öppna fönstret för att lägga till ett nytt träningspass
        private void AddWorkout_Click(object sender, RoutedEventArgs e)
        {
            var addWorkoutWindow = new AddWorkoutsWindow(); // Skapar nytt AddWorkoutWindow
            addWorkoutWindow.Owner = this;

            if (addWorkoutWindow.ShowDialog() == true) // Om användaren sparar träningspasset
            {
                if (addWorkoutWindow.NewWorkout != null) // Kontrollera om ett träningspass skapades
                {
                    WorkoutList.Add(addWorkoutWindow.NewWorkout); // Lägg till träningspasset i listan
                    UpdateWorkoutList();  // Uppdatera listan efter att träningspasset lagts till
                }
                else
                {
                    MessageBox.Show("Inget träningspass lades till.");
                }
            }
        }

        public static implicit operator WorkoutsWindow(WorkoutDetailsWindow v)
        {
            throw new NotImplementedException();
        }
    }

}


