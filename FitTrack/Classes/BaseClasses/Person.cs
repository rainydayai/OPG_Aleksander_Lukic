using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitTrack.Classes.BaseClasses
{
    public class Person
    {
        public string Username { get; set; }    
        public string Password { get; set; }

        public virtual void SignIn()
        {
            Console.WriteLine("Sign in as: " + Username);
        }
    }
}
