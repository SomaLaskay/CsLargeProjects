using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComparison
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create two Employee objects with the same Id
            Employee emp1 = new Employee { Id = 1, FirstName = "John", LastName = "Doe" };
            Employee emp2 = new Employee { Id = 5, FirstName = "Jane", LastName = "Smith" };
            
            // Compare emp1 and emp2 using the overloaded '==' operator
            Console.WriteLine($"emp1 == emp2: {emp1 == emp2}"); // Output: True
            
            Console.ReadLine();
        }
    }
}
