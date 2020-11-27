using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_247
{

    /// <summary>
    /// Implements an Employee which is-a Person
    /// </summary>
    public class Employee : Person, IQuittable
    {

        public decimal Salary { get; private set; }

        /// <summary>
        /// Constuctor that accepts a first and last name and sets the name appropriately.
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        public Employee(string firstName, string lastName, decimal salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }

        /// <summary>
        /// Outputs the full name of the Employee to the Console
        /// </summary>
        public override void SayName()
        {
            Console.WriteLine($"Employee: {FirstName} {LastName} - Salary: {Salary}");
        }

        // Step 1.2 Have your Employee class from the previous drill inherit from that interface and
        // Implement the Quit() method in any way you choose.
        /// <summary>
        /// Terminates the Employees position at the current company
        /// </summary>
        public void Quit()
        {
            Salary = 0.0M;
            Console.WriteLine($"Employee: {FirstName} {LastName} quit. Terminating Benefits and Salary.");
        }
    }
}
