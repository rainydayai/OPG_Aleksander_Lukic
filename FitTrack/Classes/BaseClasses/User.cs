using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace FitTrack.Classes.BaseClasses
{
    public class User : Person
    {
        public string Country { get; set; }
        public string SecurityQuestion { get; set; }

        public string SecurityAnswer { get; set; }

        public override void SignIn()
        {
            Console.WriteLine("User signed in: " + Username);
        }

        public void ResetPassword(string securityAnswer)

        {
            if (securityAnswer == SecurityAnswer)

            {
                Console.WriteLine("Password reset successful.");


            }
            else
            {
                Console.WriteLine("Incorecct security answer.");
            }

        }

    }

}


