using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parameters_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>(); //Instantiate the class as string
            employee.things.Add("Something"); //Adding some elements
            employee.things.Add("Anything");
            employee.things.Add("Everything");

            Employee<int> employee1 = new Employee<int>(); //Instantiate the class as string
            employee1.things.Add(25); //Adding some elements
            employee1.things.Add(13);
            employee1.things.Add(55);

            Console.WriteLine("String things:"); //Displaying the string contents of things
            foreach (var thing in employee.things)
            {
                Console.WriteLine(thing);
            }

            Console.WriteLine("\nInteger things:"); //Displaying the int contents of things
            foreach (var thing in employee1.things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();
        }
    }
}
