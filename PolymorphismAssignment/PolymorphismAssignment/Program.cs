using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IQuittable polyQuit = new Employee() { FirstName = "Sample", LastName = "Student" }; //Instantiating a polymorph object from the interface with the type of Employee
            polyQuit.Quit(); //Calling the inherited method on the object

            Console.ReadLine();
        }
    }
}
