using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_314
{
    class AgeCalculator
    {
        public AgeCalculator()
        {

        }

        /// <summary>
        /// First gets the users age as an integer, then calculates the users birthdate using
        /// the current datetime as a reference point.
        /// </summary>
        /// <returns></returns>
        public DateTime CalculateUsersAge()
        {
            try
            {
                int usersAge = GetUsersAgeAsInteger("Please enter your age: ");
                TimeSpan usersAgeInDays = new TimeSpan(YearsToDays(usersAge), 0, 0, 0);

                DateTime usersBirthday = DateTime.Now - usersAgeInDays;

                return usersBirthday;
            }
            catch(Exception ex)
            {
                Console.WriteLine("An error occurred - please contact the developer of this program.");
                throw ex;
            }
        }

        /// <summary>
        /// Converts the number of years to the number of days
        /// </summary>
        /// <param name="years">The number of years we want to convert</param>
        /// <returns>The number of days in that amount of years</returns>
        private int YearsToDays(int years)
        {
            return years * 365;
        }

        /// <summary>
        /// Gets the users age as an integer, validating to make sure it is positive
        /// </summary>
        /// <param name="prompt">The prompt we want to display to the user</param>
        /// <returns>The age of the user</returns>
        private int GetUsersAgeAsInteger(string prompt)
        {
            bool isValid = false;
            int usersAge = 0;

            while(!isValid)
            {
                Console.WriteLine(prompt);
                // Step 1.3 Exceptions Must be handled using "try/catch"
                try
                {
                    // Step 1.1 Ask the user for their age
                    isValid = int.TryParse(Console.ReadLine(), out usersAge);

                    if (!isValid)
                    {
                        Console.WriteLine("Please enter digits only, no decimals.");
                    }
                    else if (usersAge <= 0)
                    {
                        throw new InvalidAgeException();
                    }

                    
                }
                catch(InvalidAgeException)
                {
                    // Step 1.4 Display appropriate error mnessages if the user enters zero or negative numbers
                    Console.WriteLine("Age must be greater than 0.");
                    isValid = false;
                    continue;
                }
            }
            return usersAge;
        }
    }
}
