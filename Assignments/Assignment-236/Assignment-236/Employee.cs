using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_236
{
    public class Employee : Person
    {
        public int Id { get; set; }

        /// <summary>
        /// Base constructor for the Employee class, calls superclass constructor and initializes id.
        /// </summary>
        public Employee() : base()
        {
            Id = 0;
        }

        /// <summary>
        /// Constructor that takes first and last name and initializes an Employee object.
        /// </summary>
        /// <param name="firstName">First name of the employee</param>
        /// <param name="lastName">Last name of the employee</param>
        public Employee(string firstName, string lastName) : base(firstName, lastName)
        {
            Id = 0;
        }

        /// <summary>
        /// Constructors that takes first and last name, as well as id, and intializes an Employee object
        /// </summary>
        /// <param name="firstName">First name of the employee</param>
        /// <param name="lastName">Last name of the employee</param>
        /// <param name="id">Id to give to the employee</param>
        public Employee(string firstName, string lastName, int id) : base(firstName, lastName)
        {
            Id = id;
        }
    }
}
