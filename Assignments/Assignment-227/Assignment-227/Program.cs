using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_227
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            int firstUserInput = GetUserInputAsInteger("Please enter the first number: ");

            int secondUserInput;

            bool didUserRespond = GetOptionalUserInputAsInteger("Please enter a second number (this number is optional): ", out secondUserInput);
            
            if( didUserRespond )
            {
                Console.WriteLine($"The hypotenuse of the triangle with given sides {firstUserInput} and {secondUserInput} " +
                    $"is approximately {calculator.CalculateHypotenuse(firstUserInput, secondUserInput)}");
            } else
            {
                Console.WriteLine($"The hypotenuse of the triangle with a side {firstUserInput} and the default value is approximately " +
                    $"{calculator.CalculateHypotenuse(firstUserInput)}");
            }
            Console.ReadLine();
        }

        /// <summary>
        /// Gets optional user input as integer, storing the result in an out variable and returning true or false
        /// depending on whether or not the user responded.
        /// </summary>
        /// <param name="prompt">The prompt we want to display</param>
        /// <param name="result">The parsed integer value the user entered, an out variable.</param>
        /// <returns>Whether or not the user responded or not.</returns>
        public static bool GetOptionalUserInputAsInteger(string prompt, out int result)
        {
            Console.WriteLine(prompt);

            while(true)
            {
                try
                {
                    string userInput = Console.ReadLine();
                    // If user input is empty, then we return false and set out result to 0.
                    if (userInput == "")
                    {
                        result = 0;
                        return false;
                    }

                    // Set result to the parsed userInput and return true.
                    result = Convert.ToInt32(userInput);
                    return true;
                } catch(FormatException ex)
                {
                    Console.WriteLine("Invalid value, please enter a valid value");
                    continue;
                }
            }
        }

        /// <summary>
        /// Gets user input as integer
        /// </summary>
        /// <param name="prompt">The prompt we want to display to the user</param>
        /// <returns>The parsed integer that the user entered.</returns>
        public static int GetUserInputAsInteger(string prompt)
        {
            Console.WriteLine(prompt);
            while(true)
            {
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("Invalid format, please enter a valid number: ");
                    continue;
                }
            }
        }
    }
}
