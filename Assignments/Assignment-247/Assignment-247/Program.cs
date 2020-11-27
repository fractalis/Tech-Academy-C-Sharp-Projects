using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_247
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1.3 Use polymorphism to create an object of type IQuittable and call the Quit() method on it.
            IQuittable employee = new Employee("Sample", "Student", 56_000M);

            employee.Quit();

            Console.ReadLine();
        }
    }
}
