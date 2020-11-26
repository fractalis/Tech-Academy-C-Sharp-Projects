using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_226
{
    class SimpleCalculator
    {
        public SimpleCalculator()
        {

        }

        /// <summary>
        /// Adds the given parameter to a random number and returns the result.
        /// </summary>
        /// <param name="x">The number we want to add a random number to</param>
        /// <returns>The sum of the random number and the parameter passed in</returns>
        public int Calculate(int x)
        {
            // Step 1.1 Create a method that will take in an integer, create a math operation for this
            // integer, then return the answer as an integer.
            Random random = new Random();
            return random.Next(1000) + x;
        }

        /// <summary>
        /// Cubes the given number
        /// </summary>
        /// <param name="x">The number we want to cube</param>
        /// <returns>The result of the cubed integer casted as an int</returns>

        public int Calculate(decimal x)
        {
            // Step 1.3: Add a second method to the class with the same name that will take in a decimal,
            // create a different math operation for it, then return the answer as an integer.
            return (int)(x * x * x);
        }

        /// <summary>
        /// Multiples the given input, parsed as an integer, by a random number between 0 and 1000
        /// </summary>
        /// <param name="inputStr">The input string to convert</param>
        /// <returns>The product of the parsed inputStr multiplied by a random number</returns>
        public int Calculate(string inputStr)
        {
            // Step 1.5: Add a third method to the class, with the same name, that will take in a string,
            // convert it to an integer if possible, do a different math operation to it, then return
            // the answer as an integer.
            Random random = new Random();
            int parsedInput = 0;
            try
            {
                parsedInput = Convert.ToInt32(inputStr);
                return random.Next(1000) * parsedInput;
            } catch(FormatException ex)
            {
                Console.WriteLine("Invalid input entered, please enter a number.");
                return 0;
            }
        }
    }
}
