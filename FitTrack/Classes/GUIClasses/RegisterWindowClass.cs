using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitTrack.Classes.GUIClasses
{
    public class RegisterWindowClass
    {
        public string UsernameInput {  get; set; }
        public string PasswordInput { get; set; }
        public string ConfirmPasswordInput { get; set; }
        public string CountryComboBox { get; set; }

        public void RegisterNewUser()
        {

            Console.WriteLine("Användare registrerad.");


        }
    }
}
