using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_261
{
    public class DateTimeHelper
    {
        public static DaysOfTheWeek GetUserInputAsDaysOfWeek(string prompt)
        {
            Console.WriteLine(prompt);
            while(true)
            {
                try
                {
                    // Step 1.2 Prompt the user to enter the current day of the week
                    // Step 1.3 Assign the value to a variable of that enum data type you just created
                    DaysOfTheWeek dayofTheWeek = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), Console.ReadLine(), true);
                    return dayofTheWeek;
                }
                catch(ArgumentException)
                {
                    // Step 1.4 Wrap the above statement in a try/catch block and have it print
                    // "Please enter an actual day of the week." to the console if an error occurs
                    Console.WriteLine("Please enter an actual day of the week.");
                    continue;
                }
            }
        }
    }

    // Step 1.1 Create an enum for the days of the week
    /// <summary>
    /// An enum representing the days of the week
    /// </summary>
    public enum DaysOfTheWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
