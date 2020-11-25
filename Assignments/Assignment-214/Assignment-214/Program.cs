using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_214
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1.1 "Create a list of integers..."
            List<int> intList = new List<int>()
            {
                50,
                25,
                18,
                125,
                67,
                90
            };

            DivideByUserInput(intList);
            Console.ReadLine();
        }

        public static void DivideByUserInput(List<int> intList)
        {
            // Step 1.5 "Now put the loop in a try/catch block..."
            try
            {
                // Step 1.1 "Ask for a number to divide each number in the list by..."
                Console.WriteLine("Enter an integer value to divide each number in the list by: ");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                // Step 1.1 "... Write a loop that takes each integer in the list, divides it by
                // number the user entered, and displays the result to the screen."
                foreach (int item in intList)
                {
                    Console.WriteLine($"{item} divided by {userNumber} equals {item / userNumber}");
                }
            }
            catch (FormatException ex) // Catch Format exceptions (e.g, strings)
            {
                Console.WriteLine($"Format error: {ex.Message}");
            } 
            catch (DivideByZeroException ex) // Catch if user enters 0
            {
                Console.WriteLine($"Divide by zero error: {ex.Message}");
            }
            catch (Exception ex) // Catch any other errors that might come up, in this case we don't want the program to crash
            {
                Console.WriteLine($"Unknown error: {ex.Message}");
            }

            // Step 1.5 "...Below and outside of the try/catch block, make the program print a message to the display to let
            // you know the program has emerged from the try/catch block and continued on with program execution."
            Console.WriteLine("Continued execution from try/catch block...");
        }
    }
}
