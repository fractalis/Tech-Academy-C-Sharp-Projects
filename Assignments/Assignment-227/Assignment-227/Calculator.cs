using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_227
{
    class Calculator
    {
        public Calculator()
        {

        }

        /// <summary>
        /// Calculates the hypotenuse of a triangle given by the two sides
        /// </summary>
        /// <param name="x">Side A of the triangle</param>
        /// <param name="y">Side B of the triangle</param>
        /// <returns>The approximate hypotenuse</returns>
        public int CalculateHypotenuse(int x, int y = 1)
        {
            return (int)Math.Floor(Math.Sqrt(x * x + y * y));
        }
    }
}
