using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeComparison
{
    public class Employee
    {
        // Property to hold the unique identifier of the employee
        public int Id { get; set; }

        // Property to hold the first name of the employee
        public string FirstName { get; set; }

        // Property to hold the last name of the employee
        public string LastName { get; set; }

        // Overload the '==' operator to compare two Employee objects by their Id
        public static bool operator == (Employee emp1, Employee emp2)
        {
            // Compare the Id property of both Employee objects
            return emp1.Id == emp2.Id;
        }

        // Overload the '!=' operator to compare two Employee objects by their Id
        public static bool operator != (Employee emp1, Employee emp2)
        {
            // Return the negation of the '==' operator
            return !(emp1 == emp2);
        }
           
    }
}
