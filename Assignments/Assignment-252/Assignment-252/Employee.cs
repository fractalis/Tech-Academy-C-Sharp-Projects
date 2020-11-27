using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_252
{
    public class Employee : Person
    {
        public int Id { get; set; }

        /// <summary>
        /// Constructor that accepts first and last name as well as id and constructs an Employee object appropriately
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
        public static bool operator==(Employee emp1, Employee emp2)
        {
            return emp1.Id == emp2.Id;
        }

        /// <summary>
        /// Returns if the two employee objects are not equal based on their Id
        /// </summary>
        /// <param name="emp1">First Employee Object we want to compare</param>
        /// <param name="emp2">Second Employee object we want to compare</param>
        /// <returns></returns>
        public static bool operator!=(Employee emp1, Employee emp2)
        {
            return emp1.Id != emp2.Id;
        }

        public override void SayName()
        {
            Console.WriteLine($"Employee: {FirstName} {LastName}");
        }

        /// <summary>
        /// Override the Equals method to see if two Employee objects are equal
        /// </summary>
        /// <param name="obj">Object that is of Type Employee</param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            return obj is Employee employee &&
                   FirstName == employee.FirstName &&
                   LastName == employee.LastName &&
                   Id == employee.Id;
        }

        /// <summary>
        /// Overrides the GetHashCode() method returning Hashcode of an instance of this object.
        /// </summary>
        /// <returns>The hash of this object</returns>
        public override int GetHashCode()
        {
            int hashCode = 1258739292;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(FirstName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(LastName);
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            return hashCode;
        }
    }
}
