using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { firstName = "Sample", lastName = "Student"}; //Creating a new Employee object with the given parameters
            employee.SayName(); //Calling the SayName method on the new Employee object that we had to define

            Console.ReadLine();
        }
    }
}
