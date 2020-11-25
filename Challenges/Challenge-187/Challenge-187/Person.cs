using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_187
{
    public class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public List<String> EmailAddresses { get; private set; }

        public Person()
        {
            EmailAddresses = new List<String>();
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void AddEmailAddress(string email)
        {
            EmailAddresses.Add(email);
        }
    }
}
