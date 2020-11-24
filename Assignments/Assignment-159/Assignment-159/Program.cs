using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_159
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            HourlyIncomeCalculator hourlyIncomeCalc = new HourlyIncomeCalculator();

            for(int i = 0; i < 2; i++) {
                // Which Person Are we dealing with?
                Console.WriteLine("Person " + (i + 1).ToString());
                // Add Pay info
                hourlyIncomeCalc.AddPayInfo();
            }

            // Get Annual salaries
            var salaries = hourlyIncomeCalc.GetAnnualSalaries();

            // Create anonymous type that has value in Value and index in Index.
            foreach(var payInfo in salaries.Select((x, i) => new { Value = x, Index = i }))
            {
                // Display Annual Salary of the Person
                Console.WriteLine("Annual salary of Person " + (payInfo.Index + 1).ToString());
                Console.WriteLine($"{payInfo.Value:N0}");
            }

            // Query if Person 1 makes More than person 2
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(hourlyIncomeCalc.DoesPersonXMakeMoreThanPersonY(1, 2).ToString());

            Console.ReadLine();
        }
    }
}
