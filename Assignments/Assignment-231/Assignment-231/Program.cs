using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_231
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            // Step 1.3 Have the user enter a number
            int userInput = GetUserInputAsInteger("Please enter a number to divide by two: ");

            // Step 1.3 Call the method on that number. Display the output to the screen
            calculator.DivideByTwo(userInput);

            // Step 1.4 Create a method with output parameters
            int iUserX = GetUserInputAsInteger("Please enter an integer: ");
            int iUserY = GetUserInputAsInteger("Please enter an integer to multiply by: ");
            int result;

            calculator.MultiplyBy(iUserX, iUserY, out result);
            Console.WriteLine($"The result of the multiplication is: {result}");

            // Step 1.5 Overload a method
            double dUserX = GetUserInputAsDouble("Please enter any number: ");
            double dUserY = GetUserInputAsDouble("Please enter any number to multiply by: ");

            double dResult;
            calculator.MultiplyBy(dUserX, dUserY, out dResult);
            Console.WriteLine($"The result of the multiplication is: {dResult}");

            // Step 1.6 Declare a class to be static
            Console.WriteLine($"100 Meters to Centimeters is {UnitConverter.ConvertFromUnitTo("M", "CM", 100)} cm");

            Console.ReadLine();

        }

        public static double GetUserInputAsDouble(string prompt)
        {
            Console.WriteLine(prompt);
            while(true)
            {
                try
                {
                    return Convert.ToDouble(Console.ReadLine());
                }
                catch(FormatException)
                {
                    Console.WriteLine("Invalid value, please enter a number: ");
                    continue;
                }
            }
        }

        public static int GetUserInputAsInteger(string prompt)
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
                    Console.WriteLine("Invalid value, please enter a number: ");
                    continue;
                }
            }
        }
    }
}
