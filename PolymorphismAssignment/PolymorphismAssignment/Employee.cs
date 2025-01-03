using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    public class Employee : IQuittable //Creating the Employee class inheriting from the interface
    {
        public string FirstName { get; set; } //Adding some props to use with the Quit method
        public string LastName { get; set; }
        public void Quit() //Defining the Quit method we have predefined in the IQuittable interface and inherited from there
        {
            Console.WriteLine("Player quits playing: " + FirstName + " " + LastName); //Displaying some message with the params
        }
    }
}
