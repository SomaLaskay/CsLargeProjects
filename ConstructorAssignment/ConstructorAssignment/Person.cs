using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Person
    {
        public string FirstName { get; set; } // The first name of the person.
        public string LastName { get; set; }  // The last name of the person.

        // Default constructor initializes properties with default values.
        public Person()
        {
            FirstName = "Unknown";
            LastName = "Unknown";
        }

        // Parameterized constructor allows setting the first and last name.
        public Person(string firstName, string lastName) : this() // Chaining to the default constructor.
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
