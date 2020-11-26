using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_236
{
    /// <summary>
    /// Base class representing a person
    /// </summary>
    public class Person
    {
        // Step 1.1 Create a class called Person and give it two properties, each of data type string.
        // One called FirstName, the other LastName
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person()
        {
            FirstName = "John";
            LastName = "Doe";
        }

        /// <summary>
        /// Constructs a person with the given first and last name
        /// </summary>
        /// <param name="firstName">First name of the person</param>
        /// <param name="lastName">Last name of the person</param>
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        /// <summary>
        /// Writes out the Persons Full Name to the Console
        /// </summary>
        public void SayName()
        {
            Console.WriteLine($"Name: {FirstName} {LastName}");
        }
    }
}
