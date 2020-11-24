using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_158
{
    class SimpleCalculator
    {
        public SimpleCalculator()
        {

        }

        /// <summary>
        /// Runs through the sequence of steps in the assignment
        /// </summary>
        public void Run()
        {
            MultiplyBy();
            AddTo();
            DivideBy();
            CheckIfGreaterThan50();
            DivideAndDisplayRemainder();
        }

        /// <summary>
        /// Gets user input and multiples the number by 50
        /// </summary>
        private void MultiplyBy()
        {
            int userInput = GetUserInputAsInteger();
            // Multiply userInput * 50
            int result = userInput * 50;

            Console.WriteLine($"{userInput} * 50 = {result}");
        }

        /// <summary>
        /// Get user input and adds 25 to it.
        /// </summary>
        private void AddTo()
        {
            int userInput = GetUserInputAsInteger();
            // Add 25 to userInput
            int result = userInput + 25;

            Console.WriteLine($"{userInput} + 25 = {result}");
        }

        /// <summary>
        /// Gets user input and divides it by 12.5, printing the result to 3 decimal points.
        /// </summary>
        private void DivideBy()
        {
            int userInput = GetUserInputAsInteger();
            // Divide userInput, casted as a double, by 12.5
            double result = (double)userInput / 12.5;

            // Format result to 3 decimal places
            Console.WriteLine($"{userInput} / 12.5 = {result:N3}");
        }

        /// <summary>
        /// Gets user input and checks if its greater than 50, printing out the result
        /// </summary>
        private void CheckIfGreaterThan50()
        {
            int userInput = GetUserInputAsInteger();
            bool isGreaterThan50 = userInput > 50;

            Console.WriteLine($"{userInput} > 50 = {isGreaterThan50}");

        }

        /// <summary>
        /// Gets user input and prints the remainder of dividing it by 7.
        /// </summary>
        private void DivideAndDisplayRemainder()
        {
            int userInput = GetUserInputAsInteger();
            int remainder = userInput % 7;
            Console.WriteLine($"The remainder of {userInput}  / 7 is {remainder}");
        }

        /// <summary>
        /// Gets user input, looping continuously if invalid input is entered
        /// </summary>
        /// <returns></returns>
        private int GetUserInputAsInteger()
        {
            Console.WriteLine("Please enter an integer: ");
            // While invalid input is entered, continue to read from the user enter
            // we can return a valid number.
            while (true)
            {
                try
                {    
                    return Convert.ToInt32(Console.ReadLine());
                } 
                catch( FormatException ex)
                {
                    Console.WriteLine("Invalid input, please enter a valid integer:");
                    continue;
                }
            }
        }

    }
}
