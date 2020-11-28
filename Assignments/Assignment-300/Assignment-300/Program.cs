using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_300
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1.1 Prints the current date and time to the console
            DateTime now = DateTime.Now;

            Console.WriteLine("==> The Current Time");
            Console.WriteLine($"The Current Time is: {now.ToString()}");

            // Step 1.2 Asks the user for a number
            Console.WriteLine();
            int userInput = GetUserInputAsInteger("Please enter the number of hours you want to add to the current time: ");


            // Step 1.3 Prints to the console the exact time it will be in X hours, X being the number the user entered in Step 2.
            TimeSpan userDuration = new TimeSpan(userInput, 0, 0);
            DateTime then = now + userDuration;
            Console.WriteLine();
            Console.WriteLine($"==> The Time in {userInput} hours");
            Console.WriteLine($"The time in {userInput} hours is {then.ToString()}.");

            Console.ReadLine();
        }

        /// <summary>
        /// Gets the user input as an integer, continuing until the user enters a valid number.
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        static int GetUserInputAsInteger(string prompt)
        {
            Console.Write(prompt);

            while(true)
            {
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch(FormatException)
                {
                    Console.WriteLine("Invalid value, please enter a number");
                    continue;
                }
            }
        }
    }
}
