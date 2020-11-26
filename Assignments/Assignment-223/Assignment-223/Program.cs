using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_223
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumber = GetUserInputAsInteger("Please enter a number: ");
            RandomCalculator rc = new RandomCalculator();

            Console.WriteLine($"Added to a Random Number: {rc.AddRandomNumber(userNumber)}");
            Console.WriteLine($"The number squared is: {rc.SquareNumber(userNumber)}");
            Console.WriteLine($"The {userNumber} number in the Fibonacci sequence is: {rc.Fibonacci(userNumber)}");

            Console.ReadLine();
        }

        static int GetUserInputAsInteger(string prompt)
        {
            Console.WriteLine(prompt);
            while (true)
            {
                try
                {
                    return Convert.ToInt32(Console.ReadLine());
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("Invalid input, please enter a valid number");
                    continue;
                }
            }
        }
    }
}
