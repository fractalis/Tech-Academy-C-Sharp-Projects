using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_247
{
    /// <summary>
    /// Declare an abstract class for representing a Person
    /// </summary>
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        /// <summary>
        /// Abstract method SayName() that must implement outputting of the name to the console.
        /// </summary>
        public abstract void SayName();
    }
}
