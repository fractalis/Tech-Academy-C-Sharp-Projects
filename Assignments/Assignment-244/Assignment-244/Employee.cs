using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_244
{
    // Step 1.3 Create another class called Employee and have it inherit from the Person class
    /// <summary>
    /// Implements an Employee which is-a Person.
    /// </summary>
    class Employee : Person
    {
        /// <summary>
        /// Constructor that accepts a first and last name and sets the names appropriately.
        /// </summary>
        /// <param name="firstName">First name of the Employee</param>
        /// <param name="lastName">Last name of the employee</param>
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        /// <summary>
        /// Outputs the full name of the Employee to the Console
        /// </summary>
        public override void SayName()
        {
            // Step 1.4 Implement the SayName() method inside of the Employee Class.
            Console.WriteLine($"Employee: {FirstName} {LastName}");
        }
    }
}
