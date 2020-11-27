using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_255
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        /// <summary>
        /// Abstract method SayName() that must implement outputting of name to the console
        /// </summary>
        public abstract void SayName();
    }
}
