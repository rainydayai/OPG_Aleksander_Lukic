using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitTrack.Classes.BaseClasses
{
    public class UserManagement
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Country { get; set; }
        public List<Workout> Workouts { get; set; } = new List<Workout>();

        public static List<User> Users { get; set; }

        public UserManagement()
        {
            Users = new List<User>() { new User {Username = "Alex", Password = "123", Country = "Sverige", } };
        }
        public bool SignIn(string username, string password)
        {
            return username == Username && password == Password;
        }

        public void AddWorkout(Workout workout)
        {
            Workouts.Add(workout);
        }

        public void ResetPassword(string securityAnswer, string newPassword)
        {
            // Logik för att återställa lösenord
        }
    }
}