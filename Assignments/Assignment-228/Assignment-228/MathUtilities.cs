using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_228
{
    public class MathUtilities
    {
        public MathUtilities()
        {

        }

        /// <summary>
        /// Calculates the factorial of a number and prints out the value of the second parameter passed in
        /// </summary>
        /// <param name="x">The value which we calculate the factorial of</param>
        /// <param name="y">The value we display to the screen</param>
        public void CalculateFactorial(int x, int y)
        {

            // Step 1.1 IN that class, create a void method that takes two integers as parameters.
            // Have the method do a math operation on the first integer.
            double factorialOfX = FactorialHelper(x, 1.0);

            // Declare an inline function to act as a helper
            // method for calculating the factorial of a number.
            double FactorialHelper(int factor, double acc)
            {
                if (factor == 0)
                {
                    return acc;
                } else
                {
                   return FactorialHelper(factor - 1, acc * factor);
                }
            }

            // Step 1.1 ".. and display the second integer to the screen"
            Console.WriteLine($"Value of second argument: {y}");
        }
    }
}
