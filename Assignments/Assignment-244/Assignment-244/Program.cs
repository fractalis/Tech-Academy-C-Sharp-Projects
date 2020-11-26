using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_244
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1.5 "Instantiate an Employee object with firstName "Sample" and lastName "Student"..."
            Employee employee = new Employee("Sample", "Student");

            // Step 1.5 "...Call the SayName() method on the object."
            employee.SayName();

            // Wait for user input before exiting the program
            Console.ReadLine();
        }
    }
}
