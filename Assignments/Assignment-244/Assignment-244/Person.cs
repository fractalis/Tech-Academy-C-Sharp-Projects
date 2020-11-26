using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_244
{
    // Step 1.1: Create an abstract class called Person with two properties, string firstName and string lastName
    /// <summary>
    /// Declares an abstract class for representing a Person
    /// </summary>
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Step 1.2 Give it the method SayName()
        /// <summary>
        /// Abstract method SayName() that must implement outputting of the name to the console.
        /// </summary>
        public abstract void SayName();
    }
}
