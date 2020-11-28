using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Assignment_297
{
    class Program
    {
        public const string FILE_NAME = "user-numbers.txt";

        static void Main(string[] args)
        {
            while (true)
            {
                // Step 1.1 Askss the user for a number
                Console.WriteLine("Enter a number or enter 'Q' to quit");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "q")
                {
                    break;
                }

                bool parsedSuccessfully = int.TryParse(userInput, out int userNumber);

                if(parsedSuccessfully)
                {
                    // Step 1.2 Logs that number to a text file
                    WriteIntegerToFile(userNumber);
                    
                    // Step 1.3 Prints the text file back to the user
                    ReadFileToUser();
                }
                else
                {
                    Console.WriteLine("Invalid value, please enter a valid number");
                    continue;
                }

            }
        }

        /// <summary>
        /// Appends an integer to the file given by FILE_NAME
        /// </summary>
        /// <param name="userNumber">The number we want to append to FILE_NAME</param>
        private static void WriteIntegerToFile(int userNumber)
        {
            using (StreamWriter sw = new StreamWriter(FILE_NAME, true))
            {
                sw.WriteLine(userNumber);
            }
        }

        /// <summary>
        /// Reads the file of numbers back to the user
        /// </summary>
        private static void ReadFileToUser()
        {
            using (StreamReader sr = new StreamReader(FILE_NAME))
            {
                while(!sr.EndOfStream)
                {
                    Console.WriteLine($"Number: {sr.ReadLine()}");
                }
            }
        }
    }
}
