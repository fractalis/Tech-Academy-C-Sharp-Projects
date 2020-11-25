using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_187
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Employee("Bob", "Summers");

            switch (person)
            {
                case Employee e:
                    Console.WriteLine("Employee: " + e.FirstName);
                    break;
                case Manager m:
                    Console.WriteLine("Manager: " + m.FirstName);
                    break;
                case Director d:
                    Console.WriteLine("Director: " + d.FirstName);
                    break;
                default:
                    Console.WriteLine("Unknown person type");
                    break;
            }

            Console.ReadLine();
        }
    }
}
