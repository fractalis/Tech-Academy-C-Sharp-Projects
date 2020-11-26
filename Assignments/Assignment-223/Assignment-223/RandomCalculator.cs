using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_223
{
    class RandomCalculator
    {
        private Random RandomGenerator { get; set; }

        public RandomCalculator()
        {
            RandomGenerator = new Random();
        }

        /// <summary>
        /// Adds a random number to the parameter passed in.
        /// </summary>
        /// <param name="x">The integer to which we add a random number to</param>
        /// <returns>The sum of a random number plus the parameter</returns>
        public int AddRandomNumber(int x)
        {
            return RandomGenerator.Next() + x;
        }

        /// <summary>
        /// Squares the number that is passed into the method
        /// </summary>
        /// <param name="x">The integer we want to square</param>
        /// <returns>The squared number</returns>
        public int SquareNumber(int x)
        {
            return x * x;
        }

        /// <summary>
        /// Calculates the nth Fibonacci number in the Fibonacci sequence
        /// </summary>
        /// <param name="x">The number we want to calculate the nth Fibonacci number for</param>
        /// <returns>The Fibonacci number for the given parameter</returns>
        public int Fibonacci(int x)
        {

            return FibonacciHelper(Math.Abs(x));

            int FibonacciHelper(int y)
            {
                if (y <= 1)
                {
                    return y;
                }
                else
                {
                    return FibonacciHelper(y - 1) + FibonacciHelper(y - 2);
                }
            }
        }
    }
}
