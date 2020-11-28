using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_272
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1.1 In the Main() method, create a list of at least 10 employees. Each employee should have a first
            // and last name, as well as an Id. At least two employees should have the first name "Joe".
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { FirstName = "Joe", LastName = "Winters", Id = 1 },
                new Employee() { FirstName = "Ethan", LastName = "Hall", Id = 2 },
                new Employee() { FirstName = "Spencer", LastName = "Fox", Id = 3 },
                new Employee() { FirstName = "Joe", LastName = "Macdonald", Id = 4 },
                new Employee() { FirstName = "Dominic", LastName = "Bailey", Id = 5 },
                new Employee() { FirstName = "Emilia", LastName = "Walker", Id = 6 },
                new Employee() { FirstName = "Shannon", LastName = "Wells", Id = 7 },
                new Employee() { FirstName = "Abbie", LastName = "Lowe", Id = 8 },
                new Employee() { FirstName = "Faith", LastName = "Harper", Id = 9 },
                new Employee() { FirstName = "Charlotte", LastName = "Francis", Id = 10 }
            };

            // Step 1.2 Using a foreach loop, create a new list of all employees with the first name "Joe"
            List<Employee> joes = new List<Employee>();
            foreach( Employee employee in employees )
            {
                if(employee.FirstName == "Joe")
                {
                    joes.Add(employee);
                }
            }

            Console.WriteLine("==> Employees named Joe using a Foreach Loop");
            foreach( Employee joe in joes)
            {
                joe.SayName();
            }

            // Step 1.3 Perform the same action again, but this time with a lambda expression
            List<Employee> joesLambda = employees.Where(e => e.FirstName == "Joe").ToList();

            Console.WriteLine();
            Console.WriteLine("==> Employees named Joe using a Lambda Expression");
            foreach (Employee joe in joes)
            {
                joe.SayName();
            }

            // Step 1.4 Using a lambda expression, make a list of all employees with an Id number greater than 5.
            List<Employee> idsGreaterThanFive = employees.Where(e => e.Id > 5).ToList();

            Console.WriteLine();
            Console.WriteLine("==> Employees with Id greater than 5");
            foreach (Employee employee in idsGreaterThanFive)
            {
                employee.SayName();
            }

            Console.ReadLine();
        }
    }
}
