using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Employee : Person //Created the Employee class, inherited from the Person abstract class
    {
        public override void SayName() //Creating the abstract method
        {
            Console.WriteLine("Name: " + firstName + " " + lastName); //Defining the SayName method as the abstract one in the abstract class Person makes us
        }
    }
}
