using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_314
{
    class Program
    {
        static void Main(string[] args)
        {
            var ageCalculator = new AgeCalculator();

            try
            {
                DateTime usersBirthday = ageCalculator.CalculateUsersAge();
                Console.WriteLine("==> Your birthyear");
                // Step 1.2 Display the year the user was born.
                Console.WriteLine($"You were born in {usersBirthday.Year}");
            } catch(Exception ex)
            {
                // Step 1.5 Display a general message if an exception was caused by anything else
                Console.WriteLine("Catching re-thrown exception from CalculateUsersAge");
                return;
            }

            Console.ReadLine();
        }
    }
}
