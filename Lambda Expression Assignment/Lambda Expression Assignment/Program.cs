using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lambda_Expression_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> register = new List<Employee>() //Creating a list of Employees
            {
                new Employee() { Id = 1, FirstName = "Albert", LastName = "Ember" },
                new Employee() { Id = 2, FirstName = "Bob", LastName = "Florian" },
                new Employee() { Id = 3, FirstName = "Charlie", LastName = "Greek" },
                new Employee() { Id = 4, FirstName = "Daniel", LastName = "Hunter" },
                new Employee() { Id = 5, FirstName = "Joe", LastName = "Irvine" },
                new Employee() { Id = 6, FirstName = "Joe", LastName = "Jones" },
                new Employee() { Id = 7, FirstName = "Greg", LastName = "Kelvin" },
                new Employee() { Id = 8, FirstName = "Jennifer", LastName = "Lawrence" },
                new Employee() { Id = 9, FirstName = "Ernest", LastName = "Mendes" },
                new Employee() { Id = 10, FirstName = "Hugh", LastName = "North" }
            };


            List<Employee> joes = new List<Employee>(); //Creating a list just for Joes

            foreach (Employee employee in register) //Adding the Joes to our list of Joes
            {
                if (employee.FirstName == "Joe")
                {
                    joes.Add(employee);
                }
            }

            List<Employee> joes2 = register.Where(x => x.FirstName == "Joe").ToList(); //Doing the same but with lambda expression

            List<Employee> moreThan5 = register.Where(x => x.Id > 5).ToList(); //Creating a list for Id5s and adding items to it with lambda

            foreach ( Employee joe in moreThan5 ) //Printing out the employees of the lists (change the name of the list)
            {
                Console.WriteLine($"{joe.FirstName} {joe.LastName} ID: {joe.Id}");
            }


            Console.ReadLine();
        }
    }
}
