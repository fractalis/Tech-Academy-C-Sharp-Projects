using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_228
{
    class Program
    {
        static void Main(string[] args)
        {
            MathUtilities mathUtilities = new MathUtilities();
            Random random = new Random();

            // Step 1.3 Call the method in the class, passing in two numbers
            mathUtilities.CalculateFactorial(random.Next(100), random.Next(100));

            // Step 1.4 Call the method in the class, specifying the parameters by name
            mathUtilities.CalculateFactorial(x: random.Next(100), y: random.Next(100));
            Console.ReadLine();
        }
    }
}
