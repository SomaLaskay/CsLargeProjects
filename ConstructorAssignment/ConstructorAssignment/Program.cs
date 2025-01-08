using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            // A constant variable that cannot be modified during runtime.
            const string CompanyName = "Copper Stone Co.";

            // A "var" variable, whose type is inferred from the assigned value.
            var currentYear = DateTime.Now.Year;

            // Display company information on the console.
            Console.WriteLine($"Welcome to {CompanyName}, established in {currentYear}!\n");

            // Create a new Employee object using the parameterized constructor.
            Employee employee = new Employee(101, "IT", "John", "Doe");

            // Display the Employee's details.
            Console.WriteLine("Employee Information:");
            Console.WriteLine($"Name: {employee.FirstName} {employee.LastName}");
            Console.WriteLine($"ID: {employee.EmployeeId}");
            Console.WriteLine($"Department: {employee.Department}");

            Console.ReadLine();
        }
    }

}
