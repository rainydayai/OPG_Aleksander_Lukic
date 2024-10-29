using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitTrack.Classes.GUIClasses
{
    public class MainWindowClass
    {
        public string LabelTitle { get; set; }
        public string UsernameInput { get; set; }
        public string PasswordInput { get; set; }

        public void SignIn()

        {

            Console.WriteLine("Inloggningsmetod anropad i MainWindow. ");
        }

        public void Register()
        {
            RegisterWindowClass registerWindow = new RegisterWindowClass();
            registerWindow.RegisterNewUser();
            
        }
    }
}





