using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_140
{
    public class DailyReport
    {
        public string StudentName { get; private set; }
        public string StudentCourse { get; private set; }

        public int PageNumber { get; private set; }

        public bool NeedsHelp { get; private set; }

        public string PositiveExperiences { get; private set; }

        public string StudentFeedback { get; private set; }

        public int HoursStudied { get; private set; }

        public DailyReport()
        {

        }

        public void RunReport()
        {
            GetName();
            GetCourse();
            GetPageNumber();
            GetNeedsHelp();
            GetPositiveExperiences();
            GetFeedback();
            GetHoursStudied();
        }

        /// <summary>
        /// Gets the students name
        /// </summary>
        private void GetName()
        {
            Console.WriteLine("What is your name?");
            StudentName = Console.ReadLine();
        }

        /// <summary>
        /// Gets the current course the student is on
        /// </summary>
        private void GetCourse()
        {
            Console.WriteLine("What course are you on?");
            StudentCourse = Console.ReadLine();
        }

        /// <summary>
        /// Displays the given prompt and parses out an integer response and returns it
        /// </summary>
        /// <param name="prompt">The prompt to display to the user</param>
        /// <returns>The parse integer that the user entered</returns>
        public int DisplayPromptAndGetInteger(string prompt)
        {
            // While an invalid value is entered, we continue this loop
            // Otherwise, we return a valid integer
            while (true)
            {
                Console.WriteLine(prompt);
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Invalid value, please enter a valid number.");
                    continue;
                }
            }
        }

        /// <summary>
        /// Gets the current page number the Student is on
        /// </summary>
        private void GetPageNumber()
        {
            PageNumber = DisplayPromptAndGetInteger("What page number?");
        }

        /// <summary>
        /// Gets whether or not the student needs any help, either in a true or false format.
        /// </summary>
        private void GetNeedsHelp()
        {
            // While we have an invalid value, continue this loop otherwise, once we successfully convert
            // a boolean we break the loop.
            while (true)
            {
                Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
                try
                {
                    NeedsHelp = Boolean.Parse(Console.ReadLine());
                    break;
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("Please enter either \"true\" or \"false\"");
                    continue;
                }
            }
        }

        /// <summary>
        /// Get any positive experiences the student may have had
        /// </summary>
        public void GetPositiveExperiences()
        {
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            PositiveExperiences = Console.ReadLine();
        }

        /// <summary>
        /// Gets any feedback from the student
        /// </summary>
        public void GetFeedback()
        {
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            StudentFeedback = Console.ReadLine();
        }

        /// <summary>
        /// Gets the total number of hours studied by the student
        /// </summary>
        public void GetHoursStudied()
        {
           HoursStudied = DisplayPromptAndGetInteger("How many hours did you study today?");
        }
    }
}
