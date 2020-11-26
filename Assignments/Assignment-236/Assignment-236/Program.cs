using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_236
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1.4: Inside of the main method, instantiate and initialize an Employee object with a first name
            // of "Sample" and a last name of "Student".
            Employee employee = new Employee("Sample", "Student");

            // Step 1.5: Call the superclass method SayName() on the Employee object
            employee.SayName();
        }
    }
}
