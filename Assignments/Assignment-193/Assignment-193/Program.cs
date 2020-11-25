using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_193
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcatenateStrings();
            Console.WriteLine("----------------");
            UppercaseString();
            Console.WriteLine("----------------");
            BuildRoomDescription();

            Console.ReadLine();
        }
        

        /// <summary>
        /// Builds a room description demonstrating the use of StringBuilder
        /// </summary>
        static void BuildRoomDescription()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("You find yourself in a dimly lit room.");
            stringBuilder.AppendLine("It's damp and smells of mildew.");
            stringBuilder.AppendLine("The only light comes from a flickering light bulb overhead.");
            stringBuilder.AppendLine("There is a steel door in front of you.");
            stringBuilder.AppendLine("There are an assortment of objects scattered on the floor.");

            Console.WriteLine(stringBuilder);
        }

        /// <summary>
        /// Outputs the uppercase version of a string.
        /// </summary>
        static void UppercaseString()
        {
            string quote = "It was the best of times, it was the worst of times.";
            string upperQuote = quote.ToUpper();
            Console.WriteLine(upperQuote);
        }

        /// <summary>
        /// Concatenates three strings together and outputs to the console.
        /// </summary>
        static void ConcatenateStrings()
        {
            string errorCode = "ERR0001";
            string errorMessage = "File corruption detected";
            string errorHelpLink = "https://www.example.com/errors/err0001-file-corruption-detected";

            string errorOutput = errorCode + ": " + errorMessage + "\n" + errorHelpLink;
            Console.WriteLine(errorOutput);
        }
    }
}
