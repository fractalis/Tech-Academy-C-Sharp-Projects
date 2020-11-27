using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_261
{
    class Program
    {
        static void Main(string[] args)
        {
            DaysOfTheWeek weekDay = DateTimeHelper.GetUserInputAsDaysOfWeek("Please enter the current day of the week: ");
            Console.WriteLine($"The current day of the week is: {weekDay}.");

            Console.ReadLine();
        }
    }
}
