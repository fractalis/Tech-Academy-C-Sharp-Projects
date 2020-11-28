using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_272
{    
    public class Employee : Person
    {
        public int Id { get; set; }

        public Employee()
        {
        }
        /// <summary>
        /// Constructor which sets the full name of the employee along with their Id
        /// </summary>
        /// <param name="firstName">First name of the Employee</param>
        /// <param name="lastName">Last name of the Employee</param>
        /// <param name="id">Id of the Employee</param>
        public Employee(string firstName, string lastName, int id)
        {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
        }

        /// <summary>
        /// Returns if the two employee objects are equal based on their Id
        /// </summary>
        /// <param name="emp1">First Employee object we want to compare</param>
        /// <param name="emp2">Second Employee object we want to compare</param>
        /// <returns></returns>
        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return emp1.Id == emp2.Id;
        }

        /// <summary>
        /// Returns if the two employee objects are not equal based on their Id
        /// </summary>
        /// <param name="emp1">First Employee Object we want to compare</param>
        /// <param name="emp2">Second Employee object we want to compare</param>
        /// <returns></returns>
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return emp1.Id != emp2.Id;
        }

        /// <summary>
        /// Overriden method SayName() that outputs employees full name along with their id to the console
        /// </summary>
        public override void SayName()
        {
            Console.WriteLine($"Employee: {FirstName} {LastName} - ID: {Id}");
        }

        /// <summary>
        /// Determines if two objects of type Employee are equal in value
        /// </summary>
        /// <param name="obj">The object we want to determine if we're equal to</param>
        /// <returns>Whether the object is equal</returns>
        public override bool Equals(object obj)
        {
            return obj is Employee employee &&
                   FirstName == employee.FirstName &&
                   LastName == employee.LastName &&
                   Id == employee.Id;
        }

        /// <summary>
        /// Returns the hash of this object instance
        /// </summary>
        /// <returns>The hash of the object</returns>
        public override int GetHashCode()
        {
            int hashCode = -1886626288;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FirstName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LastName);
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            return hashCode;
        }
    }
}
