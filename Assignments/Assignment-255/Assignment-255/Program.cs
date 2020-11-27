using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_255
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1.3 Instantiate an Employee object with type "string" as its generic parameter. Assign a list of strings as
            // the property value of Things.
            Employee<string> employeeString = new Employee<string>()
            {
                FirstName = "Samuel",
                LastName = "Summers",
                Id = 1,
                Things = new List<string>
                {
                    "Management",
                    "Engineering",
                    "Operations"
                }
            };

            // Step 1.4 Instantiate an Employee Object with type "int" as its generic parameter. Assign a list of integers as
            // the property Value of Things.
            Employee<int> employeeInt = new Employee<int>()
            {
                FirstName = "John",
                LastName = "Winters",
                Id = 2,
                Things = new List<int>
                {
                    45_000,
                    55_000,
                    65_000
                }
            };

            // Step 1.5 Create a loop that prints all of the Things to the Console
            foreach(string department in employeeString.Things)
            {
                Console.WriteLine($"Department: {department}");
            }

            foreach (int salaryHistory in employeeInt.Things)
            {
                Console.WriteLine($"Salary History: {salaryHistory}");
            }

            Console.ReadLine();
        }
    }
}
