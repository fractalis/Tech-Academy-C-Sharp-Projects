using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_168
{
    class CarInsuranceCalculator
    {
        public int Age { get; private set; }
        public bool HadDui { get; private set; }
        public int SpeedingTickets { get; private set; }

        public CarInsuranceCalculator()
        {

        }
        

        /// <summary>
        /// Runs the script of prompting the user the three questions to determine
        /// eligibility for insurance.
        /// </summary>
        public void PromptUser()
        {
            GetAge();
            GetDUIStatus();
            GetSpeedingTickets();
        }

        /// <summary>
        /// Gets the users age
        /// </summary>
        private void GetAge()
        {
            Age = GetUserInputAsInteger("What is your age?");
        }


        /// <summary>
        /// Gets whether the users has had a DUI before
        /// </summary>
        private void GetDUIStatus()
        {
            HadDui = GetUserInputAsBool("Have you ever had a DUI?");
        }

        /// <summary>
        /// Gets the numbers of speeding tickets the user has
        /// </summary>
        private void GetSpeedingTickets()
        {
            SpeedingTickets = GetUserInputAsInteger("How many speeding tickets do you have?");
        }


        /// <summary>
        /// Determine if the person is qualified or not based on whether or not
        /// they are over the age of 15, have not had any DUIs, and have not had
        /// more than 3 speeding tickets.
        /// </summary>
        /// <returns></returns>
        public bool IsQualified()
        {
            return Age > 15 && !HadDui && SpeedingTickets <= 3;
        }


        /// <summary>
        /// Gets the user response as an integer, displaying an error message until valid input is entered
        /// </summary>
        /// <param name="prompt">The prompt to display to the user</param>
        /// <returns>The numerical value the user entered</returns>
        private int GetUserInputAsInteger(string prompt)
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
                    Console.WriteLine("Invalid value, please enter a valid number.");
                    continue;
                }
            }
        }

        /// <summary>
        /// Gets the user response as a boolean, displaying an error message until a valid input is entered.
        /// </summary>
        /// <param name="prompt">The prompt to display to the user</param>
        /// <returns>The boolean value the user entered</returns>
        private bool GetUserInputAsBool(string prompt)
        {
            Console.WriteLine(prompt);

            while(true)
            {
                try
                {
                    return Boolean.Parse(Console.ReadLine());
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("Invalid value, please enter \"true\" or \"false\".");
                    continue;
                }
            }
        }
    }
}
