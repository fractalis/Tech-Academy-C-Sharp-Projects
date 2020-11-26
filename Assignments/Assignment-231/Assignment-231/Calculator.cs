using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_231
{
    public class Calculator
    {
        public Calculator()
        {

        }

        /// <summary>
        /// Divides the given number by 2 and outputs the result to the console
        /// </summary>
        /// <param name="x">The number we want to divide two by</param>
        public void DivideByTwo(int x)
        {
            int dividedByTwo = x / 2;
            Console.WriteLine($"{x} divided by 2 equals = {dividedByTwo}");
        }

        /// <summary>
        /// Multiplies the first parameter by the second parameter, storing the result in the output variable `result`
        /// </summary>
        /// <param name="x">The number we want to multiply</param>
        /// <param name="y">The number we want to multiply by</param>
        /// <param name="result">The result of the division</param>
        public void MultiplyBy(int x, int y, out int result)
        {
            result = x * y;
        }

        /// <summary>
        /// Multiplies the first parameter by the second parameter, storing the result in the output variable `result`
        /// </summary>
        /// <param name="x">The number we want to multiply</param>
        /// <param name="y">The number we want to multiply by</param>
        /// <param name="result">The result of the multiplication</param>
        public void MultiplyBy(double x, double y, out double result)
        {
            result = x * y;
        }
    }
}
