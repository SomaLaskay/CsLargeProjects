using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    public class Employee : Person
    {
        public int EmployeeId { get; set; }  // The unique ID of the employee.
        public string Department { get; set; } // The department where the employee works.

        // Default constructor initializes properties with default values.
        public Employee() : base() // Calls the base class default constructor.
        {
            EmployeeId = 0;
            Department = "Unassigned";
        }

        // Parameterized constructor initializes all properties and chains to the base class constructor.
        public Employee(int employeeId, string department, string firstName, string lastName)
            : base(firstName, lastName) // Calls the parameterized constructor of the base class.
        {
            EmployeeId = employeeId;
            Department = department;
        }
    }
}
