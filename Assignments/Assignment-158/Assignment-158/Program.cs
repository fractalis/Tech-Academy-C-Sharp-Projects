using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_158
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleCalculator simpleCalculator = new SimpleCalculator();

            // Run the Simple Calculator
            simpleCalculator.Run();

            // Wait for user input before ending program
            Console.ReadLine();
        }
    }
}
