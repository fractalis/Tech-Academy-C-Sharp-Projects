using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_190
{
    class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public List<string> EmailAddresses { get; private set; }

        public Person()
        {
            FirstName = "John";
            LastName = "Doe";
            EmailAddresses = new List<string>();
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            EmailAddresses = new List<string>();
        }

        public void AddEmailAddress(string email)
        {
            EmailAddresses.Add(email);
        }

        public void DisplayEmailAddresses()
        {
            foreach(string email in EmailAddresses)
            {
                Console.WriteLine($"Email: {email}");
            }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
