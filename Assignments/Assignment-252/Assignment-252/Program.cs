using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_252
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee("Sample", "Student", 1);
            Employee employee2 = new Employee("Sample", "Student", 1);

            Console.WriteLine($"Employee 1 and Employee 2 are equal: {employee1 == employee2}");

            Employee employee3 = new Employee("John", "Winters", 2);

            Console.WriteLine($"Employee 1 and Employee 3 are equal: {employee1 == employee3}");

            Console.ReadLine();
        }
    }
}
