using FitTrack.Classes.BaseClasses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private UserManagement manager;

        public User CurrentUser { get; private set; }
        public ObservableCollection<Workout> WorkoutList { get; set; }

        public Workout workout { get; set; }

        public List<Workout> workoutList { get; set; } = new List<Workout>();



        //public WorkoutsWindow()
        //{
        //    InitializeComponent();
        //}

        public WorkoutsWindow(UserManagement manager)  // Anropar parameterlös konstruktor
        {
            InitializeComponent();
            this.manager = manager;
            //CurrentUser = user; Lägg currentuser som property(egenskap) i manager klassen 


            WorkoutList = new ObservableCollection<Workout>(); // Initierar listan av träningspass

            //UpdateWorkoutList();
        }

        // Uppdaterar visningen av träningslistan (t.ex. i en ListView eller liknande)
        private void UpdateWorkoutList()
        {
            //WorkoutsListView.ItemsSource = null;  // Rensa befintliga objekt
            //WorkoutsListView.ItemsSource = WorkoutList;  // Sätt om datakällan
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    // Öppna fönstret för att lägga till ett nytt träningspass
    private void AddWorkout_Click(object sender, RoutedEventArgs e)
        {
            var addWorkoutWindow = new AddWorkoutsWindow(CurrentUser, manager); // Skapar nytt AddWorkoutWindow
                                                                                //addWorkoutWindow.Owner = this;
            this.Close();

            if (addWorkoutWindow.ShowDialog() == true) // Om användaren sparar träningspasset
            {
               
                if (addWorkoutWindow.NewWorkout != null) // Kontrollera om ett träningspass skapades
                {
                    WorkoutList.Add(addWorkoutWindow.NewWorkout);
                    // WorkoutList.Add(addWorkoutWindow.NewWorkout); // Lägg till träningspasset i listan
                    // UpdateWorkoutList();  // Uppdatera listan efter att träningspasset lagts till
                }
                else
                {
                    MessageBox.Show("Inget träningspass lades till.");
                }
            }
        }



        public void AddWorkoutToList(Workout workout)
        {
            workoutList.Add(workout);
            WorkoutListBox.ItemsSource = null;  // För att uppdatera listan, rensa och sätt den igen
            WorkoutListBox.ItemsSource = workoutList;
        }



        public static implicit operator WorkoutsWindow(WorkoutDetailsWindow v)
        {
            throw new NotImplementedException();
        }
    }

}